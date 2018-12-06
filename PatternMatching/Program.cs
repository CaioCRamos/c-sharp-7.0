using System;

namespace PatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            MatchingComplexTypes();
            MatchingPrimitiveTypes();
        }

        static Person GetRandomPerson()
        {
            var client = new Client { Name = "Caio", Document = "124578784", Address = "Workers Street 456" };
            var employee = new Employee { Name = "John", Document = "33445445345", PaymentValue = 5000 };

            return (new Random().Next() % 2) == 0 ?
                client as Person:
                employee as Person;
        }

        static void MatchingComplexTypes()
        {
            var person = GetRandomPerson();

            switch(person) 
            {
                case Client client:
                    Console.WriteLine($"Client: {client.Name}\nAddress: {client.Address}");
                    break;
                case Employee employee:
                    Console.WriteLine($"Employee: {employee.Name}\nPaymentValue: ${employee.PaymentValue}");
                    break;
                default:
                    break;
            }
        }

        static void MatchingPrimitiveTypes()
        {
            object obj1 = "text";
            object obj2 = 10;
            object obj3 = 10.5M;
            object obj4 = 10.5D;

            if (obj1 is string text)
                Console.WriteLine($"Type: string \nValue: {text}");
            
            if (obj2 is int intNumber)
                Console.WriteLine($"Type: int \nValue: {intNumber}");
            
            if (obj3 is decimal decimalNumber)
                Console.WriteLine($"Type: decimal \nValue: {decimalNumber}");

            if (obj4 is double doubleNumber)
                Console.WriteLine($"Type: double \nValue: {doubleNumber}");
        }
    }
}
