
using OopsConcept.Inheritance;
namespace OopsConcept.Polymorphism
{
    namespace OopsConcept
    {

        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Choose the OOPS Concept:");
                Console.WriteLine("1.Inheritance\n2.Polymorphism\n3.Abstraction\n4.Encapsulation");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Rectangle r = new Rectangle(10, 7);
                        double a = r.area();
                        Console.WriteLine("Area: {0}", a);
                        Console.ReadLine();
                        break;




                }

            }
        }
    }
}