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
                Console.SetOut(stringWriter); // Där den skriver ut texten kopplas StringWritern in istället. Det är inte trådsäkert. Sidoeffekt.

                // Act
                program.Fizzbuzz(15);

                // Assert
                var expected = string.Format("{0}", Environment.NewLine);
                Assert.AreEqual(expected, stringWriter.ToString());
            }
        }
    }
}
