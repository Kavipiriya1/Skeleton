using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        //create an instance of the class we want to create
            clsSales AnSales = new clsSales();
        //test to see that it exists 
        Assert.IsNotNull(AnSales);
        }
}
}
