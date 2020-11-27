using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CleanCodeLabb1
{
    class MockConsole : IConsole
    {
        private Program _program;
        private StringWriter _stringWriter;

        public MockConsole()
        {
            Program program = new Program();
            StringWriter stringWriter = new StringWriter();
            _program = program;
            _stringWriter = stringWriter;
        }
        public string ReadLine(int value)
        {
            using (_stringWriter = new StringWriter())
            {
                Console.SetOut(_stringWriter);

                _program.Fizzbuzz(value);

                string expected = null;
                var newLine = Environment.NewLine;

                for (int i = 1; i < value + 1; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                        expected += string.Format($"{i}: Fizzbuzz{newLine}");

                    else if (i % 3 == 0)
                        expected += string.Format($"{i}: Fizz{newLine}");

                    else if (i % 5 == 0)
                        expected += string.Format($"{i}: Buzz{newLine}");

                    else
                        expected += string.Format($"{i}{newLine}");
                }

                return expected;
            }
        }
    }
}
