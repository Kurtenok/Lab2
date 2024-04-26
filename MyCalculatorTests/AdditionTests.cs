using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolidPrinciplesExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesExample.Tests
{
    [TestClass()]
    public class AdditionTests
    {
        [TestMethod()]
        public void ExecuteAdditionTest()
        {

            Addition addition = new Addition();
            int x = 2;
            int y = 3;
            double expected = 5;
            double result=addition.Execute(x, y);
            Assert.AreEqual(result, expected);
        }

        [TestMethod()]
        public void ExecuteSubtractionTest()
        {

            Subtraction subtraction = new Subtraction();
            int x = 3;
            int y = 2;
            double expected = 1;
            double result = subtraction.Execute(x, y);
            Assert.AreEqual(result, expected);
        }

        [TestMethod()]
        public void ExecuteMultiplicationTest()
        {

            Multiplication multiplication = new Multiplication();
            int x = 3;
            int y = 2;
            double expected = 6;
            double result = multiplication.Execute(x, y);
            Assert.AreEqual(result, expected);
        }

        [TestMethod()]
        public void ExecuteDivisionTest()
        {

            Division division = new Division();
            int x = 3;
            int y = 2;
            double expected = 1.5f;
            double result = division.Execute(x, y);
            Assert.AreEqual(result, expected);
        }
    }
}