using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using PrimeNumbersBE.Interfaces;

namespace PrimeNumbersBE.Controllers;

public class PrimeNumberController : ControllerBase
{

    private readonly IPrimeCalculatorService _primeCalculatorService;

    public PrimeNumberController(IPrimeCalculatorService primeCalculatorService)
    {
        _primeCalculatorService = primeCalculatorService;
    }

    [HttpGet]
    [EnableCors]
    [Route("GeneratePrimeNumbers/{primeNumbersUpTo}")]
    public IActionResult GeneratePrimeNumbers(int primeNumbersUpTo)
    {
        if (primeNumbersUpTo is <= 1 or >= 100)
        {
            return BadRequest("Please input a number between 1 and 100");
        }

        var primeNumbers = _primeCalculatorService.GeneratePrimeNumbers(primeNumbersUpTo);

        return Ok(primeNumbers); 
    }
}