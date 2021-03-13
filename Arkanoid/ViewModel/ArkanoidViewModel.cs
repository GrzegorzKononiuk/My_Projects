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

namespace Arkanoid.ViewModel
{
  
    public class ArkanoidViewModel : INotifyPropertyChanged
    {
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

        public void SaveData()
        {
            PlayerData player = new PlayerData() { Arrows = Number };
            string filePath = "data.save";
            DataSerializer dataSerializer = new DataSerializer();
            
            dataSerializer.XmlSerialize(typeof(PlayerData), player, filePath);
            _ = dataSerializer.XmlDeserialize(typeof(PlayerData), filePath) as PlayerData;
            
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
