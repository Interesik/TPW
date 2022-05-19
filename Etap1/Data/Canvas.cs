using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Canvas
    {
        private int width;
        private int height;
        private List<Marble> lmarbles = new List<Marble>();
        private Boolean On_Off = true;

        public Canvas(int width, int height, int marblesAmount, int marblesRadius)
        {
            if(width <= 0 || height <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            this.width = width;
            this.height = height;
        }
        public int getWidth()
        {
            return width;
        }
        public void setWidth(int newWidth)
        {
            this.width = newWidth;
        }
        public int getHeight()
        {
            return height;
        }
        public void setHeight(int newHeight)
        {
            this.height = newHeight;
        }
        public Boolean getOnOff()
        {
            return this.On_Off;
        }
        public void setOnOff(Boolean newOnOff)
        {
            this.On_Off = newOnOff;
        }
        public List<Marble> GetMarbles()
        {
            return lmarbles;
        }
        
        public void createMarbles(int amount, int marbleRadius)
        {
            
            Random random = new Random();
            for(int i = 0; i < amount; i++)
            {
                int x = random.Next(marbleRadius, this.width - marbleRadius);
                int y = random.Next(marbleRadius, this.height - marbleRadius);

                lmarbles.Add(new Marble(marbleRadius, x, y));
            }
        }
    } 
}
