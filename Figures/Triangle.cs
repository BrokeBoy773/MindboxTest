namespace Figures
{
    public static class Triangle
    {
        public static double CalculateAreaByThreeSides(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            
            double result = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            if (double.IsNaN(result))
                return -1;

            return result;
        }
    }
}
