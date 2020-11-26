using System;

namespace CleanCodeLabb1
{
    public class Program
    {

        public static void Main(string[] args)
        {
            try
            {
                Program program = new Program();
                program.GetUserDefinedMax(program);
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public void GetUserDefinedMax(Program program)
        {
            Console.WriteLine("Enter a max number between 1 and 300:");

            int userDefinedMax = Convert.ToInt32(Console.ReadLine());

            if (userDefinedMax < 1 || userDefinedMax > 300)
            {
                GetUserDefinedMax(program);
            }
            else
            {
                program.Fizzbuzz(userDefinedMax);
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
