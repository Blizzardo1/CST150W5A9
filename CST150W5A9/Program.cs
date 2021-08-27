using System.Text;

namespace CST150W5A9
{
    internal static class Program
    {
        private static void Main(string[] args)
        {

            int a1 = Methods.Random.Next(0, int.MaxValue / 2);
            int a2 = Methods.Random.Next(0, int.MaxValue / 2);
            Methods.AddIntegers(a1, a2);


            double b1 = 65.535;
            double b2 = 32.768;
            double b3 = 4294.967295;
            double b4 = 1.048576;
            double b5 = 1844674407.3709551615;
            Console.WriteLine($"\nAverage of {b1}, {b2}, {b3}, {b4}, and {b5} is {Methods.Average(b1, b2, b3, b4, b5)}");

            Console.WriteLine($"\nThe sum of two random integers is {Methods.SumOfTwoRandomIntegers()}");

            int c1 = Methods.Random.Next();
            int c2 = Methods.Random.Next();
            int c3 = Methods.Random.Next();
            Console.WriteLine($"\nIs the sum of {c1}, {c2}, and {c3} divisible by three? {(Methods.SumDivisibleByThree(c1, c2, c3) ? "Yes" : "No")}\n");
            
            Methods.DisplayShortestString("This is the shortest string", "This is the absolute longest string");

            double d1 = 65.535;
            double d2 = 32.768;
            double d3 = 4294.967295;
            double d4 = 1.048576;
            double d5 = 1844674407.3709551615;
            Console.WriteLine($"\nThe largest double from {d1}, {d2}, {d3}, {d4}, and {d5} is {Methods.LargestDouble(d1, d2, d3, d4, d5)}\n");

            List<int> c = Methods.GenerateArray().ToList();
            var sb = new StringBuilder();
            c.ForEach(x => sb.Append($"{x}, "));
            Console.WriteLine($"\nA Generated array of {c.Count} has the following values: {sb.ToString().TrimEnd(',', ' ')}");

            int e1 = Methods.Random.Next();
            int e2 = Methods.Random.Next();
            bool er = Methods.And(e1 % 2 == 0, e2 % 2 == 0);
            Console.WriteLine($"\nWhen compared, are both {e1} and {e2} even numbers? {(er ? "Yes" : "No")}");
            if(!er)
                Console.WriteLine($"When compared, is there at least one even number? {(Methods.Or(e1 % 2 == 0, e2 % 2 == 0) ? "Yes" : "No")}");


            int f1 = 32;
            double f2 = 65.535;
            Console.WriteLine($"\nThe product of {f1} and {f2} is {Methods.Product(f1, f2)}");

            int g1 = Methods.Random.Next(5, 64);
            int g2 = Methods.Random.Next(5, 64);
            int[,] g3 = Methods.Generate2dArray(g1, g2);
            Console.WriteLine($"\nThe average of an array of {g1}x{g2} is {Methods.AverageInteger(g3)}");
        }
    }
}
