using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using WGU.AppointmentSystem.Model;
using System.Data;

namespace WGU.AppointmentSystem.UnitTests
{
    [TestClass]
    public class CustomerTests
    {
        

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
    }
}
