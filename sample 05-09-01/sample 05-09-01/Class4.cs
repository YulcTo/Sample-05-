using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_05_09_01
{
    internal class Madian:Class2
    {
        double GetRepresentativeValue(double[] values)
        {
            double median = 0;
            double [] clone=(double[])values.Clone();
            if (clone.Length % 2 == 1)
            {
                int targetIndex = (clone.Length - 1) / 2;
                double medianSum = clone[targetIndex] + clone[targetIndex - 1];
                return medianSum/2.0;
            }
            else
            {
                int targetIndex = clone.Length / 2;
                return clone[targetIndex];
            }
        }

    }
}
