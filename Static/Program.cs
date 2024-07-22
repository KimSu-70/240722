using System;

namespace Static
{
    internal class Program
    {
        static class MyCalculator
        {
            public static double Add(double a, double b)
            {
                //두 개의 숫자를 받아 그 합을 반환합니다.
                return a + b;
            }
            public static double Subtract(double a, double b)
            {
                return a - b;
            }
            public static double Multiply(double a, double b)
            {
                return a * b;
            }
            public static double Divide(double a, double b)
            {
                if (a == 0)
                {
                    Console.WriteLine("0으로는 나눗셈이 불가능합니다");
                }
                else if (b == 0)
                {
                    Console.WriteLine("0으로는 나눗셈이 불가능합니다");
                }
                return a / b;
            }
            public static double Squared(double a, double b)
            {
                double c = 0;
                for (int i = 0; i < b; i++)
                {
                    c = a * a;
                }
                return c;
            }

            static void Main(string[] args)
            {
                Console.WriteLine("Hello, World!");
            }
        }
    }
}
