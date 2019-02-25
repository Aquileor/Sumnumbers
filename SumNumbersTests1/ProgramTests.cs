using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumbers.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void sumTest()
        {
            Assert.AreEqual((7.86), Program.sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 7));
        }
    }
}