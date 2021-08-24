using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.Models;

namespace TrainingCenterCRM.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            var error = new ErrorModel { StatusCode = statusCode };
            switch (statusCode)
            {
                case 401:
                    error.Message = "Access to this resource is denied.";
                    break;
                case 404:
                    error.Message = "Sorry, that page doesn't exist.";
                    break;
                case 500:
                    error.Message = "Internal Server Error.";
                    break;
            }

            return View("HttpStatusCodeHandler", error);
        }
    }
}
