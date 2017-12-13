using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void IsOKTest()
        {
            Program.IsOK().Is(true);
        }

        [TestMethod()]
        public void IsNGTest()
        {
            Program.IsOK().Is(false);
        }
    }
}