using BlazorServerAppK.Controllers;
using BlazorServerAppK.Pages;
using BlazorServerAppK.Pages.Orders;
using Bunit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using NUnit.Framework;
using ProjectK.DataAccess.Data;
using ProjectK.DataAccess.Repository;
using ProjectK.DataAccess.Repository.IRepository;

namespace BlazorServerAppKUnitTest
{
    public class Tests
    {
        public Bunit.TestContext testContext;
        public Mock<IUnitOfWork> unitOfWork = new Mock<IUnitOfWork>();
        public Mock<EmailController> emailController = new Mock<EmailController>();

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
        public void OrderPage_CheckConditions_HtmlAndButtons()
        {

            var component1 = testContext.RenderComponent<Index>();
            Assert.IsTrue(component1.Markup.Contains("<h1>Hello World!</h1>"));

            var buttons = component1.FindAll("button");
            Assert.AreEqual(0, buttons.Count);

        }
    }
}