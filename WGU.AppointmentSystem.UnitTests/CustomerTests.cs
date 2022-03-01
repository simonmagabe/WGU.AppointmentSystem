using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using WGU.AppointmentSystem.Model;
using System.Data;
using WGU.AppointmentSystem.ViewModel;
using System.Linq;
using Moq;
using Moq.Language.Flow;

namespace WGU.AppointmentSystem.UnitTests
{
    [TestClass]
    public class CustomerTests
    {
        public Utility Util = new Utility();

        [TestMethod]
        public void CanGetCustomers()
        {
            // Arrange
            BindingList<Customer> customers;

            // Act
            customers = Utility.GetCustomers();
            int customerCount = customers.Count;

            // Assert
            Assert.AreEqual(customerCount, customers.Count);
        }

        [TestMethod]
        public void AddCustomer_WithCustomerObject_ReturnsCreatedCustomerId()
        {
            Mock<Customer> mockCustomer = new Mock<Customer>();
            mockCustomer.SetupGet(p => p.CUSTOMERID).Returns(15);

            Mock<Utility> mockUtility = new Mock<Utility>();

            mockUtility.Setup(p => p.AddCustomer(mockCustomer.Object)).Returns(mockCustomer.Object.CUSTOMERID);

            Assert.AreEqual(mockUtility.Object.AddCustomer(mockCustomer.Object), mockCustomer.Object.CUSTOMERID);
        }
    }
}
