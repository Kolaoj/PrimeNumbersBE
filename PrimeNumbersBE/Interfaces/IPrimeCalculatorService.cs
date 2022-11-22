namespace PrimeNumbersBE.Interfaces;

public interface IPrimeCalculatorService
{
    public List<int> GeneratePrimeNumbers(int primeNumbersUpTo);
}