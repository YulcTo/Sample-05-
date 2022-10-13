using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_05_09_01
{

    public class Delegate
    {


        public static string sum(int a, int b)
        {

            return "足し算" + (a + b).ToString();
        }
        public static string ke(int a, int b)
        {

            return "掛け算" + (a * b).ToString();
        }
        public static string wr(int a, int b)
        {

            return "割り算" + (a / b).ToString();
        }



    }
}

