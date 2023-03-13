using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstmarketing
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsmarketing Anmarketing = new clsmarketing();
            //test to see that it exists
            Assert.IsNotNull(Anmarketing);
        }
     

        
    }
}
