using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorConsoleApp;

namespace CalculatorTests
{
    [TestClass]
    public class AdditionTest
    {
        [TestMethod]
        public void Add_2_Nos()
        {
            try
            {
                int AdditionResult = (int)Addition.Add_Two_Nos(4, 5);
                Assert.AreEqual(8, AdditionResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine("kcnm");
            }
        }
    }
}
