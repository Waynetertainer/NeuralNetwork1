using System;
using System.Collections.Generic;

namespace NeuralNetwork_1
{
    public static class Extensions
    {
        public static double NextGaussian(this Random r, double mu = 0, double sigma = 1)
        {
            var u1 = r.NextDouble();
            var u2 = r.NextDouble();

            var rand_std_normal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2);

            var rand_normal = mu + sigma * rand_std_normal;

            return rand_normal;
        }

        public static double[,] GaussianArray(this Random r, int x, int y, double mu = 0, double sigma = 1)
        {
            double[,] result = new double[x, y];
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = r.NextGaussian();
                }
            }

            return result;
        }

        public static List<double> GaussianList(this Random r, int x, double mu = 0, double sigma = 1)
        {
            List<double> result= new List<double>();
            for (int i = 0; i < x; i++)
            {
                result.Add(r.NextGaussian());
            }
            return result;
        }
    }
}
