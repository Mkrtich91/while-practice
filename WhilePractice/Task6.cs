namespace WhilePractice
{
    public static class Task6
    {
        public static double SumSequenceElements(int n)
        {
            double sum = 0;
            double i = 1.0;
            int sign = -1;

            while (i <= n)
            {
                double term = sign * (1.0 / ((2 * i) + 1));

                sum += term;

                sign *= -1;
                i++;
            }

            return sum;
        }
    }
}
