using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nöjesfältet
{
    public class Attraction
    {
        public string Name { get; set; }
        public double AverageRating { get; set; }
        public double AverageQueueTime { get; set; }
        public Attraction(string name, double rate, double time)
        {
            Name = name;
            AverageRating = rate;
            AverageQueueTime = time;
        }
    }
}
