using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyGamesLibrary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SortTypeManager sortTypeManager;
        
        public MainWindow()
        {
            InitializeComponent();

            sortTypeManager = FindResource("sortTypeManager") as SortTypeManager;
            sortTypeManager.UpdateQueryResults(sortTypeManager.SortQueries[0]);
           
           
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count >= 1 && e.AddedItems[0] is SortType)
            {
                sortTypeManager.CurrentQuery.Clear();
                sortTypeManager.UpdateQueryResults(e.AddedItems[0] as SortType);
                
               
            }
        }


    }
}
