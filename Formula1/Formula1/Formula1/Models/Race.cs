using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1.Models
{
    public class Race
    {
        public string Name { get; set; }
        public string Circuit { get; set; }
        public int NumberOfLaps { get; set; }
        public double CircuitLength { get; set; }
        public double RaceDistance { get; set; }
        public DateTime Date { get; set; }
        public string MapUrl { get; set; }

        public bool IsLast { get; set; }

    }
}
