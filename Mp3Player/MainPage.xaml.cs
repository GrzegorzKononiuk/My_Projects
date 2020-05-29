using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Composition;
using Windows.Media.Core;
using Windows.UI.Xaml.Media.Animation;
using Windows.Media.Playback;
using System.Numerics;
using Microsoft.UI.Xaml.Controls;
using System.Collections.ObjectModel;
using Windows.Graphics.Printing3D;

namespace Mp3Player
{
    
    public sealed partial class MainPage : Page
    {

    
        public MainPage()
        {
            this.InitializeComponent();
        }
        
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            await SetLocalMedia();
        }

        async private System.Threading.Tasks.Task SetLocalMedia()
        {
            var openPicker = new Windows.Storage.Pickers.FileOpenPicker();

            openPicker.FileTypeFilter.Add(".wmv");
            openPicker.FileTypeFilter.Add(".mp4");
            openPicker.FileTypeFilter.Add(".wma");
            openPicker.FileTypeFilter.Add(".mp3");

            var file = await openPicker.PickSingleFileAsync();


            if (file != null)
            {
                mediaPlayer.Source = MediaSource.CreateFromStorageFile(file);
                LoadedText.Text = file.Name;         
              
            }
        }
      
        private void CreateOrUpdateSpringAnimation(float finalValue)
        {
            if (_springAnimation == null)
            {
                _springAnimation = _compositor.CreateSpringVector3Animation();
                _springAnimation.Target = "Scale";
            }

            _springAnimation.FinalValue = new Vector3(finalValue);
        }
        Compositor _compositor = Window.Current.Compositor;
        SpringVector3NaturalMotionAnimation _springAnimation;
        private void Play_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.MediaPlayer.Play();
            Player.PlaybackRate = 1;
            EnsurePlaying();
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.MediaPlayer.Pause();
        }
        private void element_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            
            CreateOrUpdateSpringAnimation(1.5f);

            (sender as UIElement).StartAnimation(_springAnimation);
        }
        private void element_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            
            CreateOrUpdateSpringAnimation(1.0f);

            (sender as UIElement).StartAnimation(_springAnimation);
        }
     
        private void EnsurePlaying()
        {
            if (Stop.IsChecked.Value)
            {
                // Resume playing the animation, if paused.
                Stop.IsChecked = false;
            }
            else
            {
                if (!Player.IsPlaying)
                {
                    // Play the animation at the currently specified playback rate.
                    _ = Player.PlayAsync(fromProgress: 0, toProgress: 1, looped: false);
                }
            }
        }

        private void PauseButton_Checked(object sender, RoutedEventArgs e)
        {
            Player.Pause();
        }

        private void PauseButton_Unchecked(object sender, RoutedEventArgs e)
        {
            Player.Resume();
        }
    }
   
}
