using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST150W5A9
{
    internal static class Methods
    {
        private static Random _random = new Random();
        public static Random Random => _random;

        /// <summary>
        /// Adds two <see cref="Int32"/>
        /// </summary>
        /// <param name="a">Left-hand</param>
        /// <param name="b">Right-hand</param>
        public static void AddIntegers(int a, int b) => Console.WriteLine($"{a} + {b} = {a + b}");

        /// <summary>
        /// Averages an array of <see cref="Double"/>
        /// </summary>
        /// <param name="d">The array containing the <see cref="Double"/> needed to be averaged</param>
        /// <returns>An average of the elements</returns>
        public static double Average(params double[] d)
        {
            double a = 0d;
            foreach (var x in d)
            {
                a += x;
            }

            return a / d.Length;
        }

        /// <summary>
        /// Gets the sum of two random <see cref="Int32"/>
        /// </summary>
        /// <returns>The sum of two random <see cref="Int32"/></returns>
        public static int SumOfTwoRandomIntegers() => _random.Next() + _random.Next();

        /// <summary>
        /// Checks to see if three real integers added together are divisible by three
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns>True if the three numbers added together are divisible by three</returns>
        public static bool SumDivisibleByThree(int a, int b, int c) => (a + b + c) % 3 == 0;

        /// <summary>
        /// Displays one of the two strings that happens to be shorter than the other.
        /// </summary>
        /// <param name="a">Left-hand</param>
        /// <param name="b">Right-hand</param>
        public static void DisplayShortestString(string a, string b) => Console.WriteLine(a.Trim(' ').Length > b.Trim(' ').Length ? b : a);

        /// <summary>
        /// Gets the largest <see cref="Double"/> within an array
        /// </summary>
        /// <param name="d">The array</param>
        /// <returns>The largest <see cref="Double"/></returns>
        public static double LargestDouble(params double[] d) => d.Max();

        /// <summary>
        /// Generates a 1-Dimensional array
        /// </summary>
        /// <param name="count">The amount of elements to create</param>
        /// <returns>A 1-Dimensional array</returns>
        public static int[] GenerateArray(int count = 50)
        {
            int[] a = new int[count];

            for (int i = 0; i < count; i++)
            {
                a[i] = _random.Next();
            }

            return a;
        }

        /// <summary>
        /// Compares two <see cref="Boolean"/> values producing a Logical AND
        /// </summary>
        /// <param name="a">Left-hand</param>
        /// <param name="b">Right-hand</param>
        /// <returns>An AND result</returns>
        public static bool And(bool a, bool b) => a && b;

        public static bool Or(bool a, bool b) => a || b;

        /// <summary>
        /// Multiplication between an integer and a double
        /// </summary>
        /// <param name="a">An <see cref="Int32"/></param>
        /// <param name="b">A <see cref="Double"/></param>
        /// <returns></returns>
        public static double Product(int a, double b) => a * b;

        /// <summary>
        /// Averages the numbers in a 2D array
        /// </summary>
        /// <param name="a">The 2D array to average</param>
        /// <returns>The average of the elements within a 2D array</returns>
        public static int AverageInteger(int[,] a)
        {
            int r = 0;
            for (int y = 0; y < a.GetLength(0); y++)
            {
                for (int x = 0; x < a.GetLength(1); x++)
                {
                    r += a[y, x];
                }
            }
            return r / a.Length;
        }

        /// <summary>
        /// For your comforting pleasure, displaying the contents of a 2-Dimensional array
        /// </summary>
        /// <param name="a">The 2D array to display</param>
        public static void Display2dArray(int[,] a)
        {
            var sb = new StringBuilder();
            for (int y = 0; y < a.GetLength(0); y++)
            {
                for (int x = 0; x < a.GetLength(1); x++)
                {
                    sb.Append($"{a[y, x]}, ");
                }
                Console.WriteLine(sb.ToString().TrimEnd(',', ' '));
                sb.Clear();
            }
        }

        /// <summary>
        /// Generates a 2D Array
        /// </summary>
        /// <param name="columns">How many columns to process per row</param>
        /// <param name="rows">How many rows to process for the entire table</param>
        /// <returns>A 2D array filled with random numbers</returns>
        public static int[,] Generate2dArray(int columns, int rows)
        {
            int[,] a = new int[rows, columns];
            for (int y = 0; y < a.GetLength(0); y++)
            {
                for (int x = 0; x < a.GetLength(1); x++)
                {
                    a[y, x] = _random.Next();
                }
            }
            return a;
        }
    }
}
