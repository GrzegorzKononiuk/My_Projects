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
        public PassingNumber passingNumber{ get; set; }
        public GroceriesPage()
        {
            InitializeComponent();
            passingNumber = new PassingNumber();
            BindingContext = passingNumber;
        }
       
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
                    Date = File.GetCreationTime(filename),
                    Number = passingNumber.MyProperty

                });
            }
            listView.ItemsSource = notes
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

        async private void checkBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            var result = await DisplayPromptAsync("Question 2", "What's 5 + 5?", initialValue: "10", maxLength: 2, keyboard: Keyboard.Numeric);
            int number = Int32.Parse(result);
            GetNumber getNumber = new GetNumber(passingNumber.NumberOfProduct);
            getNumber(number);
            OnAppearing();
        }

        string Filename { get; set; }

        private void Save_List_Click(object sender, EventArgs e)
        {
            var filename = Path.Combine(App.FolderPath, $"{"Lista.txt"}");
            Filename = filename;
            using (var tw = new StreamWriter(filename))
            {
                foreach (Groceries groceries in listView.ItemsSource)
                {
                    tw.WriteLine(groceries.Text + groceries.Number);
                }
            }
        }

        private void Open_List_Click(object sender, EventArgs e)
        {
            string line = "";
            using (StreamReader sr = new StreamReader(Filename))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}