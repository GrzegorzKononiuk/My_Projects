using Arkanoid.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Arkanoid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ArkanoidViewModel _viewModel;
        
        public MainWindow()
        {
            InitializeComponent();
            
            _viewModel = new ArkanoidViewModel();
            myLabel.DataContext = _viewModel;
        }
        
        public void CheckColision()
        {
            foreach (var x in myCanvas.Children.OfType<Rectangle>())
                if ((string)x.Tag == "wall")
                {
                    x.Stroke = Brushes.Black;

                    Rect plankHitBox = new Rect(Canvas.GetLeft(plank), Canvas.GetBottom(plank), plank.Width, plank.Height);
                    Rect platformHitBox = new Rect(Canvas.GetLeft(x), Canvas.GetBottom(x), 0, x.Height);

                    if (plankHitBox.IntersectsWith(platformHitBox))
                    {
                        Canvas.SetLeft(plank, 0);

                    }
                }
                else if ((string)x.Tag == "wall1")
                {
                    x.Stroke = Brushes.Black;

                    Rect plankHitBox = new Rect(Canvas.GetLeft(plank), Canvas.GetBottom(plank), plank.Width, plank.Height);
                    Rect platformHitBox = new Rect(Canvas.GetLeft(x), Canvas.GetBottom(x), 0, x.Height);

                    if (plankHitBox.IntersectsWith(platformHitBox))
                    {
                        Canvas.SetLeft(plank, 290);

                    }
                }

        }
        
        private void Canvas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                Canvas.SetLeft(plank, Canvas.GetLeft(plank) - _viewModel.Move(1));
                CheckColision();
                _viewModel.Number++;
            }
            else if (e.Key == Key.Right)
            {
                Canvas.SetLeft(plank, Canvas.GetLeft(plank) + _viewModel.Move(2));
                CheckColision();
                _viewModel.Number++;
            }
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.SaveData();
        }
    }
}
