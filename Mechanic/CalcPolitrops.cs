﻿using System;
using System.Threading;
using System.Threading.Tasks;
using static System.Math;


namespace Mechanic
{
    class CalcPolitrops
    {        

        //коефіцієнт надлишку повітря
        public const double ALPHA = 1.8;
        //теоретично необхідна кількість повітря для повного згоряння палива 1 кг
        public const double L0 = 0.495;
        // дефолтная константа округления дробных чисел
        private const int DEFAULT_ROUND_NUMB = 3;
        // token source
        public CancellationTokenSource CancellationTokenSource { get; set; } = null;

        //константные данные для рассчета

        //кути
        private int StartAngle { get; set; } = 0;
        private int EndAngle { get; set; } = 180;
        // R(в метрах)  - для розрахунку переміщення поршня S в м
        public const double R = 0.165;
        // відношення радіуса кривошипа до довжини шатуна - для розрахунку переміщення поршня S
        public const double LAMBDA = 0.25;
        //діаметр цилідндра
        private double DiamOfCylinder { get; set; } = 0.318;
        //хід поршня
        private double RunningOfPiston { get; set; } = 0.330;
        //геометрична ступінь стиснення двигуна
        public double Epsilon { get; private set; } = 12.5;
        //коефіцієнт залишкових газів
        public const double GAMMA = 0.02;
        //ТЕМПЕРАТУРА ПОВЫТРЯ В НАДУвному колекторі 50 градусів + 273
        public const int Tk = 323;
        // тиск повітря у надувному колекторі
        public readonly double Pk = 0.142;
        // коеф Pa
        private double koefPa;
        // pC
        private double pC;
        // lambda - ступінь підвищення -тиску
        private double lambdaDegreeIncreasePressure;
        //коефіцієнт подовження
        public double EtaV { get; private set; } = 0.0;
        // дані про політропу     
        public DataPolitropsOfComprassionAndExpansion DataPolitrops { get; private set; } = null;


        private const double DEFAULT_INDICATOR_POLITROP_COMPRASS = 1.37;
        private const double DEFAULT_INDICATOR_POLITROP_EXPANSION = 1.27;

        private const double MU = 1.035; // дійсний коефіцієнт молекул зміни
        private const double Tz = 1953; //1953K        
        private const double Ta = 342.2; // температура тіла на початку стиснення
        private readonly double Tc;

        //площа поршня
        public double Fn { get; private set; }

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
                if (value < 0.0 || value > 2.0)
                {
                    throw new Exception("Значення середнього показника політропи може бути від 1.36 до 1.38");
                }
                n1 = value;
                this.PC = Round(this.KoefPa * Pow(this.Epsilon, this.n1), 2);
            }
        }

        //середній показник розширення політропи
        private double n2;

        private double pZ; // pz

        public double N2
        {
            get
            {
                return n2;
            }

            set
            {
                if (value < 0.0 || value > 2.0)
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
        public double PC
        {
            get => pC;
            private set
            {
                this.pC = value;
                this.PZ = this.lambdaDegreeIncreasePressure * this.pC;
            }
        }
        public double PZ { get => pZ; set => pZ = value; }
        public double RO { get; private set; }

        public double LambdaDegreeIncreasePressure
        {
            get => lambdaDegreeIncreasePressure;
            set
            {
                lambdaDegreeIncreasePressure = value;
                this.PZ = value * this.PC;
                this.RO = (MU * Tz) / (this.LambdaDegreeIncreasePressure * Tc);
            }
        }

        public double KoefPa { get => koefPa; private set => koefPa = value; }

        public CalcPolitrops(double Pk, DataPolitropsOfComprassionAndExpansion dataPolitrops)
        {
            this.DataPolitrops = dataPolitrops;
            this.N1 = DEFAULT_INDICATOR_POLITROP_COMPRASS;
            this.N2 = DEFAULT_INDICATOR_POLITROP_EXPANSION;

            this.Vh = ((PI * this.DiamOfCylinder * this.DiamOfCylinder) / 4) * this.RunningOfPiston;
            this.Vc = this.Vh / (this.Epsilon - 1);
            this.Tc = Ta * Pow(this.Epsilon, this.N1 - 1);

            this.Pk = Pk;
            this.KoefPa = Round(0.93 * this.Pk, 3);
            this.PC = Round(this.KoefPa * Pow(this.Epsilon, this.N1), 2);

            this.Fn = (PI * this.DiamOfCylinder * this.DiamOfCylinder) / 4;

            this.EtaV = (this.Epsilon / (this.Epsilon - 1)) *
                ((this.KoefPa * CalcPolitrops.Tk) / (this.Pk * CalcPolitrops.Ta)) *
                (1 / (1 + GAMMA));
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
                this.DataPolitrops.S.Add(Round(s, DEFAULT_ROUND_NUMB));
                //добуток Fn*S
                double multiplesFnAndS = calcMultipleFnAndS(s);
                this.DataPolitrops.MultiplesFnAndS.Add(Round(multiplesFnAndS, 4));
                //поточний об'єм циліндра
                double v = calcVolumeCylinder(multiplesFnAndS);
                this.DataPolitrops.V.Add(Round(v, 5));
                //відношення об'ємів  Va/V
                double Va = calcVa();
                double ratioVaToV = Va / v;
                this.DataPolitrops.RatioVaToV.Add(Round(ratioVaToV, DEFAULT_ROUND_NUMB));
                //відношення об'ємів  (Va/V)^n1
                double ratioVaToVInDegreeN1 = Pow(ratioVaToV, this.N1);
                this.DataPolitrops.RatioVaToVInDegreeN1.Add(Round(ratioVaToVInDegreeN1, DEFAULT_ROUND_NUMB));
                //поточний тиск p на лінії стиснення
                double pressureOnLineCompression = calcPressureOnLineCompression(ratioVaToVInDegreeN1);
                this.DataPolitrops.PressureOnLineCompression.Add(Round(pressureOnLineCompression, DEFAULT_ROUND_NUMB));
                //відношення об'ємів  Vz/V
                double Vz = calcVz();
                Console.WriteLine(Vz);
                double ratioVToVz = v / Vz;
                this.DataPolitrops.RatioVToVz.Add(Round(ratioVToVz, DEFAULT_ROUND_NUMB));
                //відношення об'ємів (Vz/V)^n2
                double ratioVzToVInDegreeN2 = Pow(ratioVToVz, this.N2);
                this.DataPolitrops.RatioVzToVInDegreeN2.Add(Round(ratioVzToVInDegreeN2, DEFAULT_ROUND_NUMB));
                //поточний тиск p на лінії розширення
                double pressureOnLineExpansion = calcPressureOnLineExpansion(ratioVzToVInDegreeN2);
                // замінити на pZ, якщо тиск більший pZ
                if(this.LambdaDegreeIncreasePressure != 1.0)
                {
                    pressureOnLineExpansion = pressureOnLineExpansion > PZ ? PZ : pressureOnLineExpansion;
                }
                else //при lambda 1.0 совпадает давление
                {
                    pressureOnLineExpansion = pressureOnLineCompression;
                }
               
                this.DataPolitrops.PressureOnLineExpansion.Add(Round(pressureOnLineExpansion, DEFAULT_ROUND_NUMB));
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
        private double calcVz()
        {
            //Vz = p(ro) * Vc        
            return this.RO * this.Vc;
        }

        //поточний тиск p на лінії стиснення
        private double calcPressureOnLineCompression(double ratioVaToVInDegreeN)
        {
            //тиск на початку стиснення pa = [0.9...0.96]*pk            
            return this.KoefPa * ratioVaToVInDegreeN;
        }

        //поточний об'єм циліндра
        private double calcVolumeCylinder(double multiplesFnAndS)
        {
            return this.Vc + multiplesFnAndS;
        }

        //добуток Fn*S
        private double calcMultipleFnAndS(double s)
        {
            return (this.Fn) * s;
        }

        //переміщення поршня
        private double calcMovementPiston(int currentAngle)
        {

            double angleInRad = currentAngle * (PI / 180.0);
            return R * (
                (1 - Cos(angleInRad)) +
                (1 / CalcPolitrops.LAMBDA) * (1 - Sqrt(1 - CalcPolitrops.LAMBDA * CalcPolitrops.LAMBDA * Sin(angleInRad) * Sin(angleInRad)))
                );
        }

        public double CalcGraphicPip(DataPolitropsOfComprassionAndExpansion dataPolitrops)
        {
            
            double sumF = 0.0;
            for (int i = 0; i < dataPolitrops.LengthInternalObject - 1; i++)
            {
                sumF += (dataPolitrops.V[i + 1] - dataPolitrops.V[i]) *
                    ((dataPolitrops.PressureOnLineExpansion[i] + dataPolitrops.PressureOnLineExpansion[i + 1]) / 2 -
                    (dataPolitrops.PressureOnLineCompression[i] + dataPolitrops.PressureOnLineCompression[i + 1]) / 2);
            }

            return sumF / this.Vh;
        }

        public double CalcAnalyticPip()
        {
            double valOfFormula1 = this.PC / (this.Epsilon - 1);
            double valOfFormula2 = this.LambdaDegreeIncreasePressure * (this.RO - 1);
            double valOfFormula3 = ((this.LambdaDegreeIncreasePressure * this.RO) / (this.N2 - 1)) *
                (1 - 1 / (Pow(this.Epsilon / this.RO, this.N2 - 1)));
            double valOfFormula4 = (1 / (this.N1 - 1)) *
                (1 - 1 / (Pow(this.Epsilon, this.N1 - 1)));

            return valOfFormula1 * (valOfFormula2 + valOfFormula3 - valOfFormula4);
        }


        public double CalcEtaI()
        {            
            return 8.314 *
                ((this.CalcGraphicPip(this.DataPolitrops) * CalcPolitrops.ALPHA * CalcPolitrops.L0 * CalcPolitrops.Tk) /
                (41500 * this.EtaV * this.Pk));
        }

        public double CalcNi()
        {
            return (2000 * this.CalcGraphicPip(this.DataPolitrops) * this.Vh * 12.5) / 4;
        }

        public double CalcBi(DataPolitropsOfComprassionAndExpansion dataPolitrops)
        {
            double ni = CalcEtaI();
            if (ni == 0.0)
            {
                return 0;
            }
                
            return (3600 / (41500 * ni));
        }
    }
}
