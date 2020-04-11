using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Globalization;
using Newtonsoft.Json.Linq;
using Android.Support.V7.App;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Content.Res;
using Xamarin.Forms;

namespace CheckWeather
{
    [Activity(Label = "BstokRadar",  NoHistory = true)]
    public class BstokRadar : Activity
    {
        TextView bstokTextView;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.bstokradar);

            bstokTextView = (TextView)FindViewById(Resource.Id.bstokText);
            
            string city = "http://antistorm.eu/webservice.php?id=10";
            GetBstokOnRadar(city);


        }
        
        async void GetBstokOnRadar(string place)
        {
            var handler = new HttpClientHandler();
            HttpClient client = new HttpClient(handler);
            string result = await client.GetStringAsync(place);

            
            var resultObject = JObject.Parse(result);
            string cityName = resultObject["m"].ToString();
            string stormChance = resultObject["p_b"].ToString();
            string timeToStorm = resultObject["t_b"].ToString();
            
            //TE STRINGI LADNIE W XMLU ZROBIC ZEBY WYSWIETLALO
            //DLA KAZDEGO ZROBIC ODZIELNIE TEXT VIEW I ID 
            bstokTextView.Text = cityName+ stormChance + timeToStorm;
        }
    
       
    }
}