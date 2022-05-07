using DTO;
using DTO.AddOrUpdateDto;
using DTO.ListDto;
using Microsoft.AspNetCore.Mvc;
using NewsCMS.ApiHandler;
using NewsCMS.ApiUrl;
using Newtonsoft.Json;
using System.Diagnostics;

namespace NewsCMS.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IApiHandler _apiHandler;
        private readonly IConfiguration _configuration;
        public CategoryController(IApiHandler apiHandler, IConfiguration configuration)
        {
            _apiHandler = apiHandler;
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            var url = _configuration["ApiUrl"] + "" + ReuqestUrl.ListCategory;
            var model = JsonConvert.DeserializeObject<ResultDTO<ListCategoryDto>>(_apiHandler.GetAPI(url));
            return View(model.DataList);
        }
        public JsonResult AddCategory(string Name)
        {
            var url = _configuration["ApiUrl"] + "" + ReuqestUrl.AddCategory;
            AddCategoryDTO addCategory = new AddCategoryDTO()
            {
                Name = Name,
                LanguageId = 1,
                UpdateDate = DateTime.Now,
            };
            var model = JsonConvert.DeserializeObject<ResultDTO<ListCategoryDto>>(_apiHandler.PostWithModel(addCategory, url));
            return Json(model.Data);
        }
        public JsonResult ChangeCategoryStatus(int id)
        {
            var url = _configuration["ApiUrl"] + "" + ReuqestUrl.GetByCategory+id;
            var UpdateUrl = _configuration["ApiUrl"] + "" + ReuqestUrl.UpdateCategory;
            var model = JsonConvert.DeserializeObject<ResultDTO<ListCategoryDto>>(_apiHandler.GetAPI(url));
            var active = model.Data.IsActive == true ? false : true;
            AddCategoryDTO addCategory = new AddCategoryDTO()
            {
                Id = id,
                UpdateDate = DateTime.Now,
                IsActive = active,
                Name = model.Data.Name,
                LanguageId = model.Data.LanguageId
            };
            var Post = _apiHandler.PostWithModel(addCategory, UpdateUrl);
            return Json(1);
        }
        public JsonResult GetCategory(int id)
        {
            var url = _configuration["ApiUrl"] + "" + ReuqestUrl.GetByCategory + id;
            var model = JsonConvert.DeserializeObject<ResultDTO<ListCategoryDto>>(_apiHandler.GetAPI(url));
            return Json(model.Data);
        }
    }
}
