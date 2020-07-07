using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
namespace MyGamesLibrary
{
    // NIE GAME QUERY TYLKO TYTAJ WLASCIWOSCI TYPU LESS < 50 H , MORE THAN > 50 H,
    // CENA GRY PLATFOERMA , TYLKO JEDNA WLASCIOWSC MA BYC CZEGO DOTYCZY TO POLE
    class Queries
    {
        public string Name { get; private set; }
        public BitmapImage Image { get; private set; }

        public Queries(string name,BitmapImage image)
        {
            Name = name;
            Image = image;
        }
    }
}
