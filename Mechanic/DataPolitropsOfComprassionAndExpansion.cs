﻿using System;
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
        //відношення об'ємів (Va/V)^n
        public List<double> RatioVaToVInDegreeN { get; set; } = new List<double>();
        //поточний тиск p на лінії стиснення
        public List<double> PressureOnLineCompression { get; set; } = new List<double>();
        //відношення об'ємів  Vz/V
        public List<double> RatioVzToV { get; set; } = new List<double>();
        //відношення об'ємів (Vz/V)^n
        public List<double> RatioVzToVInDegreeN { get; set; } = new List<double>();
        //поточний тиск p на лінії розширення
        public List<double> PressureOnLineExpansion { get; set; } = new List<double>();
    }
}
