using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace MyGamesLibrary
{
    class SortTypeManager
    {
        
        public ObservableCollection<SortType> SortQueries { get; private set; }
        
        public ObservableCollection<object> CurrentQuery { get; private set; }

        public string Title { get; set; }
        public int Hours { get; set; }
        public string DigitalPlatform { get; set; }
        public int Price { get; set; }
       
        public SortTypeManager()
        {
            ShowQueries();
            CurrentQuery = new ObservableCollection<object>();
        
            
        }

        private void ShowQueries()
        {
            SortQueries = new ObservableCollection<SortType>
            {
                new SortType("Show all Games", CreateImage("dot.png")),
                new SortType("Played < 50h", CreateImage("dot_b.png")),
                new SortType("Played > 50h", CreateImage("dot_g.png")),
                new SortType("Platfrom", CreateImage("dot_bl.png")),
                new SortType("Price < 20zl", CreateImage("dot_r.png")),
                new SortType("Price > 20zl", CreateImage("dot_o.png")),
            };
        }
        
        public BitmapImage CreateImage(string imageName)
        {
            var uri = new Uri(imageName, UriKind.RelativeOrAbsolute);
            return new BitmapImage(uri);

        }

      

        public void UpdateQueryResults(SortType sortType)
        {
            Title = sortType.Title;

            switch (Title)
            {
                case "Show all Games": ShowAllGames(); break;
                case "Played > 50h": HoursPlayedSorting(); break;
                
            }
        }


        public IEnumerable<Game> BuildCatalog()
        {
            return new List<Game>
            {
                new Game
                {
                    Id = 1,
                    Name = "Dishonored",
                    HoursPlayed= 22,
                    Platfrom = "Steam",
                    Cost = 33,
                    //Image = CreateImage("dot.png"),
                },

                 new Game
                {
                    Id = 2,
                    Name = "Chidren of Mortia",
                    HoursPlayed= 76,
                    Platfrom = "Gog",
                    Cost = 41,
                    //Image = CreateImage("dot.png"),
                },
                   new Game
                {
                    Id = 3,
                    Name = "Gothic",
                    HoursPlayed= 55,
                    Platfrom = "Gog",
                    Cost = 47,
                    //Image = CreateImage("dot.png"),
                },
                    new Game
                {
                    Id = 4,
                    Name = "Gothic",
                    HoursPlayed= 45,
                    Platfrom = "Gog",
                    Cost = 47,
                    //Image = CreateImage("dot.png"),
                },
                   new Game
                {
                    Id = 5,
                    Name = "BioShock",
                    HoursPlayed= 56,
                    Platfrom = "Gog",
                    Cost = 91,
                    //Image = CreateImage("dot.png"),
                },
                   new Game
                {
                    Id = 6,
                    Name = "Lord of The Rings",
                    HoursPlayed= 72,
                    Platfrom = "Steam",
                    Cost = 22,
                    //Image = CreateImage("dot.png"),
                }

        };
           
        }

        
        private void HoursPlayedSorting()
        {
           
            IEnumerable<Game> games = BuildCatalog();
            Dictionary<int, Game> dictionary = games.ToDictionary(p => p.Id);
           
            var sortedStudents = from s in dictionary
                                 orderby s.Value.HoursPlayed
                                 where s.Value.HoursPlayed > 50
                                 select new
                                 {
                                    
                                     Name = s.Value.Name,
                                     Hours = s.Value.HoursPlayed
                                 };

            sortedStudents.ToList().ForEach(s => Console.WriteLine("Game Name: {0}, Hours Spend in Game: {1}h,", s.Name, s.Hours));

        }

      
        public void ShowAllGames()
        {
          foreach(Game game in BuildCatalog())
          {
                var result = new
                {
                    Title = game.Name,
                    Hours = game.HoursPlayed,
                    DigitalPlatform = game.Platfrom,
                    Price = game.Cost


                };
                CurrentQuery.Add(result);
          }
        }

 

      
    }
}
