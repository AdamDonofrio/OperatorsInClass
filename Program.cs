// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Create a simple program to write out the results of addition, subtraction, multiplication, division, and modulus operations

namespace OperatorsinClass
{
    public class Program
    {

        static public int Sum(int num1, int num2)
        {

            return num1 + num2;
        }

        static public int subtract(int num1, int num2)
        {

            return num1 - num2;
        }

        static public int Multiply(int num1, int num2, int num3)
        {

            return num1 * num2 * num3;
        }

        static public int divid(int a, int b)
        {

            return a / b;
        }

        static public void mod(int a, int b)
        {

            int quotient = divid(a, b);

            Console.WriteLine($"{a}/{b} is {quotient} remainder {a % b}");
        }

        static public void AreaOfCircle(double radius)
        {

            Console.WriteLine($"The area of a circle with radius of {radius} is {(Math.PI) * Math.Pow(radius, 2)}");
        }
        static void Main(string[] args)
        {

            // Exercise 2 -----------------------------------------

            var amountOfCars = Sum(1, 2);
            var blah = Multiply(1, 2, 3);

            Console.WriteLine($"Sum:{amountOfCars}, Multiply:{blah}");

            Console.WriteLine("Divide: ");
            int dividNumA = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("and: ");
            int dividNumB = Convert.ToInt32(Console.ReadLine());
            

            mod(dividNumA, dividNumB);
            mod(17, 4);

            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());

            AreaOfCircle(radius);
            Console.WriteLine(radius);

            // Exercise 1 ------------------------------------------

            /*Console.WriteLine("What is your name ?");
            string name = Console.ReadLine();

            Console.WriteLine($"Hi {name}. What is your favorite Color?");
            string favColor = Console.ReadLine();

            Console.WriteLine($"{favColor} is a good color. What is your favorite Animal?");
            string favAnimal = Console.ReadLine();

            Console.WriteLine($"What is your favorite Band?");
            string favBand = Console.ReadLine();

            Console.WriteLine($"{favBand} is a great Band");*/
        }
    }
}


