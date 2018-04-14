using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! It is a custom.\n");

            int x = 89;
            int y = 22;
            int z = 57;

            Console.WriteLine(x);

            Console.WriteLine("y={0}; z={1}", y, z);
            Console.WriteLine("\n");


            string myName;

            Console.WriteLine("What's my name?");

            myName = Console.ReadLine();

            Console.WriteLine("Hello {0}", myName);


            Console.WriteLine("What's my age?");

            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("I am {0} years old", age);


            var trueFalse = true;  //implicitly implied variables must be initialized
            var newNumber = 3.14;
            Console.WriteLine("The answer will always be {0} and the number is {1}", trueFalse, newNumber);
            Console.WriteLine(trueFalse);


      


           

       
        }
    }
}
