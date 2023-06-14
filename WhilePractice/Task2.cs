namespace WhilePractice
{
    public static class Task2
    {
        public static double SumSequenceElements(int n)
        {
            double sum = 0.0;
            double i = 1d;

            while (i <= n)
            {
                double term = Math.Pow(-1, i + 1) / (i * (i + 1));
                sum += term;
                i++;
            }

            return sum;
        }
    }
}
