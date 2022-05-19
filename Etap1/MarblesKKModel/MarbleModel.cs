using LogicMarbles;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MarblesKKModel

{
    public class MarbleModel : INotifyPropertyChanged
    {
        private int radius;
        private int posx;
        private int posy;
        public event PropertyChangedEventHandler PropertyChanged;
        public MarbleModel(MarbleLogic marble)
        {
            this.Radius = marble.Radius;
            this.Posx = marble.Posx - (Radius / 2);
            this.Posy = marble.Posy - (Radius / 2);
            marble.PropertyChanged += onPropertyChanged;
        }
        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public int Radius
        {
            get
            {
                return this.radius;
            }
            set
            {
                this.radius = value;
                RaisePropertyChanged(nameof(Radius));
            }
        }

        public int Posx
        {
            get
            {
                return this.posx;
            }
            set
            {
                    this.posx = value;
                    RaisePropertyChanged(nameof(Posx));
            }
        }
        public int Posy
        {
            get
            {
                return this.posy;
            }
            set
            {
                this.posy = value;
                RaisePropertyChanged(nameof(Posy));
            }
        }
    

        private void onPropertyChanged(object sender, PropertyChangedEventArgs eve)
        {
            MarbleLogic m = (MarbleLogic) sender;

            switch(eve.PropertyName)
            {
                case "Posx":
                    Posx = m.Posx;
                    break;
                case "Posy":
                    Posy = m.Posy;
                    break;
                case "Radius":
                    Radius = m.Radius;
                    break;
            }
        }
}
}