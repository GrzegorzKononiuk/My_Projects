using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;
namespace MyGamesLibrary
{
    class QueriesManager
    {
        public ObservableCollection<Queries> AvailableQueries { get; private set; }

        public QueriesManager()
        {
            UpdateAvailableQueries();
        }

        private void UpdateAvailableQueries()
        {
            AvailableQueries = new ObservableCollection<Queries> 
            {
                new Queries("List of all my games", CreateImage("dot.png"))
            };
        }

        private static BitmapImage CreateImage(string imageFilename)
        {
            try
            {
                Uri uri = new Uri(imageFilename, UriKind.RelativeOrAbsolute);
                return new BitmapImage(uri);
            }
            catch (System.IO.IOException)
            {
                return new BitmapImage();
            }
        }
    }
}
