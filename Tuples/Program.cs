using System;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            DeclaringTuples();

            DeconstructingTuples();
        }

        static void  DeclaringTuples()
        {            
            (int, int) numbers1 = (10, 10);

            (int num1, int num2) numbers2 = (10, 10);
            
            (int first, int second) = (10, 10);

            var numbers3 = (10, 10);
        }

        static (int, int) ReturningDefaultValueTuples() => (10, 10);

        static (int num1, int num2) ReturningNamedValueTuples() => (10, 10);

        static void DeconstructingTuples()
        {
            //Getting directly the values as firstNumber and secondNumber
            (int fisrtNumber, int secondNumber) = ReturningDefaultValueTuples();
            
            //Getting the values n1 and n2 inside numbers1 (numbers1.n1 and numbers.n2)
            (int n1, int n2) numbers1 = ReturningDefaultValueTuples();

            //Getting the default values inside numbers2 (numbers1.item1 and numbers.item2)
            (int, int) numbers2 = ReturningNamedValueTuples();

            //Getting only the second value as value
            (_, int value) = ReturningNamedValueTuples();
        }
    }
}
