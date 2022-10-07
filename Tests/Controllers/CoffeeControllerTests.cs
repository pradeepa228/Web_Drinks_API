using Microsoft.AspNetCore.Mvc;
using Web_Drinks_API.Controllers;
using Web_Drinks_API.Models;
using NUnit.Framework;
using FluentAssertions;
using Microsoft.AspNetCore.Routing;
namespace Web_Drinks_API.Tests.Controllers
{
    public class CoffeeControllerTests
    {
        private CoffeeController _controller;
        [SetUp]
        public void Setup()
        {
            _controller = new CoffeeController();
        }
        [Test]
        public void TestGetCoffee()
        {
            _controller.GetCoffeeLover().Should().Be("I like coffee!");
        }
        [Test]
        public void Test_Get_Coffee_By_Name()
        {
            var result = _controller.Get("frappe");
            result.Name.Should().Be("frappe");
            result.Id.Should().Be(7);
        }
        [Test]
        public void Test_Get_Coffee_Without_Input()
        {
            var result = _controller.Get(null);
            result.Name.Should().Be("latte");
            result.Id.Should().Be(-1);
        }
    }

}
