using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows;
namespace MyGamesLibrary
{
    class SortType
    {

        public string Title { get; set; }
        public BitmapImage Image { get; set; }
        
        public SortType(string title, BitmapImage image)
        {
            Title = title;
            Image = image;
        }

        
    }
}
