using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

using System.Windows.Controls;
using System.Windows.Data;
using System.Globalization;

namespace Arkanoid.ViewModel
{
  
    class ArkanoidViewModel : IValueConverter
    {
        public string DisplayedImage
        {
            get { return @"pack://application:,,,/images/plank.png"; }
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return new BitmapImage(new Uri(DisplayedImage));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
        /**
        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Left:

                    //1  // WSTAW IMG PLANK.PNG

                  //2  //TUTAJ POTRZEBUJE LOGIKE DZIALANIA CZYT LOCATION.X - PIXELSPERMOVE ITD
                    //TO WSZYSTKO POPRZEZ REFERENCJE DO private Plank _plank;
                    break;
                case Direction.Right:
                   
                    break;
                default: break;
            }
        }
        **/
    }
}
