using HelloMVC.Controllers;
using HelloMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HelloMVC.Tests
{
    public class GreetControllerTests
    {
        [Fact]
        public void Index_Returns_ViewResult()
        {
        var controller = new GreetController();

        var result = controller.Index("ThisIsAString");

        Assert.IsType<ViewResult>(result);

        }

        [Fact]
        public void Index_Passes_GreetingModel_To_View()
        {
            var controller = new GreetController();

            var result = controller.Index("ThisIsAString");

            Assert.IsType<GreetingModel>(result.Model);
        }
    }
}
