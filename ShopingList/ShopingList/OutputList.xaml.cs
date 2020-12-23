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
            

            return mytextLabel.Text += items.ToString();

        }
       
    }
}