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

            /* Constants 
            */
            const double PI = 3.14;         //constants must be intialized with a value when declared
            Console.WriteLine(PI);
         

            /* Arithmetic Operators
            */
            int x1 = 10;
            int y2 = 4;
            double z1 = 16 / 5.0;
            int mod_x = 25 % 7;
            int increment = 42;
            Console.WriteLine(x1 - y2);
            Console.WriteLine(z1);
            Console.WriteLine(mod_x);
            increment += 2;
            Console.WriteLine(increment);
            increment++;
            Console.WriteLine(increment);







      


           

       
        }
    }
}
