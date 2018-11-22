using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechanic
{
    class TorqueUniformity
    {
        public double Mmax { get; private set; } = 0.0;
        public double Mmin { get; private set; } = 0.0;
        public double Mu { get; private set; } = 0.0;

        public TorqueUniformity(double mMax, double mMin, double mu)
        {
            Mmax = mMax;
            Mmin = mMin;
            Mu = mu;
        }
    }
}
