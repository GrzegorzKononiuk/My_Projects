using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGamesLibrary
{
    class GameQueryManager
    {
        public static IEnumerable<Game> BuildCatalog()
        {
            return new List<Game>
            {
                new Game { Name = "Johnny America vs. the Pinko" }
            };


        }
    }
}
