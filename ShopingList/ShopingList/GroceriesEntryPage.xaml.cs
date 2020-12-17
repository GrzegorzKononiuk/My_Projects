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
    public partial class GroceriesEntryPage : ContentPage
    {
        PassingNumber passingNumber { get; set; }
        public GroceriesEntryPage()
        {
            InitializeComponent();
            passingNumber = new PassingNumber();
            BindingContext = passingNumber;
        }
                               
        async private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var note = (Groceries)BindingContext;

            if (string.IsNullOrWhiteSpace(note.Filename))
            {
                // Save
                var filename = Path.Combine(App.FolderPath, $"{Path.GetRandomFileName()}.notes.txt");
                File.WriteAllText(filename, note.Text);

                try
                {
                    //Add number throught delegate
                    var result = await DisplayPromptAsync("How many?", "Number of Item", initialValue: "1", maxLength: 2, keyboard: Keyboard.Numeric);
                    if (result == null)
                    {
                        throw new ArgumentNullException();
                    }
                    int number = Int32.Parse(result);
                    GetNumber getNumber = new GetNumber(passingNumber.NumberOfProduct);
                    getNumber(number);
                }
                catch (Exception c)
                {
                    await DisplayAlert("WARNING", string.Format("U dont write how many", c), "Cancel");

                }

                using (StreamWriter sw = File.AppendText(filename))
                {
                    sw.WriteLine(passingNumber.MyProperty);
                }
            }
            else
            {
                // Update
                File.WriteAllText(note.Filename, note.Text);
            }

            await Navigation.PopAsync();
        }

        async private void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var note = (Groceries)BindingContext;

            if (File.Exists(note.Filename))
            {
                File.Delete(note.Filename);
            }

            await Navigation.PopAsync();
        }
    }
}