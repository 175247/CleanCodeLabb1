using Microsoft.VisualStudio.TestTools.UnitTesting;
using CleanCodeLabb1;
using System;
using System.IO;

namespace CleanCodeLabb1Test
{
    [TestClass]
    public class CleanCodeLabb1Test
    {
        Program program;

        public CleanCodeLabb1Test()
        {
            program = new Program();
        }

        [TestMethod]
        public void FizzbuzzTest()
        {
            using (StringWriter stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);

                program.Fizzbuzz(15);

                string expected = null;
                var newLine = Environment.NewLine;

                for (int i = 1; i < 16; i++)
                {

                    if (i % 3 == 0 && i % 5 == 0)
                        expected += string.Format($"{i}: Fizzbuzz{newLine}");

                    else if(i % 3 == 0)
                        expected += string.Format($"{i}: Fizz{newLine}");

                    else if(i % 5 == 0)
                        expected += string.Format($"{i}: Buzz{newLine}");

                    else
                        expected += string.Format($"{i}{newLine}");
                }

                Assert.AreEqual(expected, stringWriter.ToString());
            }
        }
    }
}
