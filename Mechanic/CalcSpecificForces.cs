using System;
using System.Threading;
using System.Threading.Tasks;
using static System.Math;

namespace Mechanic
{
    internal class CalcSpecificForces
    {
        //-------КОНСТАНТЫ
        //кути
        private const int START_ANGLE = 0;
        private const int END_ANGLE = 720;
        //тиск газів на поршень
        private const double P = 6.3;
        // тиск газів зі сторони картера
        private const double P0 = 0.1;
        //частота обертання колінвалу
        private const double N = 12.5;
        //кутова швидкысть
        private readonly double W;
        //


        //данные и методы из политропы
        private CalcPolitrops CalcPolitrops { get; set; }
        // данные для питомих сил        
        public DataOfCalculationSpecificForces DataSpecificForces { get; private set; }
        //токен отмены метода вычисления
        public CancellationTokenSource CancellationTokenSource { get; private set; } = null;

        public CalcSpecificForces(CalcPolitrops calcPolitrops)
        {
            this.CalcPolitrops = calcPolitrops;           
            this.W = 2 * Math.PI * CalcSpecificForces.N;
        }

        public async Task CalcDataOfSpecificForcesAsync(int deltaAngle)
        {
            CancellationTokenSource = new CancellationTokenSource();
            var token = CancellationTokenSource.Token;
            this.DataSpecificForces = new DataOfCalculationSpecificForces();

            await Task.Factory.StartNew(() => CalcDataOfSpecificForces(deltaAngle, token), token);
        }

        private void CalcDataOfSpecificForces(int deltaAngle, CancellationToken token)
        {
            for (int currentAngle = START_ANGLE; currentAngle <= END_ANGLE; currentAngle += deltaAngle)
            {
                //кут в радианах
                double currentAngleInRad = currentAngle * (PI / 180.0);
                //кути
                this.DataSpecificForces.Angles.Add(currentAngle);
                //тиск газів на поршень
                this.DataSpecificForces.P.Add(CalcSpecificForces.P);
                //тиск газів зі сторони картера
                double pr = CalcSpecificForces.P - CalcSpecificForces.P0;
                this.DataSpecificForces.Pr.Add(Round(pr, 3));
                //прискорення поршня    
                double j = calcJ(currentAngleInRad);
                this.DataSpecificForces.J.Add(Round(j, 3));
                //питомы сили інерції мас
                double pj = calcPj(j);
                this.DataSpecificForces.Pj.Add(Round(pj, 3));
                //сумарна питома сила
                double pSum = pj + pr;
                this.DataSpecificForces.Psum.Add(Round(pSum, 3));
                //tgBeta
                double cosBeta = Sqrt(1 - CalcPolitrops.LAMBDA * CalcPolitrops.LAMBDA *
                    Sin(currentAngleInRad) * Sin(currentAngleInRad));
                double beta = Math.Acos(cosBeta);
                double tanBeta = Tan(beta);
                this.DataSpecificForces.TgBeta.Add(Round(tanBeta, 3));
                //N сила що спрямована нормально до осі циліндра
                this.DataSpecificForces.N.Add(Round(pSum * tanBeta, 3));
                //cosBeta
                this.DataSpecificForces.CosBeta.Add(Round(cosBeta,3));
                //K сила що діє вздовж осі циліндра
                this.DataSpecificForces.K.Add(Round(pSum / cosBeta, 3));
                //sin(phi+beta)/cos(beta)
                this.DataSpecificForces.SinPhiPlBetaOnCosBeta.Add(Round(Sin(currentAngleInRad + beta) / cosBeta, 3));
                //T тангенціальна сила
                this.DataSpecificForces.T.Add(Round(pSum * (Sin(currentAngleInRad + beta) / cosBeta), 3));
                //cos(phi+beta)/cos(beta)
                this.DataSpecificForces.CosPhiPlBetaOnCosBeta.Add(Round(Cos(currentAngleInRad + beta) / cosBeta, 3));
                //Z нормальна сила спрямована вздовж кривошипа
                this.DataSpecificForces.Z.Add(Round(pSum * (Cos(currentAngleInRad * beta) / cosBeta), 3));
                //cancel execute calc func
                if (token.IsCancellationRequested)
                {
                    token.ThrowIfCancellationRequested();
                }
            }
        }

        private double calcPj(double j)
        {
            //pj = -10^(-6)*(M/Fn)*j m =83.4
            return -0.000001 * (83.4 / this.CalcPolitrops.Fn) * j;
        }

        //прискорення поршня
        private double calcJ(double angle)
        {
            return CalcPolitrops.R * this.W * this.W * (Cos(angle) + CalcPolitrops.LAMBDA * Cos(2 * angle));
        }
    }
}
