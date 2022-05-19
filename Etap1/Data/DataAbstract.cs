using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Data
{

    public abstract class DataAbstractApi
    { 
        public abstract void createCanvas(int width, int height, int amount, int marbleRadius);
        public abstract Canvas getCanvas();
        public abstract List<Marble> getMarbles();
        public static DataAbstractApi createApi()
        {
            return new DataApi();
        }
        internal class DataApi : DataAbstractApi
        {
            private Canvas canvas;
            public override void createCanvas(int width, int height, int amount, int marbleRadius)
            {
                this.canvas = new Canvas(width, height, amount, marbleRadius);
                this.canvas.createMarbles(amount, marbleRadius);
            }

            public override Canvas getCanvas()
            {
                return this.canvas;
            }

            public override List<Marble> getMarbles()
            {
                return this.canvas.GetMarbles();
            }
        }
    }
}
