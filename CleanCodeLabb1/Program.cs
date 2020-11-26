using System;

namespace CleanCodeLabb1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public string Fizzbuzz()
        {
            for (int i = 0; i < 300; i++)
            {
                if (i == 42)
                    Console.WriteLine("Answer to the Ultiamte Question of Life, the Universe, and Everything");

                else if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("Fizzbuzz");

                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");

                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
            }
            return null;
        }
    }
}
