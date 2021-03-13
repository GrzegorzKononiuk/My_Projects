using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel;

namespace Arkanoid.Model
{
    [Serializable]
    public class PlayerData : INotifyPropertyChanged
    {
        private int arrows;
        public int Arrows
        {
            get
            {
                return arrows;
            }
            set
            {
                arrows = value;
                OnPropertyChanged("Arrows");
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
