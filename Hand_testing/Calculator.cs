namespace Hand_testing
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            double c;
            c = a + b;
            return c;
        }

        public double Subtract(double a, double b)
        {
            double c;
            c = a - b;
            return c;
        }

        public double Multiply(double a, double b)
        {
            double c;
            c = a * b;
            return c;
        }

        public double Power(double x, double exp)
        {
            double c = 1;
            if(exp == 0)
            {
                return c;
            }
            else if(exp <0)
            {
                c = 0;
                return c;
            }
            else
            {
                c = x;
                for (int e = 0; e < exp; e++)
                {
                    c = c * x;
                }
                return c;
            }
        }
    }
}
