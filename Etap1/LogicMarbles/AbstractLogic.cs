using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LogicMarbles
{

    public abstract class LogicAbstractApi
    {
        public static LogicAbstractApi createApi(DataAbstractApi dataAbstractApi = null)
        {
            return new LogicApi(dataAbstractApi);
        }
        public abstract void createCanvas(int width, int height, int amount, int marbleRadius);
        public abstract List<MarbleLogic> GetMarblesLogic();
        public abstract void Stop();
        public abstract void Restart();

        internal class LogicApi : LogicAbstractApi
        {
            private DataAbstractApi DataApi;
            private readonly object ColisionLock = new object();
            private List<MarbleLogic> logMarbles = new List<MarbleLogic>();
            bool On_Off = false;
            public LogicApi(DataAbstractApi dataAbstractApi = null)
            {
                this.DataApi = DataAbstractApi.createApi();
            }
            public List<MarbleLogic> LogMarbles
            {
                get 
                {
                    return logMarbles; 
                }
                set 
                { 
                    logMarbles = value; 
                }
            }
            public bool on_Off
            {
                get 
                { 
                    return On_Off; 
                }
                set 
                {
                    On_Off = value; 
                }
            }

            public override void createCanvas(int width, int height, int amount, int marbleRadius)
            {

                DataApi.createCanvas(width, height, amount, marbleRadius);
                foreach (Marble m in DataApi.getMarbles())
                {
                    while (m.Speed_x == 0 &&  m.Speed_y == 0)
                    {
                        m.Speed_x = new Random().Next(-2, 3);
                        m.Speed_y = new Random().Next(-2, 3);
                    }
                    this.logMarbles.Add(new MarbleLogic(m));
                }
                this.On_Off = true;
                foreach (MarbleLogic ML in this.logMarbles)
                {
                    Task t = new Task(() =>
                    {
                        while (this.On_Off)
                        {
                            foreach (MarbleLogic ML2 in this.logMarbles)
                            {
                                if (!ML.Equals(ML2))
                                {
                                    lock(ColisionLock)
                                    {
                                        var velocityxML = ML.Speed_x;
                                        var velocityyML = ML.Speed_y;
                                        var velocityxML2 = ML2.Speed_x;
                                        var velocityyML2 = ML2.Speed_y;
                                        double dys;
                                        dys = Math.Sqrt(((ML.Posx + ML.Radius/2) - (ML2.Posx + ML2.Radius/2)) * ((ML.Posx + ML.Radius/2) - (ML2.Posx + ML2.Radius/2)) + ((ML.Posy + ML.Radius/2) - (ML2.Posy + ML2.Radius/2)) * ((ML.Posy + ML.Radius/2) - (ML2.Posy + ML2.Radius/2)));
                                        if (dys < ML.Radius)
                                        {
                                            ML.Speed_x = (2 * ML2.Radius * velocityxML2) / (ML.Radius + ML2.Radius);
                                            ML2.Speed_x = (2 * ML.Radius * velocityxML) / (ML.Radius + ML2.Radius);
                                            ML.Speed_y = (2 * ML2.Radius * velocityyML2) / (ML.Radius + ML2.Radius);
                                            ML2.Speed_y = (2 * ML2.Radius * velocityyML) / (ML.Radius + ML2.Radius);
                                        }
                                    }
                                }
                            }
                            if (ML.Posx + ML.Speed_x >= (width - ML.Radius))
                            {
                                ML.Speed_x *= -1;
                            }
                            if (ML.Posy + ML.Speed_y >= (height - ML.Radius))
                            {
                                ML.Speed_y *= -1;
                            }
                            if (ML.Posx + ML.Speed_x <= 0)
                            {
                                ML.Speed_x *= -1;
                            }
                            if (ML.Posy + ML.Speed_y <= 0)
                            {
                                ML.Speed_y *= -1;
                            }
                            ML.Posx += ML.Speed_x;

                            ML.Posy += ML.Speed_y;
                            Thread.Sleep(10);
                        }
                    });
                    t.Start();
                }
            }
            public override void Restart()
            {
                this.On_Off = false;
                this.LogMarbles.Clear();
            }

            public override void Stop()
            {
                this.On_Off = false;
            }
            public override List<MarbleLogic> GetMarblesLogic()
            {
                return this.logMarbles;
            }
        }
    } 
}
