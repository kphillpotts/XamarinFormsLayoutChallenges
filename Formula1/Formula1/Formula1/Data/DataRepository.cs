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
                    Name = "Daniel Ricciardo",
                    Team = "Red Bull Racing",
                    Country = "Australia",
                    Points = 107
                },
                new Driver
                {
                    Name = "Kimi Raikkonen",
                    Team = "Ferrari",
                    Country = "Finland",
                    Points = 83
                },
                new Driver
                {
                    Name = "Sergio Perez",
                    Team = "Force India",
                    Country = "Mexico",
                    Points = 45
                },
                new Driver
                {
                    Name = "Max Verstappen",
                    Team = "Red Bull Racing",
                    Country = "Netherlands",
                    Points = 45
                },
                new Driver
                {
                    Name = "Esteban Ocon",
                    Team = "Force India",
                    Country = "France",
                    Points = 39
                },
                new Driver
                {
                    Name = "Carlos Sainz",
                    Team = "Toro Rosso",
                    Country = "Spain",
                    Points = 29
                },
                new Driver
                {
                    Name = "Felipe Massa",
                    Team = "Williams",
                    Country = "Brazil",
                    Points = 22
                },
            };
        }
    }
}
