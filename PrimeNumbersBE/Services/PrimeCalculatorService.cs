using PrimeNumbersBE.Interfaces;

namespace PrimeNumbersBE.Services;

public class PrimeCalculatorService : IPrimeCalculatorService
{
    public List<int> GeneratePrimeNumbers(int primeNumbersUpTo)
    {
        switch (primeNumbersUpTo)
        {
            case <= 1:
                return new List<int>();
            case 2:
                return new List<int> { 2 };
            case 3:
                return new List<int> { 2, 3 };
        }

        var primeNumbers = new List<int> { 2, 3 };

        for (var i = 5; i < primeNumbersUpTo; i++)
        {
            if (i % 2 == 0 || (i != 5 && i % 5 == 0))
            {
                continue;
            }

            var sqrt = Math.Sqrt(i);

            for (var j = 2; j <= sqrt; j++)
            {
                if (i % j == 0)
                {
                    break;
                }

                if (sqrt - j < 1)
                {
                    primeNumbers.Add(i);
                }
            }
        }

        return primeNumbers;
    }
}