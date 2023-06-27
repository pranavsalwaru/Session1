using BoilerplateSession1.Services;
using Microsoft.AspNetCore.Mvc;

namespace BoilerplateSession1.Controllers
{
    public class SessionController : Controller
    {
        readonly IErrorService _errorService;
        public SessionController(IErrorService errorService)
        {
            _errorService = errorService;
        }
        public IActionResult Index()
        {
            string Name = _errorService.getEnvironmentData();
            //Name = null;
            return Ok(Name);
        }

        [HttpGet]
        public IActionResult IndexError()
        {

            string Name = _errorService.getAppSettingData();
            return Ok(Name);

        }
    }
}
