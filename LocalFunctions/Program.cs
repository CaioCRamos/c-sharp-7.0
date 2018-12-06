using System;

namespace LocalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            void PrintNumbers(int n1, int n2, string operation, int res)
            {
                Console.WriteLine($"{n1}{operation}{n2}={res}");
            }            

            int num1 = 2, num2 = 3;
            int result = num1 + num2;
            PrintNumbers(num1, num2, "+", result);

            num1 = 1;
            num2 = 6;
            result = num1 * num2;
            PrintNumbers(num1, num2, "*", result);

            num1 = 10;
            num2 = 7;
            result = num1 - num2;
            PrintNumbers(num1, num2, "-", result);
        }
    }
}
