using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechanic
{
    class DataPolitropsOfComprassionAndExpansion
    {        
        //кути політроп
        public List<int> Angles { get; set; } = new List<int>();
        //переміщення поршня
        public List<double> S { get; set; } = new List<double>();
        //добуток Fn*S
        public List<double> MultiplesFnAndS { get; set; } = new List<double>();
        //поточний об'єм циліндра
        public List<double> V { get; set; } = new List<double>();
        //відношення об'ємів  Va/V
        public List<double> RatioVaToV { get; set; } = new List<double>();
        //відношення об'ємів (Va/V)^n1
        public List<double> RatioVaToVInDegreeN1 { get; set; } = new List<double>();
        //поточний тиск p на лінії стиснення
        public List<double> PressureOnLineCompression { get; set; } = new List<double>();
        //відношення об'ємів  Vz/V
        public List<double> RatioVToVz { get; set; } = new List<double>();
        //відношення об'ємів (Vz/V)^n2
        public List<double> RatioVzToVInDegreeN2 { get; set; } = new List<double>();
        //поточний тиск p на лінії розширення
        public List<double> PressureOnLineExpansion { get; set; } = new List<double>();

        public int LengthInternalObject
        {
            get
            {
                return Angles.Count;
            }
        }
    }
}
