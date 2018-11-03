using System;
using static System.Math;


namespace Mechanic
{
    class CalcPolitropsOfComprassionAndExpansion
    {
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

        public CalcPolitropsOfComprassionAndExpansion(DataPolitropsOfComprassionAndExpansion dataPolitrops, double n1, double n2)
        {
            this.DataPolitrops = dataPolitrops;
            this.N1 = n1;
            this.N2 = n2;

            this.Vh = ((PI * this.DiamOfCylinder * this.DiamOfCylinder) / 4) * this.RunningOfPiston;
            this.Vc = this.Vh / (this.Epsilon - 1);
        }

        public DataPolitropsOfComprassionAndExpansion calcPolitropsData(int deltaAngle)
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
                this.DataPolitrops.RatioVaToV.Add(calcRatioVaToV(v));
                //відношення об'ємів  (Va/V)^n1
                double ratioVaToVInDegreeN = Pow(calcRatioVaToV(v), this.N1);
                this.DataPolitrops.RatioVaToV.Add(ratioVaToVInDegreeN);
                //поточний тиск p на лінії стиснення
                double pressureOnLineCompression = calcPressureOnLineCompression(ratioVaToVInDegreeN);
                //відношення об'ємів  Vz/V
                double Vz = calcVz();
                double ratioVzToV = calcRatioVzToV()
                //відношення об'ємів (Vz/V)^n
                //поточний тиск p на лінії розширення
            }

        }

        private double calcVz()
        {
            //Vz = p(ro) * Vc
            // ro = (mu*Tz)/(lamdaZ * Tc)

            #region mu
                // mu = (mu0 + gamma)/(1+gamma)
                // mu0 = M2/M1
                // M1 = 1.8
                //M2 = M0 + (lamba - 1) * L0

            #endregion


            return ro * this.Vc;
        }

        private double calcPressureOnLineCompression(double ratioVaToVInDegreeN)
        {
            //тиск на початку стиснення pa = [0.9...0.96]*pk
            double koefPa = 0.93 * this.Pk;
            return koefPa * ratioVaToVInDegreeN;
        }

        private double calcRatioVaToV(double v)
        {
            return (this.Vc + this.Vh) / v;
        }

        private double calcVolumeCylinder(double multiplesFnAndS)
        {           
            return this.Vc + multiplesFnAndS;
        }

        private double calcMultipleFnAndS(double s)
        {
            return ((PI * this.DiamOfCylinder * this.DiamOfCylinder) / 4) * s;
        }

        private double calcMovementPiston(int currentAngle)
        {
            return this.R * (
                (1 - Cos(currentAngle)) +
                (1 / this.Lambda) * (1 - Sqrt(1 - this.Lambda * this.Lambda * Sin(currentAngle) * Sin(currentAngle)))
                );
        }
    }
}
