using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SportsShopTesting
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer customer = new clsCustomer();
            Assert.IsNotNull(customer);
        }
    }
}
