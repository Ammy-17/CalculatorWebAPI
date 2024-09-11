using CalculatorWebAPI.Models;
using CalculatorWebAPI.Servises.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorService _calculatorService;

        public CalculatorController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        [HttpPost("sum")]
        public async Task<IActionResult> SumAsync([FromBody] OperationModel model)
        {
            var response = await _calculatorService.SumAsync(model);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpPost("substract")]
        public async Task<IActionResult> SubstractAsync([FromBody] OperationModel model)
        {
            var response = await _calculatorService.SubstractAsync(model);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpPost("divide")]
        public async Task<IActionResult> DivideAsync([FromBody] OperationModel model)
        {
            var response = await _calculatorService.DivideAsync(model);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpPost("multiply")]
        public async Task<IActionResult> MultiplyAsync([FromBody] OperationModel model)
        {
            var response = await _calculatorService.MultiplyAsync(model);
            return StatusCode((int)response.StatusCode, response);
        }

    }
}
