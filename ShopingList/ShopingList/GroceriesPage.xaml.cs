﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShopingList
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GroceriesPage : ContentPage
    {
        OutputList outputList { get; set; }
        PassingNumber passingNumber{ get; set; }
        public string FileName { get; set; }
        public GroceriesPage()
        {
            InitializeComponent();
            passingNumber = new PassingNumber();
            BindingContext = passingNumber;
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
            
            using (StreamWriter sw = File.AppendText(FileName))
            {
                sw.WriteLine(passingNumber.MyProperty);
            }
            
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
                    tw.WriteLine(groceries.Text);
                }
            }
        }


        private void View_List_Click(object sender, EventArgs e)
        {
            outputList = new OutputList();
            string x = "";
            using (StreamReader sr = new StreamReader(Filename))
            {
                //ODCZYTAC NUMBER 
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
    }
}