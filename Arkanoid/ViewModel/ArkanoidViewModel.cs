using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

using System.Windows.Controls;
using System.Windows.Data;
using System.Globalization;
using Arkanoid.Model;
using System.Collections.ObjectModel;

namespace Arkanoid.ViewModel
{
  
    public class ArkanoidViewModel : INotifyPropertyChanged
    {

        public ObservableCollection<RectangleItem> blockItems = new ObservableCollection<RectangleItem>()
        {
            
             //FROM TOP LEFT TO BOTTOM RIGHT
             new RectangleItem(){X = 0, Y = 0, Width = 80, Height = 120},
             new RectangleItem(){X = 80, Y= 75, Width = 80, Height = 120 },
             new RectangleItem(){X = 160, Y= 150, Width = 80, Height = 120 },
             new RectangleItem(){X = 240, Y= 225, Width = 80, Height = 120 },
             new RectangleItem(){X = 320, Y= 300, Width = 80, Height = 120 },

             //FROM TO RIGHT TO BOTTOM LEFT
             new RectangleItem(){X = 320, Y = 0, Width = 80, Height = 120},
             new RectangleItem(){X = 240, Y = 75, Width = 80, Height = 120},
             new RectangleItem(){X = 80, Y = 225, Width = 80, Height = 120},
             new RectangleItem(){X = 0, Y = 300, Width = 80, Height = 120},
             
             //MIDDLE LEFT & MIDDLE RIGHT
             new RectangleItem(){X = 0, Y = 150, Width = 80, Height = 120},
             new RectangleItem(){X = 320, Y = 150, Width = 80, Height = 120},

             //MIDDLE TOP & MIDDLE BOTTOM
             new RectangleItem(){X = 160, Y = 0, Width = 80, Height = 120},
             new RectangleItem(){X = 160, Y = 300, Width = 80, Height = 120},




        };

        private int _lifeNumber = 2;
        public int LifeNumber
        {
            get { return _lifeNumber; }
            set
            {
                _lifeNumber = value;
                OnPropertyChanged();
            }

        }
        private int _number;
        public int Number
        {
            get { return _number; }
            set
            {
                _number = value;
                OnPropertyChanged();
            }
        }

        public double Move(double x)
        {
            switch (x)
            {
                case 1:
                    return 10;
                case 2:
                    return 10;
            }
            return x;
        }
        
        private string _lifesCount;
        public string LifesCount
        {
            get { return _lifesCount; }
            set
            {
                _lifesCount = value;
                OnPropertyChanged();
            }
        }

        private string _arrowsCount;
        public string ArrowsCount
        {
            get { return _arrowsCount; }
            set
            {
                _arrowsCount = value;
                OnPropertyChanged();
            }
        }


        public static string dirParameter = AppDomain.CurrentDomain.BaseDirectory + @"\file.txt";

        //READ DATA
        public void ReadData()
        {
            try
            {

                using (var sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"\file.txt"))
                {

                    ArrowsCount = sr.ReadLine();
                    LifesCount = sr.ReadLine();

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }



        //SAVE DATA (ARROWS & LIFES) IN TXT FILE
        public void SaveData()
        {

            PlayerData player = new PlayerData() { Arrows = Number, Life = LifeNumber };

            FileStream fParameter = new FileStream(dirParameter, FileMode.Create, FileAccess.Write);
            StreamWriter m_WriterParameter = new StreamWriter(fParameter);
            m_WriterParameter.BaseStream.Seek(0, SeekOrigin.End);
            m_WriterParameter.Write(String.Format("{0}{2}{1}", player.Arrows, player.Life, Environment.NewLine));
            m_WriterParameter.Flush();
            m_WriterParameter.Close();

            /**
            string filePath = "data.save";
            DataSerializer dataSerializer = new DataSerializer();
            
            dataSerializer.XmlSerialize(typeof(PlayerData), player, filePath);
            _ = dataSerializer.XmlDeserialize(typeof(PlayerData), filePath) as PlayerData;
            **/
        }

       

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
