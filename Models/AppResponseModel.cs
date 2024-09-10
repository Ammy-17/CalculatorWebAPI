using System.Net;

namespace CalculatorWebAPI.Models
{
    /// <summary>
    /// Modelo de respuesta de una peticion
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    public class AppResponseModel<TValue>
    {
        /// <summary>
        /// true si sì funcionò y false si hubo un error
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// codigo de estado de respuesta de la peticion
        /// </summary>
        public HttpStatusCode StatusCode { get; set; }

        /// <summary>
        /// Valor de la respuesta de la solicitud 
        /// </summary>
        public TValue? Value { get; set; }

    }
}
