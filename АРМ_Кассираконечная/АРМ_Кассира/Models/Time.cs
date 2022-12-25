using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace АРМ_Кассира.Models
{
    public class Time
    {
        public string MinTime { get; set; }
        public string MaxTime { get; set; }
        public Time(string mintime, string maxtime)
        {
            MinTime = mintime;
            MaxTime = maxtime;
        }
    }
}
