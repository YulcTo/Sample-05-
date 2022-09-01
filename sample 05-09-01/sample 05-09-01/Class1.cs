using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CarClas;

namespace ClasTester01
{
    public class Class1
    {
        public static void HansOn(Car car)
        {
            car.Speed = 100f;
            car.Rune(123f);
            
        }
        public static void HAnsOn_2(Car car)
        {
            car = new Car(100f);
            car.Rune(12345f);
        }
    }
}
