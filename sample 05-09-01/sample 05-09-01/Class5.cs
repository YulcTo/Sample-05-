using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_05_09_01
{
    internal class RepresentaiveValueCalculator
    {
        public Class2 RValue { get; set; }

        public RepresentaiveValueCalculator(Class2 value)
        {
            RValue = value;
        }

        public double GetRepresentativeValue(double[] array)
        {
            return RValue.GetRepresentativeValue(array);
        }


    }
}

