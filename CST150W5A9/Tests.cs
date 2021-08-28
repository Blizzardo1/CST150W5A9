using System.Text;

namespace CST150W5A9
{
    internal static class Tests
    {
        private static List<Action> _tests;
        static Tests()
        {
            _tests = new()
            {
                TestA,
                TestB,
                TestC,
                TestD,
                TestE,
                TestF,
                TestG,
                TestH,
                TestI,
                TestJ
            };
        }
        public static void TestA()
        {
            int a = Methods.Random.Next(0, int.MaxValue / 2);
            int b = Methods.Random.Next(0, int.MaxValue / 2);
            Methods.AddIntegers(a, b);
        }

        public static void TestB()
        {
            double a = 65.535;
            double b = 32.768;
            double c = 4294.967295;
            double d = 1.048576;
            double e = 1844674407.3709551615;
            Console.WriteLine($"\nAverage of {a}, {b}, {c}, {d}, and {e} is {Methods.Average(a, b, c, d, e)}");
        }

        public static void TestC()
        {
            Console.WriteLine($"\nThe sum of two random integers is {Methods.SumOfTwoRandomIntegers()}");
        }

        public static void TestD()
        {
            int a = Methods.Random.Next();
            int b = Methods.Random.Next();
            int c = Methods.Random.Next();
            Console.WriteLine($"\nIs the sum of {a}, {b}, and {c} divisible by three? {(Methods.SumDivisibleByThree(a, b, c) ? "Yes" : "No")}\n");
        }

        public static void TestE()
        {
            Methods.DisplayShortestString("This is the shortest string", "This is the absolute longest string");
        }

        public static void TestF()
        {
            double a = 65.535;
            double b = 32.768;
            double c = 4294.967295;
            double d = 1.048576;
            double e = 1844674407.3709551615;
            Console.WriteLine($"\nThe largest double from {a}, {b}, {c}, {d}, and {e} is {Methods.LargestDouble(a, b, c, d, e)}\n");
        }

        public static void TestG()
        {
            List<int> list = Methods.GenerateArray().ToList();
            var sb = new StringBuilder();
            list.ForEach(x => sb.Append($"{x}, "));
            Console.WriteLine($"\nA Generated array of {list.Count} has the following values: {sb.ToString().TrimEnd(',', ' ')}");
        }

        public static void TestH()
        {
            int a = Methods.Random.Next();
            int b = Methods.Random.Next();
            bool result = Methods.And(a % 2 == 0, b % 2 == 0);
            Console.WriteLine($"\nWhen compared, are both {a} and {b} even numbers? {(result ? "Yes" : "No")}");
            if (!result)
                Console.WriteLine($"When compared, is there at least one even number? {(Methods.Or(a % 2 == 0, b % 2 == 0) ? "Yes" : "No")}");
        }

        public static void TestI()
        {
            int a = 32;
            double b = 65.535;
            Console.WriteLine($"\nThe product of {a} and {b} is {Methods.Product(a, b)}");
        }

        public static void TestJ()
        {
            int a = Methods.Random.Next(5, 64);
            int b = Methods.Random.Next(5, 64);
            int[,] aa = Methods.Generate2dArray(a, b);
            Console.WriteLine($"\nThe average of an array of {a}x{b} is {Methods.AverageInteger(aa)}");
        }

        public static void RunTests()
        {
            _tests.ForEach(x => x());
        }
    }
}
