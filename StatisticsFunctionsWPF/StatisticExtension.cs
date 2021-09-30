using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticsFunctionsWPF
{
    public static class StatisticExtension
    {
        public static double MaxValue<T>( this IEnumerable<T> values)
        {
            IEnumerable<double> doubles = values.Select(value => Convert.ToDouble(value));
            return doubles.Max();
        }

        public static double MinValue<T>(this IEnumerable<T> values)
        {
            IEnumerable<double> doubles = values.Select(value => Convert.ToDouble(value));
            return doubles.Min();
        }

        public static double MeanValue<T>(this IEnumerable<T> values)
        {
            IEnumerable<double> doubles = values.Select(value => Convert.ToDouble(value));
            return doubles.Average();
        }

        public static double TrunMeanValue<T>(this IEnumerable<T> values, int discardedValue)
        {
            IEnumerable<double> doubles = values.Select(value => Convert.ToDouble(value));
            double[] doubleArray = doubles.ToArray();

            Array.Sort(doubleArray);

            int start = discardedValue;
            int end = doubleArray.Length - 1 - discardedValue;

            int remainingNumbers = end - start + 1;

            double[] remainingNumberArray = new double[remainingNumbers];
            Array.Copy(doubleArray, start, remainingNumberArray, 0, remainingNumbers);

            return remainingNumberArray.Average();
        }

        public static double TrunMeanValue<T>(this IEnumerable<T> values, double discardedValue)
        {
            int number = Convert.ToInt32(values.Count() * discardedValue);
            return TrunMeanValue(values, number);
        }
    }
}
