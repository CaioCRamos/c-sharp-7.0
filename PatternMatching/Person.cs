namespace PatternMatching
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Document { get; set; }
    }

    public class Client : Person
    {
        public string Address { get; set; }
    }

    public class Employee : Person
    {
        public decimal PaymentValue { get; set; }
    }
}