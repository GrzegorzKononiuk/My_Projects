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

        public ObservableCollection<object> CurrentGameDetails { get; private set; }


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
        
        //STWORZYC UPDATE GAME DETAILS RESULTS

        public void UpdateQueryResults(SortType sortType)
        {
            Title = sortType.Title;

            switch (Title)
            {
                case "Show all Games": ShowAllGames(); break;
            }
        }
        
        public IEnumerable<Game> BuildCatalog()
        {
            return new List<Game>
            {
                new Game()
                {
                    Name = "Dishonored",
                    HoursPlayed = 22,
                    Platfrom = "Steam",
                    Cost = 33,
                    Image = CreateImage("dot.png"),
                }
            };
           
        }
        

        public void ShowAllGames()
        {
          foreach(Game game in BuildCatalog())
          {
                var result = new
                {
                    Title = game.Name,
                    
                   
                };
                CurrentQuery.Add(result);
          }
        }

        public void ShowGameDetails()
        {
            foreach (Game game in BuildCatalog())
            {
                var result = new
                {
                    Hours = game.HoursPlayed,
                    DigitalPlatform = game.Platfrom,
                    Price = game.Cost


                };
                CurrentGameDetails.Add(result);
            }
        }

      
    }
}
