using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_05_09_01
{
    internal interface Class2
    {
        double GetRepresentativeValue(double[] values)
        {
            double sum = 0.0;
            for (int i = 0; i < values.Length; i++)
            {
                sum+=values[i];
            }return sum/values.Length;
        }


}
}
