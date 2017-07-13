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

        public static Driver MockDriver { get
            {
                return Drivers[0];
            }
        }

        static DataRepository()
        {
            Drivers = new ObservableCollection<Driver>
            {
                new Driver
                {
                    Name = "Sebastian Vettel",
                    Team = "Ferrari",
                    Country = "Germany",
                    Points = 171,
                    Podiums = 0,
                    GrandPrixEnetered = 0,
                    WorldChampionships = 4,
                    HighestRaceFinish = "1 (x45)",
                    HighestGridPosition = 1,
                    DateOfBirth = new DateTime(1987,7,3),
                    PlaceOfBirth = "Heppenheim, Germany",
                    Bio="A tour de force as he swept to four straight world championship crowns and countless Formula One records, Sebastian Vettel’s relentless hunger for victory, as much as his outstanding talent, secure his place as one of the sport’s greats."

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
