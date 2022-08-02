using Xunit;
using WebAPITemplate.Controllers;
using WebAPITemplate.Models;
using Moq;
using Microsoft.Extensions.Logging;

namespace WebAPITemplate.Tests
{
    public class UnitTests
    {
        [Fact]
        public void Get_Positive()
        {
            // Arrange
            Mock<ILogger<GreetingController>> mockLogger = new Mock<ILogger<GreetingController>>();
            var controller = new GreetingController(mockLogger.Object);

            // Act
            var result = controller.Get();

            // Assert
            Assert.IsType<Greeting>(result);
        }
    }
}