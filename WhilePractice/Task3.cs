namespace WhilePractice
{
    public static class Task3
    {
        public static double SumSequenceElements(int n)
        {
            double sum = 0.0;
            double i = 1.0;
            while (i <= n)
            {
                double term = 1.0 / Math.Pow(i, 5);
                sum += term;
                i++;
            }

            return sum;
        }
    }
}
