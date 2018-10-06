using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BookManagement.Controllers {
    public class ErrorController : Controller {
        // GET: /<controller>/

        [HttpGet ("/ErrorCode/{statusCode}")]
        public IActionResult Index (int statusCode)
        {
            return View (statusCode);
        }
    }
}