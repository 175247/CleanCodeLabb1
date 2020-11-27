using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeLabb1
{
    class ReadConsole : IConsole
    {
        public string ReadLine(int value)
        {
            return Console.ReadLine();
        }
    }
}
