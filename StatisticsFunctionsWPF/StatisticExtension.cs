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

        public static double Median<T>(this IEnumerable<T> values)
        {
            IEnumerable<double> doubles = values.Select(value => Convert.ToDouble(value));
            double[] doubleArr = doubles.ToArray();

            Array.Sort(doubleArr);

            int valueLength = doubleArr.Length;
            if(valueLength % 2 == 1)
            {
                return doubleArr[valueLength / 2];
            }

            double value1 = doubleArr[valueLength / 2 - 1];
            double value2 = doubleArr[valueLength / 2];
            return (value1 + value2) / 2.0;
        }

        public static List<T> Mode<T>(this IEnumerable<T> values)
        {
            
            Dictionary<T, int> counts = new Dictionary<T, int>();
            
            foreach (T value in values)
            {
                if (!counts.ContainsKey(value))
                    counts.Add(value, 1);
                else
                    counts[value]++;
            }
            
            int largestCount = counts.Values.Max();
            
            List<T> modes = new List<T>();
            foreach (KeyValuePair<T, int> pair in counts)
                if (pair.Value == largestCount) modes.Add(pair.Key);
            return modes;
        }

        public static double StdDev<T>(this IEnumerable<T> values, bool asSample = false)
        {
            
            IEnumerable<double> doubles =
            values.Select(value => Convert.ToDouble(value));
            
            int numValues = doubles.Count();
            double mean = doubles.Average();
            
            
            var squaresQuery = from double value in doubles select (value - mean) * (value - mean);
            double sumOfSquares = squaresQuery.Sum();
            
            if (asSample)
                return Math.Sqrt(sumOfSquares / (numValues - 1));
            return Math.Sqrt(sumOfSquares / numValues);
        }
    }
}
