using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int x = 8;
            int y = 3;

            if(x > y)
            {
                Console.WriteLine("x is greater than y");
            }

            int mark = 85;

            if (mark < 50)
            {
                Console.WriteLine("You failed.");
            }
            else
            {
                Console.WriteLine("You passed.");
            }


            int second_mark = 100;

            if(second_mark >= 50)
            {
                Console.WriteLine("You passed.");
                if(second_mark == 100)
                {
                    Console.WriteLine("Perfect!");
                }
            }
            else
            {
                Console.WriteLine("You failed.");
            }


            int age = 17;
            if (age > 14)
            {
                if (age > 18)
                {
                    Console.WriteLine("Adult");
                }
                else
                {
                    Console.WriteLine("Teenager");
                }
            }
            else
            {
                if (age > 0)
                {
                    Console.WriteLine("Child");
                }
                else
                {
                    Console.WriteLine("Something's wrong");
                }
            }


            int z = 33;

            if (z == 8)
            {
                Console.WriteLine("Value of z is 8");
            }
            else if (z == 18)
            {
                Console.WriteLine("Value of z is 18");
            }
            else if (z == 33)
            {
                Console.WriteLine("Value of z is 33");
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
    }
}
