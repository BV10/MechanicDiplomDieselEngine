using System.Collections.Generic;

namespace Mechanic
{
    public class DataPolitropsOfComprassionAndExpansion
    {
        public enum IterPosition
        {
            Start,
            End
        }

        public class Iterator
        {
            private IterPosition iterStarter;
            private int currentPosition;
            private DataPolitropsOfComprassionAndExpansion dataPolitrops;

            public Iterator(DataPolitropsOfComprassionAndExpansion dataPolitrops, IterPosition iterPosition)
            {
                this.iterStarter = iterPosition;
                this.dataPolitrops = dataPolitrops;
                this.currentPosition = iterPosition == IterPosition.Start ? -1 : this.dataPolitrops.Angles.Count;
            }

            public bool hasNext()
            {
                if (iterStarter == IterPosition.Start)
                {
                    return currentPosition < dataPolitrops.LengthInternalObject;
                }
                else
                {
                    return currentPosition > -1;
                }
            }

            public int next()
            {
                return iterStarter == IterPosition.Start ? ++currentPosition : --currentPosition;
            }

            public void reset(IterPosition iterPosition)
            {
                this.iterStarter = iterPosition;
                this.currentPosition = iterPosition == IterPosition.Start ? -1 : this.dataPolitrops.Angles.Count;
            }
        }

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

        public Iterator getIterator(IterPosition iterPosition)
        {
            return new Iterator(this, iterPosition);
        }

        public int LengthInternalObject
        {
            get
            {
                return Angles.Count;
            }
        }
    }
}
