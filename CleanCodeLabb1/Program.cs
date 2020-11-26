using System;

namespace CleanCodeLabb1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a max number:");

            try
            {
                int userDefinedMax = Convert.ToInt32(Console.ReadLine());
                Program program = new Program();
                program.Fizzbuzz(userDefinedMax);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public string Fizzbuzz(int userDefinedMax)
        {
            for (int i = 0; i < userDefinedMax; i++)
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
