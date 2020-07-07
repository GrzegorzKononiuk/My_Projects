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
        public string GameTitle { get; set; }
        public BitmapImage Cover { get; set; }
    }
}
