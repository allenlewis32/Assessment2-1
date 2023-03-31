using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assessment2_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2_1.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void LicensePlateTest_A()
        {
            Assert.AreEqual(Program.LicensePlate("5F3Z-2e-9-w", 4), "5F3Z-2E9W");
        }
        [TestMethod()]
        public void LicensePlateTest_B()
        {
            Assert.AreEqual(Program.LicensePlate("2-5g-3-J", 2), "2-5G-3J");
        }
        [TestMethod()]
        public void LicensePlateTest_C()
        {
            Assert.AreEqual(Program.LicensePlate("2-4A0r7-4k", 3), "24-A0R-74K");
        }
        [TestMethod()]
        public void LicensePlateTest_D()
        {
            Assert.AreEqual(Program.LicensePlate("nlj-206-fv", 3), "NL-J20-6FV");
        }
    }
}