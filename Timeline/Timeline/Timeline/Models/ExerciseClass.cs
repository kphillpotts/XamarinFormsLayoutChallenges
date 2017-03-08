using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timeline.Models
{
    public class ExerciseClass
    {
        public DateTime ClassTime { get; set; }
        public string ClassName { get; set; }
        public string Instructor { get; set; }

        public bool IsLast { get; set; } = false;
    }
}
