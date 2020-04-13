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
        Android.Widget.Button getWeatherButton;
        Android.Widget.Button getWeatherInBstok;
        Android.Widget.Button getDateButton;
        TextView placeTextView;
        TextView temperatureTextView;
        TextView weatherDescriptionTextView;
        EditText cityNameEditText;
        ImageView weatherImageView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
           
            //EDIT TEXT CONTROL
            cityNameEditText = (EditText)FindViewById(Resource.Id.cityNameText);
            
            //TEXT VIEW CONTROLS
            placeTextView = (TextView)FindViewById(Resource.Id.placeText);
            temperatureTextView = (TextView)FindViewById(Resource.Id.temperatureTextView);
            weatherDescriptionTextView = (TextView)FindViewById(Resource.Id.weatherDescriptionText);
            
            //IMAGEVIEW CONTROL
            weatherImageView = (ImageView)FindViewById(Resource.Id.thermometerImage);
            
            //BUTTONS CONTROLS
            getWeatherButton = (Android.Widget.Button)FindViewById(Resource.Id.getWeatherButton);
            getWeatherInBstok = (Android.Widget.Button)FindViewById(Resource.Id.bstokButton);
            getDateButton = (Android.Widget.Button)FindViewById(Resource.Id.getDate);
            
            getWeatherButton.Click += GetWeatherButton_Click;
            getWeatherInBstok.Click += GetWeatherInBstok_Click;
            getDateButton.Click += GetDateButton_Click; ;

        }

        private void GetDateButton_Click(object sender, EventArgs e)
        {
            
        }

        private void GetWeatherButton_Click(object sender, System.EventArgs e)
        {
            string place = cityNameEditText.Text;
            //GetWeather(place);
        }
        /**
        async void GetWeather(string place)
        {
            string apiKey = "89b85d41729fb2edeee0f26e543c5bb4";
            string apiBase = "https://api.openweathermap.org/data/2.5/weather?q=";
            string unit = "metric";
            
            if(string.IsNullOrEmpty(place))
            {
                Toast.MakeText(this, "Wprowadz nazwe miasta", ToastLength.Short).Show();
            }

            string url = apiBase + place + "&appid=" + apiKey + "&units=" + unit;

            var handler = new HttpClientHandler();
            HttpClient client = new HttpClient(handler);
            string result = await client.GetStringAsync(url);

            Console.WriteLine(result);

            var resultObject = JObject.Parse(result);
            string weatherDescription = resultObject["weather"][0]["description"].ToString();
            string icon = resultObject["weather"][0]["icon"].ToString();
            string temperature = resultObject["main"][0]["temp"].ToString();
            string placename = resultObject["name"].ToString();
            string country = resultObject["sys"]["country"].ToString();
            
            weatherDescription = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(weatherDescription);

            weatherDescriptionTextView.Text = weatherDescription;
            placeTextView.Text = placename + ", " + country;
            temperatureTextView.Text = temperature;
        }
        **/
        private void GetWeatherInBstok_Click(object sender, EventArgs e)
        {
            /// WHBY DONT WORK ???!!!!

            Intent intent = new Intent(this, typeof(BstokRadar));
            StartActivity(intent);

           
        }

    }
}