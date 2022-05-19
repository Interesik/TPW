using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using LogicMarbles;
using Data;

namespace MarblesKKModel
{
    public abstract class ModelAbstractApi
    {
        public static ModelAbstractApi createApi(LogicAbstractApi logic = default)
        {
            return new Model(logic ?? LogicAbstractApi.createApi());
        }

        public abstract ObservableCollection<MarbleModel> GetMarbelModels();

        public abstract void stop();
        public abstract void restart();
        public abstract void start(int width, int height, int amount, int MarbleRadius);


        public class Model : ModelAbstractApi
        {
            private LogicAbstractApi LLogic;
            private ObservableCollection<MarbleModel> Marbles = new ObservableCollection<MarbleModel>();

            public Model(LogicAbstractApi logic)
            {
                LLogic = logic;
            }
            public override ObservableCollection<MarbleModel> GetMarbelModels()
            {
                return Marbles;
            }

            public override void restart()
            {
                LLogic.Restart();
            }

            public override void start(int width, int height, int amount, int marbleRadius)
            {
                Marbles.Clear();
                LLogic.createCanvas(width, height, amount, marbleRadius);
                foreach (MarbleLogic marble in LLogic.GetMarblesLogic())
                {
                    Marbles.Add(new MarbleModel(marble));
                }
                
            }

            public override void stop()
            {
                LLogic.Stop();
            }
        }
    }
}

