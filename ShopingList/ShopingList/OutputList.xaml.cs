using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShopingList
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OutputList : ContentPage
    {
        public OutputList()
        {
            InitializeComponent();
        }

        public string Line { get; set; }
        public string Filename { get; set; }

        public OutputList(string line)
        {
            Line = line;
        }
        
        public string Lista(string items)
        {
            //DOBRA PACZ NOTESPAGE.CS ON APPEWRING METODA 

            return mytextLabel.Text += items.ToString();

        }
        
        private void EditButtonClicked(object sender, EventArgs e)
        {

        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {

        }
    }
}