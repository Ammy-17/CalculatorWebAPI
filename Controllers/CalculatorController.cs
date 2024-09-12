using CalculatorWebAPI.Models;
using CalculatorWebAPI.Servises.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorWebAPI.Controllers
{
    /// <summary>
    /// Controlador que adminsitra el servicio de calculadora.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        /// <summary>
        /// Servicio de calculadora.
        /// </summary>
        private readonly ICalculatorService _calculatorService;

        public CalculatorController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        /// <summary>
        /// Endpoint para realizar la suma de dos números.
        /// </summary>
        /// <param name="model">Modelo que contiene los dos números.</param>
        /// <returns>Tarea que retorna la respuesta de la petición.</returns>
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
