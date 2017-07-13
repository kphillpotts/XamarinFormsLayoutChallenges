using Formula1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1.Data
{
    public static class DataRepository
    {
        public static IList<Driver> Drivers { get; }

        static DataRepository()
        {
            Drivers = new ObservableCollection<Driver>
            {
                new Driver
                {
                    Name = "Sebastian Vettel",
                    Team = "Ferrari",
                    Country = "Germany",
                    Points = 171
                },
                new Driver
                {
                    Name = "Lewis Hamilton",
                    Team = "Mercedes",
                    Country = "United Kingdom",
                    Points = 151
                },
                new Driver
                {
                    Name = "Valtteri Bottas",
                    Team = "Mercedes",
                    Country = "Finland",
                    Points = 160
                },
            };
        }
    }
}
