using System;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using knight_moves_api.Controllers;

namespace knight_moves_api.Tests
{
    public class ControllerTests
    {
        [Fact]
        public void VerifyIndexViewType()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index();

            // Assert
            Assert.IsType<JsonResult>(result);
        }
    }
}
