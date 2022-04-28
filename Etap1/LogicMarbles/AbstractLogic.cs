using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Logic
{

    public abstract class LogicAbstractApi
    {
        public static LogicAbstractApi createApi(DataAbstractApi dataAbstractApi = null)
        {
            return new LogicApi(dataAbstractApi);
        }
        public abstract void createCanvas(int width, int height, int amount, int marbleRadius);

        public abstract void Move();
        public abstract void Stop();
        public abstract void Restart();
        public abstract Canvas getCanvas();

        internal class LogicApi : LogicAbstractApi
        {
            private Canvas canvas;

            private DataAbstractApi DataApi;

            private List<Thread> threads;

            public LogicApi(DataAbstractApi dataAbstractApi = null)
            { 
                    this.DataApi = DataAbstractApi.creatApi();
            }
            public override void createCanvas(int width, int height, int amount, int marbleRadius)
            {
                this.canvas = new Canvas(width, height, amount, marbleRadius);
                this.canvas.createMarbles(amount, marbleRadius);
            }

            public override Canvas getCanvas()
            {
                return this.canvas;
            }

            public override void Move()
            {
                threads = new List<Thread>();
                this.canvas.setOnOff(true);
                foreach (Marble marble in this.canvas.GetMarbles())
                {
                    Thread t = new Thread(() =>
                    {
                        while (this.canvas.getOnOff())
                        {
                            marble.move(this.canvas.getWidth(), this.canvas.getHeight());
                            Thread.Sleep(7);
                        }
                    });
                    t.Start(); 
                }
            }

            public override void Restart()
            {
                this.canvas.setOnOff(false);
                this.canvas.GetMarbles().Clear();
            }

            public override void Stop()
            {
                this.canvas.setOnOff(false);
            }
        }
    } 
}
