using Microsoft.VisualStudio.TestTools.UnitTesting;
using RocketMaths.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketMaths.Controllers.Tests
{
    [TestClass()]
    public class MathsControllerTests
    {
        private readonly MathsController maths;

        public MathsControllerTests()
        {
            maths = new MathsController();
        }

        [TestMethod()]
        public void AddTest()
        {
            Assert.AreEqual(maths.Add(1, 2), 3);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            Assert.AreEqual(maths.Subtract(2, 1), 1);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Assert.AreEqual(maths.Multiply(1, 2), 2);
        }

        [TestMethod()]
        public void DivideTest()
        {
            Assert.AreEqual(maths.Divide(10, 5), 2);
        }
    }
}