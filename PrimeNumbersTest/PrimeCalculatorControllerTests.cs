using Microsoft.AspNetCore.Mvc;
using Moq;
using PrimeNumbersBE.Controllers;
using PrimeNumbersBE.Interfaces;
using BadRequestObjectResult = Microsoft.AspNetCore.Mvc.BadRequestObjectResult;

namespace PrimeNumbersTest;

public class PrimeCalculatorControllerTests
{
    private Mock<IPrimeCalculatorService> _primeCalculatorService;

    private PrimeNumberController _sut;

    [SetUp]
    public void SetUp()
    {
        _primeCalculatorService = new Mock<IPrimeCalculatorService>();

        _primeCalculatorService.Setup(x => x.GeneratePrimeNumbers(It.IsAny<int>())).Returns(new List<int>());

        _sut = new PrimeNumberController(_primeCalculatorService.Object);
    }

    [Test]
    public void GeneratePrimeNumbers_Is_Successfully_Called_When_PrimeNumbersUpTo_Is_Between_1_And_100()
    {
        //Arrange

        //Act

        var result = _sut.GeneratePrimeNumbers(5);


        _primeCalculatorService.Verify(x => x.GeneratePrimeNumbers(It.IsAny<int>()), Times.Once);
        Assert.AreEqual(typeof(OkObjectResult), result.GetType());
    }

    [Test]
    public void GeneratePrimeNumbers_Is_Not_Called_When_PrimeNumbersUpTo_Is_Not_Between_1_And_100()
    {
        //Arrange

        //Act

        var result = _sut.GeneratePrimeNumbers(101);

        _primeCalculatorService.Verify(x => x.GeneratePrimeNumbers(It.IsAny<int>()), Times.Never);
        Assert.AreEqual(typeof(BadRequestObjectResult), result.GetType());
    }
}
