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
using System.Windows.Threading;

namespace Arkanoid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ArkanoidViewModel _viewModel;
        DispatcherTimer theTimer;
        
        public MainWindow()
        {
            InitializeComponent();
            
            _viewModel = new ArkanoidViewModel();
            myLabel.DataContext = _viewModel;
            WallColision();
            theTimer = new DispatcherTimer();
            theTimer.Interval = TimeSpan.FromMilliseconds(80);
            theTimer.IsEnabled = true;
            theTimer.Tick += dispatcherTimer_Tick;
            theTimer.Start();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            updateBall();
        }
        double velX = 34, velY = 22;
        private void updateBall()
        {

            double nextX = Canvas.GetLeft(ball) + velX;

            Canvas.SetLeft(ball, nextX);

            if (nextX == 0 || nextX + ball.ActualWidth > playArea.ActualWidth && velX > 0)
            {
                velX = -velX;
            }

            double nextY = Canvas.GetBottom(ball) + velY;

            Canvas.SetBottom(ball, nextY);
            if (nextY == 0 || nextY + ball.ActualHeight > playArea.ActualHeight && velY > 0)
            {
                velY = -velY;
            }
            CheckBallColision();
        }
        public void WallColision()
        {
            foreach (var x in playArea.Children.OfType<Rectangle>())
                if ((string)x.Tag == "leftWall")
                {
                    x.Stroke = Brushes.Black;

                    Rect plankHitBox = new Rect(Canvas.GetLeft(plank), Canvas.GetBottom(plank), plank.Width, plank.Height);
                    Rect platformHitBox = new Rect(Canvas.GetLeft(x), Canvas.GetBottom(x), 0, x.Height);

                    if (plankHitBox.IntersectsWith(platformHitBox))
                    {
                        Canvas.SetLeft(plank, 0);

                    }
                }
                else if ((string)x.Tag == "rightWall")
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
                WallColision();
                _viewModel.Number++;
            }
            else if (e.Key == Key.Right)
            {
                Canvas.SetLeft(plank, Canvas.GetLeft(plank) + _viewModel.Move(2));
                WallColision();
                _viewModel.Number++;
            }
        }
        public void CheckBallColision()
        {

            //KMINIC JA KTO PRZEPUSIC PRZEZ PETLE FOR ZEBNY ADD MOZNA BNYLO ZROBIC
            // PACZ LINKI

        

            //NAJPIERW MUSI BYC ADD ZEBY MOZNA BYLO ZROBIC REMOVE !!
            foreach (var x in playArea.Children.OfType<Rectangle>())

                if ((string)x.Tag == "enemy")
                {

                    Rect ballHitBox = new Rect(Canvas.GetLeft(ball), Canvas.GetBottom(ball), ball.Width, ball.Height);
                    Rect enemyHitBox = new Rect(Canvas.GetLeft(x), Canvas.GetBottom(x), x.Width, x.Height);

                    if (ballHitBox.IntersectsWith(enemyHitBox))
                    {
                        if (velY + ball.ActualHeight > enemy.ActualHeight && velY > 0)
                        {

                            velY = -velY;

                        }
                


                    }
                }


        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.SaveData();
        }
    }
}
