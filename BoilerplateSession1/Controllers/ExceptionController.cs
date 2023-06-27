
using BoilerplateSession1.Models;
using Microsoft.AspNetCore.Mvc;

namespace BoilerplateSession1.Controllers
{
    [Route("/error")]
    public class ExceptionController : Controller
    {
        public IActionResult ErrorMessageModel()
        {
            ErrorMessageModel e = new ErrorMessageModel();
            e.errMessage = "Hello, I'm Error!";
            return View(e);
        }
    }
}
