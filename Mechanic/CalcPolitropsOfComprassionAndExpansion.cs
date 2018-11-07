using System;
using System.Threading;
using System.Threading.Tasks;
using static System.Math;


namespace Mechanic
{
    class CalcPolitropsOfComprassionAndExpansion
    {
        // token source
        public CancellationTokenSource CancellationTokenSource { get; set; } = null;

        //константные данные для рассчета

        //кути
        private int StartAngle { get; set; } = 0;
        private int EndAngle { get; set; } = 180;
        // R  - для розрахунку переміщення поршня S
        private int R { get; set; } = 165;
        // відношення радіуса кривошипа до довжини шатуна - для розрахунку переміщення поршня S
        private double Lambda { get; set; } = 0.25;
        //діаметр цилідндра
        private double DiamOfCylinder { get; set; } = 0.318;
        //хід поршня
        private double RunningOfPiston { get; set; } = 0.330;
        //геометрична ступінь стиснення двигуна
        private double Epsilon { get; set; } = 12.5;
        // тиск повітря у надувному колекторі
        private double Pk { get; set; } = 0.142;

        // дані про політропу     
        public DataPolitropsOfComprassionAndExpansion DataPolitrops { get; private set; } = null;

        private const double DEFAULT_INDICATOR_POLITROP_COMPRASS = 1.37;
        private const double DEFAULT_INDICATOR_POLITROP_EXPANSION = 1.27;

        private const double MU = 1.035; // дійсний коефіцієнт молекул зміни
        private const double Tz = 1953; //1953K
        private const double LAMBDA_Z = 1.77; // ступінь підвищення тиску
        private const double Ta = 342.2; // температура тіла на початку стиснення
        private readonly double Tc;

        //середній показник стиснення політропи
        private double n1;
        public double N1
        {
            get
            {
                return n1;
            }

            set
            {
                if (value < 1.36 || value > 1.38)
                {
                    throw new Exception("Значення середнього показника політропи може бути від 1.36 до 1.38");
                }
                n1 = value;
            }
        }

        //середній показник розширення політропи
        private double n2;

        private const double PZ = 7.0; // pz

        public double N2
        {
            get
            {
                return n2;
            }

            set
            {
                if (value < 1.26 || value > 1.28)
                {
                    throw new Exception("Значення середнього показника політропи розширення може бути від 1.26 до 1.28");
                }
                n2 = value;
            }
        }

        //робочий об'єм циліндра
        public double Vh { get; }

        //об'єм камери стиснення
        public double Vc { get; }

        public CalcPolitropsOfComprassionAndExpansion(DataPolitropsOfComprassionAndExpansion dataPolitrops)
        {
            this.DataPolitrops = dataPolitrops;
            this.N1 = DEFAULT_INDICATOR_POLITROP_COMPRASS;
            this.N2 = DEFAULT_INDICATOR_POLITROP_EXPANSION;

            this.Vh = ((PI * this.DiamOfCylinder * this.DiamOfCylinder) / 4) * this.RunningOfPiston;
            this.Vc = this.Vh / (this.Epsilon - 1);
            this.Tc = Ta * Pow(this.Epsilon, this.N1 - 1);
        }

        public async Task CalcPolitropsDataAsync(int deltaAngle)
        {
            CancellationTokenSource = new CancellationTokenSource();
            var token = CancellationTokenSource.Token;
            this.DataPolitrops = new DataPolitropsOfComprassionAndExpansion();

            await Task.Factory.StartNew(() => CalcPolitropsData(deltaAngle, token), token);
        }


        private void CalcPolitropsData(int deltaAngle, CancellationToken token)
        {
            for (int currentAngle = this.StartAngle; currentAngle <= this.EndAngle; currentAngle += deltaAngle)
            {
                //кути політроп
                this.DataPolitrops.Angles.Add(currentAngle);
                //переміщення поршня
                double s = calcMovementPiston(currentAngle);
                this.DataPolitrops.S.Add(s);
                //добуток Fn*S
                double multiplesFnAndS = calcMultipleFnAndS(s);
                this.DataPolitrops.MultiplesFnAndS.Add(multiplesFnAndS);
                //поточний об'єм циліндра
                double v = calcVolumeCylinder(multiplesFnAndS);
                this.DataPolitrops.V.Add(v);
                //відношення об'ємів  Va/V
                double Va = calcVa();
                double ratioVaToV = Va / v;
                this.DataPolitrops.RatioVaToV.Add(ratioVaToV);
                //відношення об'ємів  (Va/V)^n1
                double ratioVaToVInDegreeN1 = Pow(ratioVaToV, this.N1);
                this.DataPolitrops.RatioVaToVInDegreeN1.Add(ratioVaToVInDegreeN1);
                //поточний тиск p на лінії стиснення
                double pressureOnLineCompression = calcPressureOnLineCompression(ratioVaToVInDegreeN1);
                this.DataPolitrops.PressureOnLineCompression.Add(pressureOnLineCompression);
                //відношення об'ємів  Vz/V
                double Vz = calcVz(calcRo());
                double ratioVzToV = Vz / v;
                this.DataPolitrops.RatioVzToV.Add(ratioVzToV);
                //відношення об'ємів (Vz/V)^n2
                double ratioVzToVInDegreeN2 = Pow(ratioVzToV, this.N2);
                this.DataPolitrops.RatioVzToVInDegreeN2.Add(ratioVzToVInDegreeN2);
                //поточний тиск p на лінії розширення
                double pressureOnLineExpansion = calcPressureOnLineExpansion(ratioVzToVInDegreeN2);
                this.DataPolitrops.PressureOnLineExpansion.Add(pressureOnLineExpansion);
                //cancel execute calc func
                if (token.IsCancellationRequested)
                {
                    token.ThrowIfCancellationRequested();
                }
            }
        }

        private double calcVa()
        {
            return this.Vc + this.Vh;
        }

        //поточний тиск p на лінії розширення
        private double calcPressureOnLineExpansion(double ratioVzToVInDegreeN2)
        {
            // p = pz*(1/((V/Vz)^n2))
            //pz - найбільший тиск згорання            
            return PZ / ratioVzToVInDegreeN2;
        }

        //Vz
        private double calcVz(double ro)
        {
            //Vz = p(ro) * Vc        
            return ro * this.Vc;
        }

        // ступінь попереднього розміщення
        private double calcRo()
        {
            // ro = (mu*Tz)/(lamdaZ * Tc)
            // mu = (mu0 + gamma)/(1+gamma)            
            double ro = (MU * Tz) / (LAMBDA_Z * Tc);
            return ro;
        }

        //поточний тиск p на лінії стиснення
        private double calcPressureOnLineCompression(double ratioVaToVInDegreeN)
        {
            //тиск на початку стиснення pa = [0.9...0.96]*pk
            double koefPa = 0.93 * this.Pk;
            return koefPa * ratioVaToVInDegreeN;
        }

        //поточний об'єм циліндра
        private double calcVolumeCylinder(double multiplesFnAndS)
        {
            return this.Vc + multiplesFnAndS;
        }

        //добуток Fn*S
        private double calcMultipleFnAndS(double s)
        {
            return ((PI * this.DiamOfCylinder * this.DiamOfCylinder) / 4) * s;
        }

        //переміщення поршня
        private double calcMovementPiston(int currentAngle)
        {
            return this.R * (
                (1 - Cos(currentAngle)) +
                (1 / this.Lambda) * (1 - Sqrt(1 - this.Lambda * this.Lambda * Sin(currentAngle) * Sin(currentAngle)))
                );
        }
    }
}
