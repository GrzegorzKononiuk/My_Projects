using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
namespace MyGamesLibrary
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Platform { get; set; }
        public int Price { get; set; }
        public int HoursPlayed { get; set; }
        public BitmapImage Cover { get; set; }
    }
}
