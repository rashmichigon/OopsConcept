
using OopsConcept.Abstraction;
using OopsConcept.Inheritance;
namespace OopsConcept.Encapsulation
{
    namespace OopsConcept.Polymorphism
    {
        namespace OopsConcept.Abstraction
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
                        case 1:  //Inheritance
                            Rectangle r = new Rectangle(10, 7);
                            double a = r.area();
                            Console.WriteLine("Area: {0}", a);
                            Console.ReadLine();
                            break;
                        case 2: //Polymorphism
                            Shape sh = new Square();
                            double result = sh.area();
                            Console.Write("{0}", result);
                            break;
                        case 3: //Abstraction
                            Rectangle r = new Rectangle();
                            r.length = 4.5;
                            r.width = 3.5;
                            r.Display();
                            Console.ReadLine();
                            break;
                    }

                }
            }
        }
    }
}