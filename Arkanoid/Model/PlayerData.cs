using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Arkanoid.Model
{
    [Serializable]
    public class PlayerData
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
                OnPropertyChanged();
            }

        }
        private int _life;
        public int Life
        {
            get
            {
                return _life;
            }
            set
            {
                _life = value;
                OnPropertyChanged();
            }

        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
