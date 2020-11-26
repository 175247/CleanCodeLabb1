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
                if (userDefinedMax < 1 || userDefinedMax > 300)
                {
                    Console.WriteLine("Invalid input.", Environment.NewLine);
                    Main(args);
                }

                Program program = new Program();
                program.Fizzbuzz(userDefinedMax);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public void Fizzbuzz(int userDefinedMax)
        {
            for (int i = 1; i <= userDefinedMax; i++)
            {
                if (i == 42)
                    Console.WriteLine("{0}: Answer to the Ultiamte Question of Life, the Universe, and Everything", i);

                else if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("{0}: Fizzbuzz", i);

                else if (i % 3 == 0)
                    Console.WriteLine("{0}: Fizz", i);

                else if (i % 5 == 0)
                    Console.WriteLine("{0}: Buzz", i);
                else
                    Console.WriteLine(i);
            }
        }
    }
}
