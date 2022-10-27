using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c10_27
{
    public class Handson08
    {
        public string lastUpdate { get; set; }
        public long npatients { get; set; }
        public long nexits { get; set; }
        public long ndeaths { get; set; }
        public long ncurrentpatients { get; set; }
        public long ninspections { get; set; }
        
        public Area[] area { get; set; }
    }
   
    public class Area
    {
        public string name { get; set; }
        public string name_jp { get; set; }
        public long npatients { get; set; }
        public long ncurrentpatients { get; set; }
        public long nexits { get; set; }
        public long ndeaths { get; set; }
        public long nheavycurrentpatients { get; set; }


    }
}
