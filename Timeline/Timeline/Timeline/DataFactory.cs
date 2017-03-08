using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timeline.Models;

namespace Timeline
{
    public static class DataFactory
    {
        public static IList<ExerciseClass> Classes { get; private set; }

        static DataFactory()
        {
            Classes = new ObservableCollection<ExerciseClass>
            {
                new ExerciseClass
                {
                    ClassName = "Aerobics",
                    Instructor = "Joe Smith",
                    ClassTime = DateTime.Now.AddHours(2),
                },
                 new ExerciseClass
                {
                    ClassName = "Aerobics",
                    Instructor = "Joe Smith",
                    ClassTime = DateTime.Now.AddHours(-2),
                },
                 new ExerciseClass
                {
                    ClassName = "Aerobics",
                    Instructor = "Joe Smith",
                    ClassTime = DateTime.Now.AddHours(3),
                },
                 new ExerciseClass
                {
                    ClassName = "Aerobics",
                    Instructor = "Joe Smith",
                    ClassTime = DateTime.Now.AddHours(1),
                },
            };
        }
    }
}
