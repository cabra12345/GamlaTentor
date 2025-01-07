using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HönanEllerÄgget
{
    public class Hen
    {
        public string Name { get; set; }
        public int Stall { get; set; }
        public double Weight { get; set; }
        public Hen(string name, int stall, double weight)
        {
            Name = name;
            Stall = stall;
            Weight = weight;
        }
    }
}

