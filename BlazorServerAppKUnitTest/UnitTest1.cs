using BlazorServerAppK.Controllers;
using BlazorServerAppK.Pages.Orders;
using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using NUnit.Framework;
using ProjectK.DataAccess.Repository.IRepository;

namespace BlazorServerAppKUnitTest
{
    public class Tests
    {
        private Bunit.TestContext testContext;
        private Mock<IUnitOfWork> unitOfWork;
        private Mock<EmailController> emailController;

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
            testContext.Services.AddScoped(x => unitOfWork.Object);
            testContext.Services.AddScoped(x => emailController.Object);

            var component = testContext.RenderComponent<OrderPage>();
            Assert.IsTrue(component.Markup.Contains("<label>Order Date</label>"));
            var buttons = component.FindAll("button");
            Assert.Equals(4, buttons.Count);

        }
    }
}