using System;

namespace CleanCodeLabb1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();

            try
            {
                Console.WriteLine(program.GetUserDefinedMax(program, 15));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public string GetUserDefinedMax(Program program, int testValue)
        {
            Console.WriteLine("Enter a max number between 1 and 300:");

            int userDefinedMax = Convert.ToInt32(Console.ReadLine());

            if (testValue < 1 || testValue > 300)
            {
                GetUserDefinedMax(program, testValue);
            }
            
            return program.Fizzbuzz(testValue);
        }

        public string Fizzbuzz(int userDefinedMax)
        {
            string result = null;
            for (int i = 1; i <= userDefinedMax; i++)
            {
                if (i == 42)
                {
                    Console.WriteLine("{0}: Answer to the Ultiamte Question of Life, the Universe, and Everything", i);
                    result += $"{0}: Answer to the Ultiamte Question of Life, the Universe, and Everything" + i;
                }

                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("{0}: Fizzbuzz", i);
                    result += $"{0}: Fizzbuzz" + i;
                }

                else if (i % 3 == 0)
                {
                    Console.WriteLine("{0}: Fizz", i);
                    result += $"{0}: Fizz" + i;
                }

                else if (i % 5 == 0)
                {
                    Console.WriteLine("{0}: Buzz", i);
                    result += $"{0}: Buzz" + i;
                }
                else
                {
                    Console.WriteLine(i);
                    result += i;
                }
            }
            
            return result;
        }
    }
}
