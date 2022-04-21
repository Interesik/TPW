using System.Windows;
using System.Windows.Input;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace MarblesKK_ViewModel
{
    public class MarblesViewModel : INotifyPropertyChanged
    {
        private MarblesKK_Model.State S = new MarblesKK_Model.State();
        private MarblesKK_Model.State.Marble M1 = new MarblesKK_Model.State.Marble(1);
        public string numberOfMurbles
        {
            get
            {
                return S.numberOfMurbles;
            }
            set
            {
                S.numberOfMurbles = value;
                onPropertyChange(nameof(numberOfMurbles));
            }
        }
        public double Radius
        {
            get
            {
                return M1.Radius;
            }
        }

        public double Speed_X
        {
            get
            {
                return M1.Speed_X;
            }
        }
        public double Speed_Y
        {
            get
            {
                return M1.Speed_Y;
            }
        }
        public double X
        {
            get
            {
                return M1.X;
            }
            set
            {
                if (value != M1.X)
                {
                    M1.X = value;
                    onPropertyChange(nameof(X));
                }
            }
        }
        public double Y
        {
            get
            {
                return M1.Y;
            }
            set
            {
                if (value != M1.Y)
                {
                    M1.Y = value;
                    onPropertyChange(nameof(Y));
                }
            }
        }
        public string Color
        {
            get
            {
                return M1.Color;
            }
        }
        /*  public ICommand Zacznij
          {
              get 
              {
                  if (Zacznij == null)
                      Zacznij = new RelayCommand( , );
                  return Zacznij;
              }
          }*/

        public event PropertyChangedEventHandler? PropertyChanged;

        private void onPropertyChange(string Name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(Name));
        }

        private MarblesKK_Model.Murbles marbles;
        public ObservableCollection<MarblesKK_Model.State.Marble> CMarbles { get; set; } = new ObservableCollection<MarblesKK_Model.State.Marble>();
        private void copytoColection()
        {
            CMarbles.Clear();
            foreach (MarblesKK_Model.State.Marble x in marbles)
                CMarbles.Add(x);
        }
        public MarblesViewModel()
        {
            marbles = new MarblesKK_Model.Murbles();
            for (int i = 0; i < 10; i++)
            {
                marbles.AddMurble(new MarblesKK_Model.State.Marble(1.0));
            }
            copytoColection();
        }


    }
}

