namespace OopsConcept
{
    using OopsConcept.Inheritance;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Programmer p1 = new Programmer();
            Console.WriteLine("Salary: " + p1.salary);
            Console.WriteLine("Bonus: " + p1.bonus);
        }
    }
}