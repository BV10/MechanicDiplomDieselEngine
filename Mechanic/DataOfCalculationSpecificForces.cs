using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechanic
{
    class DataOfCalculationSpecificForces
    {
        //кути
        public List<int> Angles { get; set; } = new List<int>();
        //тиск газів на поршень
        public List<double> P { get; set; } = new List<double>();
        //значення Pr
        public List<double> Pr { get; set; } = new List<double>();
        //прискорення поршня
        public List<double> J { get; set; } = new List<double>();
        //значення Pj
        public List<double> Pj{ get; set; } = new List<double>();
        //значення Psum
        public List<double> Psum { get; set; } = new List<double>();
        //tgBeta
        public List<double> TgBeta{ get; set; } = new List<double>();
        //N питома сила
        public List<double> N { get; set; } = new List<double>();
        //K питома сила
        public List<double> K { get; set; } = new List<double>();
        // cosBeta
        public List<double> CosBeta{ get; set; } = new List<double>();
        //sin(phi + beta)/cosBeta
        public List<double> SinPhiPlBetaOnCosBeta { get; set; } = new List<double>();
        //T питома сила
        public List<double> T { get; set; } = new List<double>();
        //cos(phi + beta)/cosBeta
        public List<double> CosPhiPlBetaOnCosBeta { get; set; } = new List<double>();
        //Z питома сила
        public List<double> Z { get; set; } = new List<double>();

        public int LengthInternalObject
        {
            get
            {
                return Angles.Count;
            }
        }
    }
}
