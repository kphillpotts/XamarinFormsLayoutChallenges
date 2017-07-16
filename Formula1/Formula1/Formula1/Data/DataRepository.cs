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
        public static IList<Race> Races { get;
        }
        public static Driver MockDriver { get
            {
                return Drivers[0];
            }
        }

        public static Race MockRace
        {
            get
            {
                return Races[0];
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

            Races = new ObservableCollection<Race>()
            {
                new Race
                {
                    Name="Australian Grand Prix",
                    Circuit="Melbourne",
                    CircuitLength=5.303,
                    RaceDistance=307.574,
                    NumberOfLaps=58,
                    Date = new DateTime(2017, 03, 26),
                    MapUrl = @"https://www.formula1.com/content/fom-website/en/championship/races/2017/Australia/_jcr_content/circuitMap.img.png/1458295855148.png"
                },
                new Race
                {
                    Name="Chinese Grand Prix",
                    Circuit="Shanghai International Circuit",
                    CircuitLength=5.451,
                    RaceDistance=305.066,
                    NumberOfLaps=56,
                    Date = new DateTime(2017, 04, 09)
                },
                new Race
                {
                    Name="Bahrain Grand Prix",
                    Circuit="Bahrain International Circuit",
                    CircuitLength=5.451,
                    RaceDistance=305.066,
                    NumberOfLaps=56,
                    Date = new DateTime(2017, 04, 16)
                },
                new Race
                {
                    Name="Russian Grand Prix",
                    Circuit="Sochi Autodrom",
                    CircuitLength=5.848,
                    RaceDistance=305.066,
                    NumberOfLaps=53,
                    Date = new DateTime(2017, 04, 30)
                },
                new Race
                {
                    Name="Premio De Espana",
                    Circuit="Circuit De Barcelona-Catalunya",
                    CircuitLength=4.655,
                    RaceDistance=307.104,
                    NumberOfLaps=66,
                    Date = new DateTime(2017, 05, 14)
                },
                new Race
                {
                    Name="Grand Prix De Monaco",
                    Circuit="Circuit De Monaco",
                    CircuitLength=3.337,
                    RaceDistance=260.286,
                    NumberOfLaps=78,
                    Date = new DateTime(2017, 05, 28)
                },
                new Race
                {
                    Name="Grand Prix Du Canada",
                    Circuit="Circuit Gilles-Villeneuve",
                    CircuitLength=361,
                    RaceDistance=305.27,
                    NumberOfLaps=70,
                    Date = new DateTime(2017, 06, 11),
                    IsLast=true
                },

            };
        }
    }
}
