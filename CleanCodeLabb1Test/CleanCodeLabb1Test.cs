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
        public void GetUserDefinedMaxTest()
        {
            using (StringWriter stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);
                var numberInput = new StringReader("2");
                Console.SetIn(numberInput);
                var expected = string.Format("Enter a max number between 1 and 300:{0}", Environment.NewLine);
                var actual = stringWriter.ToString();

                program.GetUserDefinedMax();
                Assert.AreNotEqual(expected, stringWriter.ToString());
            }

        }

        [TestMethod]
        public void GetUserDefinedMaxTestInvalidInput()
        {
            using (StringWriter stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);
                var numberInput = new StringReader("0");
                Console.SetIn(numberInput);
                var expected = string.Format("Enter a max number between 1 and 300:{0}Invalid input.{0}", Environment.NewLine);

                program.GetUserDefinedMax();
                Assert.AreEqual(expected, stringWriter.ToString());
            }
        }

        [TestMethod]
        public void FizzbuzzTest()
        {
            using (StringWriter stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);

                int numberToTest = 15;
                program.Fizzbuzz(numberToTest);

                string expected = null;
                var newLine = Environment.NewLine;

                for (int i = 1; i < numberToTest + 1; i++)
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

        [TestMethod]
        public void TestIfInputIsAnswerToEverything()
        {
            using (StringWriter stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);

                int numberToTest = 42;
                program.Fizzbuzz(numberToTest);

                string expected = "";
                var newLine = Environment.NewLine;

                for (int i = 1; i < numberToTest + 1; i++)
                {
                    if (i == 42)
                        expected += string.Format($"{i}: Answer to the Ultiamte Question of Life, the Universe, and Everything{newLine}");

                    else if (i % 3 == 0 && i % 5 == 0)
                        expected += string.Format($"{i}: Fizzbuzz{newLine}");

                    else if (i % 3 == 0)
                        expected += string.Format($"{i}: Fizz{newLine}");

                    else if (i % 5 == 0)
                        expected += string.Format($"{i}: Buzz{newLine}");

                    else
                        expected += string.Format($"{i}{newLine}");
                }

                Assert.AreEqual(expected, stringWriter.ToString());
            }
        }
    }
}
