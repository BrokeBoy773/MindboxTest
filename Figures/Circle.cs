namespace Figures
{
    public static class Circle
    {
        public static double CalculateAreaFromRadius(double radius)
        {
            if (radius <= 0)
                return -1;

            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
