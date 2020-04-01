using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Net.Http;

namespace CheckWeather
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button getWeatherButton;
        TextView placeTextView;
        TextView temperatureTextView;
        TextView weatherDescriptionTextView;
        EditText cityNameEditText;
        ImageView weatherImageView;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
           
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            cityNameEditText = (EditText)FindViewById(Resource.Id.cityNameText);
            placeTextView = (EditText)FindViewById(Resource.Id.placeText);
            temperatureTextView = (EditText)FindViewById(Resource.Id.temperatureTextView);
            weatherDescriptionTextView = (EditText)FindViewById(Resource.Id.weatherDescriptionText);
            weatherImageView = (ImageView)FindViewById(Resource.Id.thermometerImage);
            getWeatherButton = (Button)FindViewById(Resource.Id.getWeatherButton);

            getWeatherButton.Click += GetWeatherButton_Click;
        }

        private void GetWeatherButton_Click(object sender, System.EventArgs e)
        {
            string place = cityNameEditText.Text;
        }

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

        }
    }
}