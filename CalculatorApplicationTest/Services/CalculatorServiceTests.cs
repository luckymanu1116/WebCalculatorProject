using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorApplication.Tests
{
    [TestClass()]
    public class CalculatorServiceTests
    {
        private readonly CalculatorService calculatorService;
        private List<double> ListOfValues;

        #region Constructor
        public CalculatorServiceTests()
        {
            calculatorService = new CalculatorService();
        }
        #endregion

        #region AdditionTestScenarios
        [TestMethod()]
        public void AdditionTestScenario1()
        {
            ListOfValues = new List<double>() { };
            Assert.ThrowsException<NullReferenceException>(() => calculatorService.Addition(ListOfValues));
        }

        [TestMethod()]
        public void AdditionTestScenario2()
        { 
            ListOfValues = new List<double>() { 0, 0, 0, 0, 0, 0 };
            var Response = calculatorService.Addition(ListOfValues);
            Assert.AreEqual(Response, 0);
        }

        [TestMethod()]
        public void AdditionTestScenario3()

        {
            ListOfValues = null;
            Assert.ThrowsException<NullReferenceException>(() => calculatorService.Addition(ListOfValues));
        }

        [TestMethod()]
        public void AdditionTestScenario4()
        {
            ListOfValues = new List<double>() { -1, -2, -7, -6, -8 };
            var Response = calculatorService.Addition(ListOfValues);
            Assert.AreEqual(Response, -24);
        }

        [TestMethod()]
        public void AdditionTestScenario5()
        {
            ListOfValues = new List<double>() { 7, 1, 2, 8,  5, 6 };
            var Response = calculatorService.Addition(ListOfValues);
            Assert.AreEqual(Response, 29);
        }

        [TestMethod()]
        public void AdditionTestScenario6()
        {
            ListOfValues = new List<double>() { 15, 25, -23, 125, -298, 67 };
            var Response = calculatorService.Addition(ListOfValues);
            Assert.AreEqual(Response, -89);
        }

        [TestMethod()]
        public void AdditionTestScenario7()
        {
            ListOfValues = new List<double>() { -2.5, -25.89, -36.987, -52.9987, -39687.324 };
            var Response = calculatorService.Addition(ListOfValues);
            Assert.AreEqual(Response, -39805.700);
        }

        [TestMethod()]
        public void AdditionTestScenario8()
        {
            ListOfValues = new List<double>() { 7.2, 2.5, 12.8, 15.2, 5 };
            var Response = calculatorService.Addition(ListOfValues);
            Assert.AreEqual(Response, 42.7);
        }

        [TestMethod()]
        public void AdditionTestScenario9()
        {
            ListOfValues = new List<double>() {  68.9, -25.896, -6547.354, 2687.987, -987.654862 };
            var Response = calculatorService.Addition(ListOfValues);
            Assert.AreEqual(Response, -4804.018);
        }

        [TestMethod()]
        public void AdditionTestScenario10()
        {
            ListOfValues = new List<double>() { 36, -3657, 654.48, -2779.6756, 2498.9745 };
            var Response = calculatorService.Addition(ListOfValues);
            Assert.AreEqual(Response, -3247.221);
        }
        #endregion


        #region SubtractionTestScenarios
        [TestMethod()]
        public void SubtractionTestScenario1()
        {
            ListOfValues = new List<double>() { };
            Assert.ThrowsException<NullReferenceException>(() => calculatorService.Subtraction(ListOfValues));
        }

        [TestMethod()]
        public void SubtractionTestScenario2()
        {
            ListOfValues = new List<double>() { 0, 0, 0, 0, 0, 0 };
            var Response = calculatorService.Subtraction(ListOfValues);
            Assert.AreEqual(Response, 0);
        }

        [TestMethod()]
        public void SubtractionTestScenario3()
        {
            ListOfValues = null;
            Assert.ThrowsException<NullReferenceException>(() => calculatorService.Subtraction(ListOfValues));
        }

        [TestMethod()]
        public void SubtractionTestScenario4()
        {
            ListOfValues = new List<double>() { -1, -2, -7, -6, -8 };
            var Response = calculatorService.Subtraction(ListOfValues);
            Assert.AreEqual(Response, 22);
        }

        [TestMethod()]
        public void SubtractionTestScenario5()
        {
            ListOfValues = new List<double>() { 7, 1, 2, 8, 5, 6 };
            var Response = calculatorService.Subtraction(ListOfValues);
            Assert.AreEqual(Response, -15);
        }

        [TestMethod()]
        public void SubtractionTestScenario6()
        {
            ListOfValues = new List<double>() { 15, 25, -23, 125, -298, 67 };
            var Response = calculatorService.Subtraction(ListOfValues);
            Assert.AreEqual(Response, 119);
        }

        [TestMethod()]
        public void SubtractionTestScenario7()
        {
            ListOfValues = new List<double>() { -2.5, -25.89, -36.987, -52.9987, -39687.324 };
            var Response = calculatorService.Subtraction(ListOfValues);
            Assert.AreEqual(Response, 39800.7);
        }

        [TestMethod()]
        public void SubtractionTestScenario8()
        {
            ListOfValues = new List<double>() { 7.2, 2.5, 12.8, 15.2, 5 };
            var Response = calculatorService.Subtraction(ListOfValues);
            Assert.AreEqual(Response, -28.3);
        }

        [TestMethod()]
        public void SubtractionTestScenario9()
        {
            ListOfValues = new List<double>() { 68.9, -25.896, -6547.354, 2687.987, -987.654862 };
            var Response = calculatorService.Subtraction(ListOfValues);
            Assert.AreEqual(Response, 4941.818);
        }

        [TestMethod()]
        public void SubtractionTestScenario10()
        {
            ListOfValues = new List<double>() { 36, -3657, 654.48, -2779.6756, 2498.9745 };
            var Response = calculatorService.Subtraction(ListOfValues);
            Assert.AreEqual(Response, 3319.221);
        }
        #endregion

        #region MultiplicationTestScenarios
        [TestMethod()]
        public void MultiplicationTestScenario1()
        {
            ListOfValues = new List<double>() { };
            Assert.ThrowsException<NullReferenceException>(() => calculatorService.Multiplication(ListOfValues));
        }

        [TestMethod()]
        public void MultiplicationTestScenario2()
        {
            ListOfValues = new List<double>() { 0, 0, 0, 0, 0, 0 };            
            var Response = calculatorService.Multiplication(ListOfValues);
            Assert.AreEqual(Response, 0);
        }

        [TestMethod()]
        public void MultiplicationTestScenario3()
        {
            ListOfValues = null;
            Assert.ThrowsException<NullReferenceException>(() => calculatorService.Multiplication(ListOfValues));
        }

        [TestMethod()]
        public void MultiplicationTestScenario4()
        {
            ListOfValues = new List<double>() { -1, -2, -7, -6, -8 };
            var Response = calculatorService.Multiplication(ListOfValues);
            Assert.AreEqual(Response, -672);
        }

        [TestMethod()]
        public void MultiplicationTestScenario5()
        {
            ListOfValues = new List<double>() { 7, 1, 2, 8, 5, 6 };
            var Response = calculatorService.Multiplication(ListOfValues);
            Assert.AreEqual(Response, 3360);
        }

        [TestMethod()]
        public void MultiplicationTestScenario6()
        {
            ListOfValues = new List<double>() { 15, 25, -23, 125, -298, 67 };
            var Response = calculatorService.Multiplication(ListOfValues);
            Assert.AreEqual(Response, 21525843750);
        }

        [TestMethod()]
        public void MultiplicationTestScenario7()
        {
            ListOfValues = new List<double>() { -2.5, -25.89, -36.987, -52.9987, -39687.324 };
            var Response = calculatorService.Multiplication(ListOfValues);
            Assert.AreEqual(Response, -5035448980.918 );
        }

        [TestMethod()]
        public void MultiplicationTestScenario8()
        {
            ListOfValues = new List<double>() { 7.2, 2.5, 12.8, 15.2, 5 };
            var Response = calculatorService.Multiplication(ListOfValues);
            Assert.AreEqual(Response, 17510.4);
        }

        [TestMethod()]
        public void MultiplicationTestScenario9()
        {
            ListOfValues = new List<double>() { 68.9, -25.896, -6547.354, 2687.987, -987.654862 };
            var Response = calculatorService.Multiplication(ListOfValues);
            Assert.AreEqual(Response, -31013451457110.117);
        }

        [TestMethod()]
        public void MultiplicationTestScenario10()
        {
            ListOfValues = new List<double>() { 36, -3657, 654.48, -2779.6756, 2498.9745 };
            var Response = calculatorService.Multiplication(ListOfValues);
            Assert.AreEqual(Response, 598521533707515.2);
        }
        #endregion

        #region DivisionTestScenarios
        [TestMethod()]
        public void DivisionTestScenario1()
        {
            ListOfValues = new List<double>() { }; 
            Assert.ThrowsException<NullReferenceException>(() => calculatorService.Division(ListOfValues));
        }

        [TestMethod()]
        public void DivisionTestScenario2()
        {
            ListOfValues = new List<double>() { 0, 0, 0, 0, 0, 0 };
            Assert.ThrowsException<DivideByZeroException>(() => calculatorService.Division(ListOfValues));
        }

        [TestMethod()]
        public void DivisionTestScenario3()
        {
            ListOfValues = null;
            Assert.ThrowsException<NullReferenceException>(() => calculatorService.Division(ListOfValues));
        }

        [TestMethod()]
        public void DivisionTestScenario4()
        {
            ListOfValues = new List<double>() { -1, -2, -7, -6, -8 };
            var Response = calculatorService.Division(ListOfValues);
            Assert.AreEqual(Response, -0.001);
        }

        [TestMethod()]
        public void DivisionTestScenario5()
        {
            ListOfValues = new List<double>() { 7, 1, 2, 8, 5, 6 };
            var Response = calculatorService.Division(ListOfValues);
            Assert.AreEqual(Response, 0.015);
        }

        [TestMethod()]
        public void DivisionTestScenario6()
        {
            ListOfValues = new List<double>() { 15, 25, -23, 125, -298, 67 };
            var Response = calculatorService.Division(ListOfValues);
            Assert.AreEqual(Response, 0);
        }

        [TestMethod()]
        public void DivisionTestScenario7()
        {
            ListOfValues = new List<double>() { -2.5, -25.89, -36.987, -52.9987, -39687.324 };
            var Response = calculatorService.Division(ListOfValues);
            Assert.AreEqual(Response, -0);
        }

        [TestMethod()]
        public void DivisionTestScenario8()
        {
            ListOfValues = new List<double>() { 7.2, 2.5, 12.8, 15.2, 5 };
            var Response = calculatorService.Division(ListOfValues);
            Assert.AreEqual(Response, 0.003);
        }

        [TestMethod()]
        public void DivisionTestScenario9()
        {
            ListOfValues = new List<double>() { 68.9, -25.896, -6547.354, 2687.987, -987.654862 };
            var Response = calculatorService.Division(ListOfValues);
            Assert.AreEqual(Response, 0);
        }

        [TestMethod()]
        public void DivisionTestScenario10()
        {
            ListOfValues = new List<double>() { 36, -3657, 654.48, -2779.6756, 2498.9745 };
            var Response = calculatorService.Division(ListOfValues);
            Assert.AreEqual(Response, 0);
        }
        #endregion
    }
}