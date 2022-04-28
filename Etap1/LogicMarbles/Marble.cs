using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Logic
{
    public class Marble : INotifyPropertyChanged
    {
        private int radius;
        private int posx;
        private int posy;
        private static Random rnd = new Random();
        private int speed_X = rnd.Next(-1, 2);
        private int speed_Y = rnd.Next(-1, 2);

        public Marble(int Radius, int X, int Y)
        {
            this.radius = Radius;
            this.posx = X;
            this.posy = Y;
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


        public void move(int width, int height)
        {
            while(speed_X == 0 || speed_Y == 0)
            {
                speed_X = rnd.Next(-1, 2);
                speed_Y = rnd.Next(-1, 2);
            }
            if (this.Posx + speed_X >= (width - this.Radius))
            {
                speed_X *= -1;
            }
            if (this.Posy + speed_Y >= (height - this.Radius))
            {
                speed_Y *= -1;
            }
            if (this.Posx + speed_X <= 0)
            {
                speed_X *= -1;
            }
            if (this.Posy + speed_Y <= 0)
            {
                speed_Y *= -1;
            }
            this.Posx += speed_X;

            this.Posy += speed_Y;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    } 
}