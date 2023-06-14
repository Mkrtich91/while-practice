﻿namespace WhilePractice
{
    public static class Task5
    {
        public static double GetSequenceProduct(int n)
        {
            double product = 1.0;
            double i = 1;

            while (i <= n)
            {
                double term = 1.0 + (1.0 / (i * i));
                product *= term;
                i++;
            }

            return product;
        }
    }
}
