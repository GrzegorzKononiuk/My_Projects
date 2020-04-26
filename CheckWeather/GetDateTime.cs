using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Threading.Tasks;

namespace CheckWeather
{
    [Activity(Label = "GetDateTime")]
    public class GetDateTime : Activity
    {
        TextView countryTextView;
        TextView dateTimeTextView;
        protected override void OnCreate(Bundle savedInstanceState)
        {

           base.OnCreate(savedInstanceState);
           SetContentView(Resource.Layout.getdatetime);
           
           countryTextView = (TextView)FindViewById(Resource.Id.countryView);
           dateTimeTextView = (TextView)FindViewById(Resource.Id.dateTimeView);
            
            DateTime localDate = DateTime.Now;

            string[] cultureNames = { "pl-PL" };
            foreach (var cultureName in cultureNames)
            {
                var culture = new CultureInfo(cultureName);
                countryTextView.Text = string.Format(culture.NativeName);
                dateTimeTextView.Text = string.Format("Local date and time: ", localDate.ToString(culture));
            }
        }
    }
}