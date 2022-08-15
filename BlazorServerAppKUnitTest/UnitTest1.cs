using BlazorServerAppK.Pages.Orders;
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
            testContext.Services.AddScoped(x => unitOfWork.Object);
            var component = testContext.RenderComponent<OrderPage>();
            //Assert.IsTrue(component.Markup.Contains(""));
        }
    }
}