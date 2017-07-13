using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1.Models
{
    public class Driver
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public string Team { get; set; }
        public string Country { get; set; }
        public string CountryFlag {
            get
            {
                return $"{Country}.png";
            }
        }

        public string Photo
        {
            get
            {
                return $"{Name}.png";
            }
        }
    }
}
