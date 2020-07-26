using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
namespace MyGamesLibrary
{
    class Game
    {
        public string Name { get; set; }
        public int HoursPlayed { get; set; }
        public string Platfrom { get; set; }
        public int Cost { get; set; }
        public BitmapImage Image { get; set; }

    }
}
