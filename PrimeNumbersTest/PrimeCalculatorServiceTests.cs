using PrimeNumbersBE.Services;

namespace PrimeNumbersTest;

public class PrimeCalculatorServiceTests
{
    private PrimeCalculatorService _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new PrimeCalculatorService();
    }

    [Test]
    public void GeneratePrimeNumbers_Returns_CorrectValues_When_Given_A_Number_Bigger_Than_3()
    {
        //Arrange

        //Act

        var primeNumbers = _sut.GeneratePrimeNumbers(10);

        //Assert

        Assert.AreEqual(4, primeNumbers.Count);
        Assert.AreEqual(2, primeNumbers[0]);
        Assert.AreEqual(3, primeNumbers[1]);
        Assert.AreEqual(5, primeNumbers[2]);
        Assert.AreEqual(7, primeNumbers[3]);
    }


    [Test]
    public void GeneratePrimeNumbers_Returns_Nothing_When_Given_1()
    {
        //Arrange

        //Act

        var primeNumbers = _sut.GeneratePrimeNumbers(1);

        //Assert

        Assert.AreEqual(0, primeNumbers.Count);
    }

 
    [Test]
    public void GeneratePrimeNumbers_Returns_Correct_Values_When_Given_A_Number_Between_1_And_4()
    {
        //Arrange

        //Act

        var primeNumbers = _sut.GeneratePrimeNumbers(3);

        //Assert

        Assert.AreEqual(2, primeNumbers.Count);
        Assert.AreEqual(2, primeNumbers[0]);
        Assert.AreEqual(3, primeNumbers[1]);
    }
}
