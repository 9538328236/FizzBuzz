
using FizzBuzz.API.Controllers;
using FizzBuzz.API.Interfaces;
using FizzBuzz.API.Model;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace FizzBuzzAPI.Test.Controller
{
    internal class FizzBuzzControllerTest
    {

        private Mock<ICodingTestService> _mockCodingCourseService;

        [SetUp]
        public void Setup()
        {
            _mockCodingCourseService = new Mock<ICodingTestService>();
        }


        [Test]
        public async Task TestFizzBuzzPostiveScenario()
        {
            var expectedResults = new List<CodingTest>()
            {
                new CodingTest { UserInput = "3", FinalResult = "Fizz" },
                new CodingTest { UserInput = "5", FinalResult = "Buzz" },
                new CodingTest { UserInput = "15", FinalResult = "FizzBuzz" }
            };
            _mockCodingCourseService.Setup(s => s.DisplayResult(It.IsAny<string[]>()))
              .Returns(Task.FromResult(expectedResults));
            var controller = new CodingCourseController(_mockCodingCourseService.Object);
           
            var inputs = new string[] { "3", "5", "15" };
            var response = await controller.Post(inputs);
            
            var okResult = response as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.AreEqual(expectedResults, okResult.Value);
        }


        [Test]
        public async Task TestFizzBuzzNegativeScenario()
        {
            var expectedResults = new List<CodingTest>()
            {
                new CodingTest { UserInput = "", FinalResult = "Invalid Item" },
                new CodingTest { UserInput = "A", FinalResult = "Invalid Item" },
                new CodingTest { UserInput = "29", FinalResult = "", DivisionPerfomed = new List<string>{ "Divided 29 by 3", "Divided 29 by 5" } }
            };
            _mockCodingCourseService.Setup(s => s.DisplayResult(It.IsAny<string[]>()))
              .Returns(Task.FromResult(expectedResults));
            var controller = new CodingCourseController(_mockCodingCourseService.Object);

            var inputs = new string[] { "", "A", "29" };
            var response = await controller.Post(inputs);

            var okResult = response as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.AreEqual(expectedResults, okResult.Value);
        }
    }
}
