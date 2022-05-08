using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using NewsCMS.ApiHandler;

namespace NewsCMS.Controllers
{
    public class TagController : Controller
    {
        private readonly IApiHandler _apiHandler;
        private readonly IConfiguration _configuration;
        public TagController(IApiHandler apiHandler, IConfiguration configuration)
        {
            _apiHandler = apiHandler;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
