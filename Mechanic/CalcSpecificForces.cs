using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Math;

namespace Mechanic
{
    class CalcSpecificForces
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
        public CancellationTokenSource CancellationTokenSource { get; private set; }

        public CalcSpecificForces(DataOfCalculationSpecificForces dataOfCalculationSpecificForces,
            CalcPolitrops calcPolitrops)
        {
            this.CalcPolitrops = calcPolitrops;
            this.DataSpecificForces = dataOfCalculationSpecificForces;

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
                this.DataSpecificForces.Pr.Add(pr);
                //прискорення поршня     
                double j = calcJ(currentAngleInRad);
                this.DataSpecificForces.J.Add(j);
                //питомы сили інерції мас
                double pj = calcPj(j);
                this.DataSpecificForces.Pj.Add(pj);
                //сумарна питома сила
                this.DataSpecificForces.Psum.Add(pj + pr);
                //tgBeta
                this.DataSpecificForces.TgBeta.Add(Tan(currentAngleInRad));
                //N сила що спрямована нормально до осі циліндра
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
            double
            return CalcPolitrops.R * this.W * this.W * (Cos(angle) + CalcPolitrops.LAMBDA * Cos(2 * angle));
        }
    }
}
