﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        public void TotalTest()
        {
            Assert.AreEqual((78.888), Program.Total(8));
        }
    }
}