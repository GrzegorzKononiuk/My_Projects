using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Net.Http;
using System;
using Newtonsoft.Json.Linq;
using System.Globalization;
using Android.Content.Res;
using Android.Content;
using Xamarin.Forms;

namespace CheckWeather
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true, NoHistory = true)]
    public class MainActivity : AppCompatActivity
    {
       
        Android.Widget.Button getWeatherInBstok;
        Android.Widget.Button getDateButton;
       
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
          
            getWeatherInBstok = (Android.Widget.Button)FindViewById(Resource.Id.bstokButton);
            getDateButton = (Android.Widget.Button)FindViewById(Resource.Id.getDate);
            
            getWeatherInBstok.Click += GetWeatherInBstok_Click;
            getDateButton.Click += GetDateButton_Click;
         }

        private void GetDateButton_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(GetDateTime));
            StartActivity(intent);
        }

        private void GetWeatherInBstok_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(BstokRadar));
            StartActivity(intent);
        }

    }
}