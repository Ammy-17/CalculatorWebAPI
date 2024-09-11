using CalculatorWebAPI.Models;

namespace CalculatorWebAPI.Servises.Interfaces
{
    /// <summary>
    /// Interfaz que define los mètodos de una calculadora.
    /// </summary>
    public interface ICalculatorService
    {
        /// <summary>
        /// Mètodo para realizar la suma de dos nùmeros.
        /// </summary>
        /// <param name="operation">Módelo de operaciòn.</param>
        /// <returns>Tarea que retorna la respuesta de la peticiòn.</returns>
        Task<AppResponseModel<float>> SumAsync(OperationModel operation);

        /// <summary>
        /// Método para realizar la resta de dos números.
        /// </summary>
        /// <param name="operation">Módelo de operacion </param>
        /// <returns>Tarea que retorna la respuesta de la petición. </returns>
        Task<AppResponseModel<float>> SubstractAsync(OperationModel operation);

        /// <summary>
        /// Método para realizar multiplicacion de dos numeros.
        /// </summary>
        /// <param name="operation">Módelo de operación. </param>
        /// <returns>Tarea que retorna la respuesta de la petición.</returns>
        Task<AppResponseModel<float>> MultiplyAsync(OperationModel operation);

        /// <summary>
        /// Método para realizar una división de dos números.
        /// </summary>
        /// <param name="operation">Módelo de operación. </param>
        /// <returns>Tarea que retorna la respuesta de la petición.</returns>
        Task<AppResponseModel<float?>> DivideAsync(OperationModel operation);
    }


}

