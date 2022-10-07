using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using Web_Drinks_API.Controllers;
using FluentAssertions;

namespace Web_Drinks_API.Tests.Controllers
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
