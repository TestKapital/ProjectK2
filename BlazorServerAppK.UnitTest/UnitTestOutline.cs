using NUnit.Framework;
using ProjectK.DataAccess.Repository;
using ProjectK.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace BlazorServerAppK.UnitTest
{
    public class Tests
    {
        private Bunit.TestContext testContext;
        [SetUp]
        public void Setup()
        {
            testContext = new Bunit.TestContext();
        }

        [TearDown]
        public void Teardown()
        {
            testContext.Dispose();
        }

        [Test]
        public void Test1()
        {
            // Arrange
            // Act
            // Assert

            Assert.Pass();

        }   

    }
}