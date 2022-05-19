using System;
using Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LogicMarbles
{ 
    public class MarbleLogic : INotifyPropertyChanged
    {
        private Marble marble;

        public MarbleLogic(Marble marble)
        {
            this.marble = marble;
        }
        public int Radius
        {
            get
            {
                return marble.Radius;
            }
            set
            {
                marble.Radius = value;
                RaisePropertyChanged(nameof(Radius));
            }
        }
        public int Posx
        {
            get
            {
                return marble.Posx;
            }
            set
            {
                marble.Posx = value;
                RaisePropertyChanged(nameof(Posx));
            }
        }
        public int Posy
        {
            get
            {
                return marble.Posy;
            }
            set
            {
                marble.Posy = value;
                RaisePropertyChanged(nameof(Posy));
            }
        }
        public int Speed_x
        {
            get
            {
                return marble.Speed_x;
            }
            set
            {
                marble.Speed_x = value;
                RaisePropertyChanged(nameof(Speed_x));
            }
        }

        public int Speed_y
        {
            get
            {
                return marble.Speed_y;
            }
            set
            {
                marble.Speed_y = value;
                RaisePropertyChanged(nameof(Speed_y));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
