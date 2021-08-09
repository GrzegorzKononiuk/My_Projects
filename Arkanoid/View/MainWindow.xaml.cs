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
        Random random = new Random();
        
        public MainWindow()
        {
            InitializeComponent();

            _viewModel = new ArkanoidViewModel();
            list.ItemsSource = _viewModel.blockItems;
            arrowsCount.DataContext = _viewModel;
            myLifes.DataContext = _viewModel;
       
            theTimer = new DispatcherTimer();
            theTimer.Interval = TimeSpan.FromMilliseconds(40);
            theTimer.IsEnabled = true;
            theTimer.Tick += dispatcherTimer_Tick;
            theTimer.Start();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            updateBall();
        }
        double velX = -14, velY = 22;
        private void updateBall()
        {

            double nextX = Canvas.GetLeft(ball) + velX;

            Canvas.SetLeft(ball, nextX);

            if (nextX + ball.ActualWidth > playArea.ActualWidth && velX > 0)
            {
                velX = -velX;
            }
            if (nextX + ball.ActualWidth < 1)
            {
                velX = +34;
            }

            double nextY = Canvas.GetBottom(ball) + velY;

            Canvas.SetBottom(ball, nextY);
            if (nextY == 0 || nextY + ball.ActualHeight > playArea.ActualHeight && velY > 0)
            {
                velY = -velY;
            }

            if (nextY + ball.ActualHeight < downWall.ActualHeight)
            {
                MessageBoxResult result =
                    MessageBox.Show("Again ?", "Ups", MessageBoxButton.YesNo);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        Canvas.SetLeft(ball, 165);
                        Canvas.SetBottom(ball, 60);
                        int LifeCount = _viewModel.LifeNumber--;

                        myElipse1.Fill = new SolidColorBrush(Colors.Black);
                        enemy.Fill = new SolidColorBrush(Colors.Yellow);
                        enemy2.Fill = new SolidColorBrush(Colors.Yellow);
                        enemy3.Fill = new SolidColorBrush(Colors.Yellow);
                        enemy4.Fill = new SolidColorBrush(Colors.Yellow);
                        if (LifeCount == 1)
                        {
                            myElipse2.Fill = new SolidColorBrush(Colors.Black);
                        }

                        if (LifeCount == 0)
                        {
                            myElipse1.Fill = new SolidColorBrush(Colors.Yellow);
                            myElipse2.Fill = new SolidColorBrush(Colors.Yellow);
                            _viewModel.LifeNumber = 2;
                        }
                        break;

                    case MessageBoxResult.No:
                        MessageBox.Show("Bye Bye !", "Arkanoid");
                        Application.Current.Shutdown();
                        break;

                }
                //velX = random.Next(-5, 10);
                //velY = 22;
            }
            WallColision();
            CheckBallColision();
        }
        public void WallColision()
        {
            foreach (var x in playArea.Children.OfType<Rectangle>())
            {
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
                else if ((string)x.Tag == "ball")
                {
                    x.Stroke = Brushes.Black;

                    Rect plankHitBox = new Rect(Canvas.GetLeft(plank), Canvas.GetBottom(plank), plank.Width, plank.Height);
                    Rect ballHit = new Rect(Canvas.GetLeft(x), Canvas.GetBottom(x), x.Width, x.Height);

                    if (plankHitBox.IntersectsWith(ballHit))
                    {

                        velY = -velY;
                    }
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
            foreach (var x in playArea.Children.OfType<Rectangle>())
            {

                if ((string)x.Tag == "enemy")
                {

                    Rect ballHitBox = new Rect(Canvas.GetLeft(ball), Canvas.GetBottom(ball), ball.Width, ball.Height);
                    Rect enemyHitBox = new Rect(Canvas.GetLeft(x), Canvas.GetBottom(x), x.Width, x.Height);


                    if (ballHitBox.IntersectsWith(enemyHitBox))
                    {
                        if (velY + ball.ActualHeight > list.ActualHeight && velY > 0)
                        {



                            enemy.Fill = new SolidColorBrush(Colors.White);
                            velY = -velY;

                        }
                    }



                }
                if ((string)x.Tag == "enemy2")
                {

                    Rect ballHitBox = new Rect(Canvas.GetLeft(ball), Canvas.GetBottom(ball), ball.Width, ball.Height);
                    Rect enemyHitBox = new Rect(Canvas.GetLeft(x), Canvas.GetBottom(x), x.Width, x.Height);


                    if (ballHitBox.IntersectsWith(enemyHitBox))
                    {
                        if (velY + ball.ActualHeight > enemy2.ActualHeight && velY > 0)
                        {



                            enemy2.Fill = new SolidColorBrush(Colors.White);
                            velY = -velY;

                        }
                    }



                }
                if ((string)x.Tag == "enemy3")
                {

                    Rect ballHitBox = new Rect(Canvas.GetLeft(ball), Canvas.GetBottom(ball), ball.Width, ball.Height);
                    Rect enemyHitBox = new Rect(Canvas.GetLeft(x), Canvas.GetBottom(x), x.Width, x.Height);


                    if (ballHitBox.IntersectsWith(enemyHitBox))
                    {
                        if (velY + ball.ActualHeight > enemy3.ActualHeight && velY > 0)
                        {



                            enemy3.Fill = new SolidColorBrush(Colors.White);
                            velY = -velY;

                        }
                    }



                }
                if ((string)x.Tag == "enemy4")
                {

                    Rect ballHitBox = new Rect(Canvas.GetLeft(ball), Canvas.GetBottom(ball), ball.Width, ball.Height);
                    Rect enemyHitBox = new Rect(Canvas.GetLeft(x), Canvas.GetBottom(x), x.Width, x.Height);


                    if (ballHitBox.IntersectsWith(enemyHitBox))
                    {
                        if (velY + ball.ActualHeight > enemy4.ActualHeight && velY > 0)
                        {



                            enemy4.Fill = new SolidColorBrush(Colors.White);
                            velY = -velY;

                        }
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
