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
                case "Played > 50h": HoursPlayed(); break;
                
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
                    Name = "Watch Dogs",
                    HoursPlayed= 122,
                    Platfrom = "Uplay",
                    Cost = 11,
                    //Image = CreateImage("dot.png"),
                }
            };
           
        }

        
        private static Dictionary<int, decimal> GetPrice()
        {
            return new Dictionary<int, decimal>
            {
                {1, 43M}, {2, 83M}, {3, 63M}
            };
           
        }

        //private void ExpensiveComics()
        public void HoursPlayed()
        {
            IEnumerable <Game> games = BuildCatalog();
            Dictionary<int, decimal> values = GetPrice();

            var mostPlayed = from game in games
                                where values[game.Id] < 78
                                orderby values[game.Id] descending
                                select game;

            CurrentQuery.Clear();
            foreach (Game game in mostPlayed)
                CurrentQuery.Add(
                    new
                    {
                        Title = String.Format("{0} Time Spend in Game: " + game.HoursPlayed,
                                                      game.Name, values[game.Id])
                        //PODOAWAC JESZCZE PARE GIER ZEBY ROZNICE WYCHWYCIC CYZDOBRZE DZIALA
                        //TIME SPEND IN GAME ITD MA BYC W TRZECIEJ KOLUMNIE
                        //PAMIETJA ZE ROBISZ TERAZ  QUERY "PLAYED > 50H"
                    }

               );
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
