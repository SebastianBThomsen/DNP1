namespace MathLib
{
    public class Calculator
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static double Add(double[] numbers)
        {
            double result = 0;
                
            foreach (double number in numbers)
            {
                result+=number;
            }

            return result;
        }

        public static double DisplayLargest(double x, double y)
        {
            if (x < y)
            {
                return y;
            }
            return x;
        }
    }
}