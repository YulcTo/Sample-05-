using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClas

{
    public class Car
    {
        public float Position=0;
        public float Position_a =0;
        public float Position_b =0;
        public float Position_c = 1f;
        public float Speed = 2f;

        public  Car(float CarSpeed)
         {
            this.Speed = CarSpeed;
         }

        public void Rune(float time)
        {
            this.Position += this.Speed * time;
            Position_a = 4f * time;
            Position_b = 2f * time;
            Position_c = 1f * time;

        }


    }
}
