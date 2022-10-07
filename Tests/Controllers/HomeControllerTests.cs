using API_Interactive_Lab_1.Controllers;
using FluentAssertions;
using NUnit.Framework;
namespace API_Interactive_Lab_1.Tests
{
    public class HomeControllerTests
    {
        private HomeController _controller;
        [SetUp]
        public void Setup()
        {
            _controller = new HomeController();
        }
        [Test]
        public void TestGetHome()
        {
            _controller.Get().Should().Be("Welcome to the Drinks API!");
        }
    }
}
