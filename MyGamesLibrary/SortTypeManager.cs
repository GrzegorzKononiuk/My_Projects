﻿using System;
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
                case "Played < 50h": HoursPlayedLessThan50(); break;
                case "Played > 50h": HoursPlayedMoreThan50(); break;
                case "Platfrom": SortByPlatform(); break;
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
                    Cover = CreateImage("Dishonored.png"),
                },

                 new Game
                {
                    Id = 2,
                    Name = "Chidren of Mortia",
                    HoursPlayed= 76,
                    Platfrom = "Gog",
                    Cost = 41,
                    Cover = CreateImage("children.png"),
                },
                   new Game
                {
                    Id = 3,
                    Name = "Pathologic",
                    HoursPlayed= 55,
                    Platfrom = "Gog",
                    Cost = 47,
                     Cover = CreateImage("Pathologic.png"),
                },
                    new Game
                {
                    Id = 4,
                    Name = "Gothic",
                    HoursPlayed= 45,
                    Platfrom = "Gog",
                    Cost = 41,
                     Cover = CreateImage("gothic.png"),
                },
                   new Game
                {
                    Id = 5,
                    Name = "BioShock",
                    HoursPlayed= 56,
                    Platfrom = "Gog",
                    Cost = 91,
                    Cover = CreateImage("BioShock.png"),
                },
                   /**
                   new Game
                {
                    Id = 6,
                    Name = "Lord of The Rings",
                    HoursPlayed= 72,
                    Platfrom = "Steam",
                    Cost = 22,
                    //Cover = CreateImage("rings.png"),
                }
                   **/

        };
           
        }
        
        public void ShowAllGames()
        {
            foreach (Game game in BuildCatalog())
            {
                var result = new
                {
                    
                    Image = game.Cover

                };
                CurrentQuery.Add(result);
            }
        }
        
        private void HoursPlayedLessThan50()
        {
            IEnumerable<Game> games = BuildCatalog();
            Dictionary<int, Game> dictionary = games.ToDictionary(p => p.Id);

            var sortedGames = from s in dictionary
                              orderby s.Value.HoursPlayed
                              where s.Value.HoursPlayed < 50
                              select new Game
                              {

                                  Name = s.Value.Name,
                                  Cover = s.Value.Cover,
                                  HoursPlayed = s.Value.HoursPlayed
                              };

            foreach (Game game in sortedGames)
            {
                CurrentQuery.Add
                    (
                        new
                        {
                            Title = String.Format("Game Name: {0},", game.Name),
                            Image = game.Cover,
                            Hours = String.Format("Hours Spend in Game: {0},", game.HoursPlayed),
                        }
                    );
            }
        }
        

        private void HoursPlayedMoreThan50()
        {
           
            IEnumerable<Game> games = BuildCatalog();
            Dictionary<int, Game> dictionary = games.ToDictionary(p => p.Id);
           
            var sortedGames = from s in dictionary
                                 orderby s.Value.HoursPlayed
                                 where s.Value.HoursPlayed > 50
                                 select new Game
                                 {
                                    
                                     Name = s.Value.Name,
                                     Cover = s.Value.Cover,
                                     HoursPlayed = s.Value.HoursPlayed
                                 };

            foreach(Game game in sortedGames)
            {
                CurrentQuery.Add
                    (
                        new
                        {
                            Title = String.Format("Game Name: {0},", game.Name),
                            Image = game.Cover,
                            Hours = String.Format("Hours Spend in Game: {0},", game.HoursPlayed),
                        }
                    );
            }
        }
        
        private void SortByPlatform()
        {
            IEnumerable<Game> games = BuildCatalog();

            // CO BY BYLO GDYBYM W KLASIE GAME MIAL public string NAMEOFIMAGES {getl; set}
            

            var sortPlatform = from s in games
                               orderby s.Platfrom, s.Cost
                               where s.Platfrom.Contains(s.Platfrom)
                               select new Game
                               {
                                   
                                   Platfrom = s.Platfrom
                                   
                               };

            
            foreach (Game game in sortPlatform)
            {
                CurrentQuery.Add
                    (
                        new
                        {
                           
                            //Image = CreateImage(imageName[1]),
                            Hours = String.Format("Platform: {0},", game.Platfrom),
                            
                        }
                    );
            }

        }


    }
}
