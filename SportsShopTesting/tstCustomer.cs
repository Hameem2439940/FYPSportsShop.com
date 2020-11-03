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
            customer customer = new customer();
            Assert.IsNotNull(customer);
        }

        [TestMethod]

        public void CustomerIDOK()
        {
            customer customer = new customer();
            Int32 TestData = 1;
            customer.CustomerID = TestData;
            Assert.AreEqual(customer.CustomerID, TestData);
        }

        [TestMethod]

        public void UsernameOK()
        {
            customer customer = new customer();
            string TestData = "ReyMysterio619";
            customer.Username = TestData;
            Assert.AreEqual(customer.Username, TestData);
        }

        [TestMethod]

        public void VerifiedAccountOK()
        {
            customer customer = new customer();
            Boolean TestData = true;
            customer.VerifiedAccount = TestData;
            Assert.AreEqual(customer.VerifiedAccount, TestData);
        }

        [TestMethod]

        public void EmailAddressOK()
        {
            customer customer = new customer();
            string TestData = "reymysterio619@gmail.com";
            customer.EmailAddress = TestData;
            Assert.AreEqual(customer.EmailAddress, TestData);
        }

        [TestMethod]

        public void PostcodeOK()
        {
            customer customer = new customer();
            string TestData = "LE1 1ER";
            customer.Postcode = TestData;
            Assert.AreEqual(customer.Postcode, TestData);
        }
    }
}
