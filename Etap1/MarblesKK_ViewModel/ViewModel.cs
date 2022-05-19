using System.Windows;
using System.Windows.Input;
using System.ComponentModel;
using System.Collections.ObjectModel;
using MarblesKKModel;
using System.Runtime.CompilerServices;
using System;

namespace MarblesKKViewModel
{
    public class MViewModel : INotifyPropertyChanged
    {
        private ModelAbstractApi Model;
        private ObservableCollection<MarbleModel> Marbles = new ObservableCollection<MarbleModel>();
        private int radius;
        private int posx;
        private int posy;
        private int amountOfMurbles;

        public ICommand Start { get; set; }
        public ICommand Stop { get; set; }
        public ICommand Restart { get; set; }

        public MViewModel()
        {
            Model = ModelAbstractApi.createApi();
            Start = new RelayCommand(() => start());
            Stop = new RelayCommand(() => stop());
            Restart = new RelayCommand(() => restart());
            this.Radius = 30;
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
        public int AmountOfMurbles
        {
            get
            {
                return amountOfMurbles;
            }
            set
            {
                amountOfMurbles = value;
                RaisePropertyChanged(nameof(AmountOfMurbles));
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
        
        public void stop()
        {
            Model.stop();
        }
        public void start()
        {
            Model.GetMarbelModels().Clear();
            Model.start(640, 480, AmountOfMurbles,Radius);
            this.marbles = Model.GetMarbelModels();
        }
        public void restart()
        {
            Model.GetMarbelModels().Clear();
            Model.restart();
            
        }
        public ObservableCollection<MarbleModel> marbles
        {
            get
            {
                return Marbles;
            }
            set
            {
                Marbles = value;
                RaisePropertyChanged(nameof(marbles));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}


