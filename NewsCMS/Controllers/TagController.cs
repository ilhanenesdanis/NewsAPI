using DTO;
using DTO.ListDto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using NewsCMS.ApiHandler;
using NewsCMS.ApiUrl;
using Newtonsoft.Json;

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
            var url = _configuration["ApiUrl"] + "" + ReuqestUrl.GetAllTag;
            var model = JsonConvert.DeserializeObject<ResultDTO<ListTagDto>>(_apiHandler.GetAPI(url));
            return View(model.DataList);
        }
    }
}
