namespace MarblesKK_Model
{
    public class State
    {
        public string numberOfMurbles = "podaj liczbe kul";
        public class Marble
        {
            public double Radius { get; set; }
            public double Speed_X { get; set; }
            public double Speed_Y { get; set; }
            public double X { get; set; }
            public double Y { get; set; }
            public string Color { get; set; }

            public Marble(double radius, string color = "red")
            {
                Radius = radius;
                Color = color;
                Random rnd = new Random();
                Speed_X = rnd.Next(-10, 10);
                Speed_Y = rnd.Next(-10, 10);
                X = 0;
                Y = 0;
            }
            public async void Move()
            {
                X += Speed_X;
                Y += Speed_Y;
            }
        
        }
    }
}