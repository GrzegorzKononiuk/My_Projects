using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections;

namespace ShopingList
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GroceriesPage : ContentPage
    {
        ArrayList arrayList = new ArrayList();
        OutputList outputList { get; set; }
        ICountItems countItems = new CountItems();
        public string FileName { get; set; }
        public GroceriesPage()
        {
            InitializeComponent();
           
        }
       
        protected override void OnAppearing()
        {
            //base.OnAppearing();

            var notes = new List<Groceries>();

            var files = Directory.EnumerateFiles(App.FolderPath, "*.notes.txt");
            foreach (var filename in files)
            {
                Path.GetFileName(filename);
                FileName = filename;

                notes.Add(new Groceries()
                {
                    Filename = filename,
                    Text = File.ReadAllText(filename),

                });
                arrayList.Add(filename);

            }
            countItems.CreateList(arrayList);
            myLabel.Text = countItems.Get;
            arrayList.Clear();
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

       

        string Filename { get; set; }

        private void Save_List_Click(object sender, EventArgs e)
        {
            var filename = Path.Combine(App.FolderPath, $"{"Lista.txt"}");
            Filename = filename;
            using (var tw = new StreamWriter(filename))
            {
                foreach (Groceries groceries in listView.ItemsSource)
                {
                    tw.WriteLine(groceries.Text);
                }
            }
        }


        private void View_List_Click(object sender, EventArgs e)
        {
            outputList = new OutputList();
            string x = "";
            try
            {
                using (StreamReader sr = new StreamReader(Filename))
                {

                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {

                        x = outputList.Lista(line + "\n");
                    }
                    Navigation.PushAsync(new OutputList
                    {
                        BindingContext = new OutputList(x)
                    });
                }
            }
            catch (Exception c)
            {
                DisplayAlert("WARNING", string.Format("Click Save List first", c), "OK");
            }
        }
    }
}