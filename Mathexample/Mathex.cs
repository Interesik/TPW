namespace Mathexample
{
    public static class Mathex
    {
        public static int add(int a,int b) 
        { 
            return a + b;
        }
        public static double add(double a, double b)
        {
            return a + b;
        }
        public static int subtract(int a, int b)
        {
            return a - b;
        }
        public static double subtract(double a, double b)
        {
            return a - b;
        }
        public static dynamic div(int a, int b) 
        {
            try { return a / b; }
            catch (DivideByZeroException) { throw new DivideByZeroException(); }
        }
        public static dynamic div(double a, double b)
        {
            try { return a / b; }
            catch (DivideByZeroException) { throw new DivideByZeroException(); }
        }
        public static int mul(int a, int b)
        {
            return a * b;
        }

        public static double mul(double a,double b)
        {
            return a * b;
        }

        public static int mod(int a, int b) 
        { 
            return a % b; 
        }
    }
}