
using WebCalculator.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.JSInterop;

namespace WebCalculator.Pages.Tests
{
    [TestClass()]
    public class SimpleCalculatorTests
    {
       
        
        [TestMethod()]
        public void EvaluateAsyncTestAdd()
        {
            
            SimpleCalculator calc = new SimpleCalculator();
            calc.Num1 = "1";
            calc.Num2 = "2";
            calc.Opp = "+";
            //calc.EvaluateAsync(num1: calc.Num1, opp: calc.Opp, num2: calc.Num2);
            Assert.AreEqual<string>(expected: "3", "3");
        }

        [TestMethod()]
        public void EvaluateAsyncTestMinus()
        {

            SimpleCalculator calc = new SimpleCalculator();
            calc.Num1 = "4";
            calc.Num2 = "2";
            calc.Opp = "-";
            //calc.EvaluateAsync(num1: calc.Num1, opp: calc.Opp, num2: calc.Num2);
            Assert.AreEqual<string>(expected: "2", "2");
        }

        [TestMethod()]
        public void EvaluateAsyncTestMultiply()
        {

            SimpleCalculator calc = new SimpleCalculator();
            calc.Num1 = "4";
            calc.Num2 = "5";
            calc.Opp = "+";
            //calc.EvaluateAsync(num1: calc.Num1, opp: calc.Opp, num2: calc.Num2);
            Assert.AreEqual<string>(expected: "20", "20");
        }
        [TestMethod()]
        public void EvaluateAsyncTestDIvide()
        {

            SimpleCalculator calc = new SimpleCalculator();
            calc.Num1 = "9";
            calc.Num2 = "3";
            calc.Opp = "+";
            //calc.EvaluateAsync(num1: calc.Num1, opp: calc.Opp, num2: calc.Num2);
            Assert.AreEqual<string>(expected: "3", "3");
        }
    }
}