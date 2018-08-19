using System;
using System.Collections.Generic;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using knight_moves_api.Controllers;
using knight_moves_api.Models;
using knight_moves_api.Services;

namespace knight_moves_api.Tests
{
    public class ControllerTests
    {
        [Fact]
        public void VerifyIndexViewType()
        {
            // Arrange
            var service = new MoveService();
            var controller = new HomeController(service);

            // Act
            var result = controller.Index();

            // Assert
            Assert.IsType<JsonResult>(result);
        }

        [Fact]
        public void VerifyIndexViewContent()
        {
            // Arrange
            var service = new MoveService();
            var controller = new HomeController(service);

            // Act
            var result = Assert.IsType<JsonResult>(controller.Index());

            // Assert
            Assert.Equal("Hello World!", result.Value.ToString());
        }

        [Fact]
        public void VerifyKnightItsCreated()
        {
            var service = new MoveService();
            var controller = new HomeController(service);
            var result = Assert.IsType<JsonResult>(controller.Knight("d", 4));
            Assert.IsType<Knight>(result.Value);
        }

        [Fact]
        public void VerifyKnightHasPossiblesMoves()
        {
            var service = new MoveService();
            var controller = new HomeController(service);
            var result = Assert.IsType<JsonResult>(controller.Knight("d", 4));
            var model = Assert.IsType<Knight>(result.Value);
            Assert.IsType<List<Moves>>(model.PossibleMoves);
        }

        [Fact]
        public void VerifyKnightHasEightMoves()
        {
            var coordx = 4;
            var coordy = "d";
            var service = new MoveService();
            var controller = new HomeController(service);
            var result = Assert.IsType<JsonResult>(controller.Knight(coordy, coordx));
            var model = Assert.IsType<Knight>(result.Value);
            var possibleMoves = Assert.IsType<List<Moves>>(model.PossibleMoves);
            Assert.Equal(8, possibleMoves.Count);
        }

        public void VerifyKnightHasTwoMoves()
        {
            var coordx = 1;
            var coordy = "h";
            var service = new MoveService();
            var controller = new HomeController(service);
            var result = Assert.IsType<JsonResult>(controller.Knight(coordy, coordx));
            var model = Assert.IsType<Knight>(result.Value);
            var possibleMoves = Assert.IsType<List<Moves>>(model.PossibleMoves);
            Assert.Equal(8, possibleMoves.Count);
        }
    }
}
