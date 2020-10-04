using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShopingList
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GroceriesPage : ContentPage
    {
        public GroceriesPage()
        {
            InitializeComponent();
        }
                                    //<!-- DODAJ NOWY PRODUKT=
        protected override void OnAppearing()
        {
            base.OnAppearing();

            var notes = new List<Groceries>();

            var files = Directory.EnumerateFiles(App.FolderPath, "*.notes.txt");
            foreach (var filename in files)
            {
                notes.Add(new Groceries
                {
                    Filename = filename,
                    Text = File.ReadAllText(filename),
                    Date = File.GetCreationTime(filename)
                });
            }

            listView.ItemsSource = notes
                .OrderBy(d => d.Date)
                .ToList();
        }
        
        async private void OnNoteAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GroceriesEntryPage
            {
                BindingContext = new Groceries()
            });
        }

        async private void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new GroceriesEntryPage
                {
                    BindingContext = e.SelectedItem as Groceries
                });
            }
        }
    }
}