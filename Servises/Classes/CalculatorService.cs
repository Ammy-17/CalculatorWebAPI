using CalculatorWebAPI.Models;
using CalculatorWebAPI.Servises.Interfaces;
using System.Net;

namespace CalculatorWebAPI.Servises.Classes
{
    internal sealed class CalculatorService : ICalculatorService
    {
        public Task<AppResponseModel<float?>> DivideAsync(OperationModel operation)
        {
            if (operation.Num2 is 0)
            {
                var errorResponse = new AppResponseModel<float?>
                {
                    IsSuccess = false,
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    Value = null
                };
                return Task.FromResult(errorResponse);
            }
            var response = new AppResponseModel<float?>
            {
                IsSuccess = true,
                StatusCode = System.Net.HttpStatusCode.OK,
                Value = operation.Num1 / operation.Num2
            };
            return Task.FromResult(response);
        }

        public Task<AppResponseModel<float>> MultiplyAsync(OperationModel operation)
        {

            var response = new AppResponseModel<float>()
            {
                IsSuccess = true,
                StatusCode = System.Net.HttpStatusCode.OK,
                Value = operation.Num1 * operation.Num2
            };
                return Task.FromResult(response);

        }

        public Task<AppResponseModel<float>> SubstractAsync(OperationModel operation)
        {

            var response = new AppResponseModel<float>()
            {
                IsSuccess = true,
                StatusCode = System.Net.HttpStatusCode.OK,
                Value = operation.Num1 - operation.Num2
            };
                return Task.FromResult(response);
        }

        public Task<AppResponseModel<float>> SumAsync(OperationModel operation)
        {
            var response = new AppResponseModel<float>()
            {
                IsSuccess = true,
                StatusCode = System.Net.HttpStatusCode.OK,
                Value = operation.Num1 + operation.Num2
            };
            return Task.FromResult(response);
        }
    }
}
