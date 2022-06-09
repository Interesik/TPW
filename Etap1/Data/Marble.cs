using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Data
{
    public class Marble : INotifyPropertyChanged
    {
        private int id;
        private int radius;
        private int posx; 
        private int posy;
        private int speed_X;
        private int speed_Y;

        public Marble(int Radius, int X, int Y, int ID)
        {
            id = ID;
            radius = Radius;
            posx = X;
            posy = Y;
        }
        public int Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
                RaisePropertyChanged(nameof(Radius));
            }
        }
        public int Posx
        {
            get
            {
                return posx;
            }
            set
            {
                posx = value;
                RaisePropertyChanged(nameof(Posx));
            }
        }
        public int Posy
        {
            get
            {
                return posy;
            }
            set
            {
                posy = value;
                RaisePropertyChanged(nameof(Posy));
            }
        }

        public int Speed_x
        {
            get
            {
                return speed_X;
            }
            set
            {
                speed_X = value;
                RaisePropertyChanged(nameof(Speed_x));
            }
        }

        public int Speed_y
        {
            get
            {
                return speed_Y;
            }
            set
            {
                speed_Y = value;
                RaisePropertyChanged(nameof(Speed_y));
            }
        }
        public int ID
        {
            get
            {
                return id;
            }
            set 
            { 
                id = value;
                RaisePropertyChanged(nameof(ID));
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}