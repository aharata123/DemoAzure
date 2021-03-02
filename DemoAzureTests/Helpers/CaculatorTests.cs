using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoAzure.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAzure.Helpers.Tests
{
    [TestClass()]
    public class CaculatorTests
    {
        [TestMethod()]
        public void AdditionTest1()
        {
            int NumberA = 10;
            int NumberB = 20;
            int Result = Caculator.Addition(NumberA, NumberB);

            Assert.IsTrue(Result == 30);
        }

        [TestMethod()]
        public void AdditionTest2()
        {
            int NumberA = 3;
            int NumberB = 20;
            int Result = Caculator.Addition(NumberA, NumberB);

            Assert.IsTrue(Result == 23);
        }
    }
}