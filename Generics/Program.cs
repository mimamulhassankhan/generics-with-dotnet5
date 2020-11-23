using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = Calculator.areEqual<string>("A", "2");
            Console.WriteLine(res);

            var genericClassRes = GenericCalculator<string>.areEqual("A", "A");
            Console.WriteLine(genericClassRes);
        }
    }

    public class Calculator
    {
        public static bool areEqual<T>(T a, T b)
        {
            return a.Equals(b);
        }
    }

    public class GenericCalculator<T>
    {
        public static bool areEqual(T a, T b)
        {
            return a.Equals(b);
        }
    }
}
