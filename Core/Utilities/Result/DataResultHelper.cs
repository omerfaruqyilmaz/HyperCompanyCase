using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HyperCompanyCase.Core.Utilities.Result
{
    public static class DataResultHelper
    {
        public static IActionResult HttpResponse(this DataResult dataResult)
        {
            HttpStatusCode statusCode = HttpStatusCode.OK;

            return new ObjectResult(dataResult)
            {
                StatusCode = (int?)statusCode
            };
        }
    }
}
