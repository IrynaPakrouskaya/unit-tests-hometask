﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsCalculator
{
    [TestClass]
    public class MSTest_Sub
    {
        private CSharpCalculator.Calculator testCalculator;
        private string inputNumber1StringFormat;
        private string inputNumber2StringFormat;
        private double inputNumber1DoubleFormat;
        private double inputNumber2DoubleFormat;

        [TestInitialize]
        public void SetUpData()
        {
            testCalculator = new CSharpCalculator.Calculator();
            inputNumber1StringFormat = "2.1";
            inputNumber2StringFormat = "-3";
            inputNumber1DoubleFormat = 2.4;
            inputNumber2DoubleFormat = -5;
        }

        [TestMethod]
        public void SubMSTestString()
        {
            double actualResult = testCalculator.Sub(inputNumber1StringFormat, inputNumber2StringFormat);
            double expectedResult = Convert.ToDouble(inputNumber1StringFormat) - Convert.ToDouble(inputNumber2StringFormat);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SubMSTestDouble()
        {
            double actualResult = testCalculator.Sub(inputNumber1DoubleFormat, inputNumber2DoubleFormat);
            double expectedResult = inputNumber1DoubleFormat - inputNumber2DoubleFormat;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCleanup]
        public void ClenupData()
        {
            testCalculator = null;
            inputNumber1StringFormat = null;
            inputNumber2StringFormat = null;
            inputNumber1DoubleFormat = 0;
            inputNumber2DoubleFormat = 0;
        }
    }
}
