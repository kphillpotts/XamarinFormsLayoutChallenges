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

        private static DateTime TodayAt(int hour, int minute)
        {
            return new DateTime(DateTime.Now.Year,
                DateTime.Now.Month,
                DateTime.Now.Day,
                hour, minute, 0);
        }

        static DataFactory()
        {
            
            Classes = new ObservableCollection<ExerciseClass>
            {
                new ExerciseClass
                {
                    ClassName = "Yoga",
                    Instructor = "Maharshi Patanjali",
                    ClassTime = TodayAt(8,00),
                },
                 new ExerciseClass
                {
                    ClassName = "ABS + Stretch",
                    Instructor = "David Hasslehoff",
                    ClassTime = TodayAt(9,30),
                },
                 //new ExerciseClass
                //{
                //    ClassName = "Body Sculpt",
                //    Instructor = "Sadie Terry",
                //    ClassTime = DateTime.Now.AddHours(3),
                //},
                 new ExerciseClass
                {
                    ClassName = "Cycle",
                    Instructor = "Lance Armstrong",
                    ClassTime = TodayAt(12,00),
                },
                 new ExerciseClass
                {
                    ClassName = "Aerobics",
                    Instructor = "Jacky Chan",
                    ClassTime = TodayAt(15,30),
                },
                 new ExerciseClass
                {
                    ClassName = "Weights",
                    Instructor = "Arnold Schwarzenegger",
                    ClassTime = TodayAt(18,00),
                    IsLast = true
                },
            };
        }
    }
}
