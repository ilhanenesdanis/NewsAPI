using API.Constants;
using AutoMapper;
using DTO;
using DTO.AddOrUpdateDto;
using DTO.ListDto;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.IService;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICategoryService _categoryService;
        public CategoryController(IMapper mapper, ICategoryService categoryService)
        {
            _mapper = mapper;
            _categoryService = categoryService;
        }
        [HttpGet("ListCategory")]
        public JsonResult ListCategory()
        {
            var category = _categoryService.GetAll();
            var categoryMapping = _mapper.Map<List<ListCategoryDto>>(category);
            var result = new ResultDTO<ListCategoryDto>()
            {
                DataList = categoryMapping,
                Message = Message.CategoryListed,
                Status = true
            };
            return Json(result);
        }
        [HttpPost("AddCategory")]
        public JsonResult AddNewCategory(AddCategoryDTO categoryDTO)
        {
            var CategoryMapper = _mapper.Map<Category>(categoryDTO);
            _categoryService.Add(CategoryMapper);
            var result = new ResultDTO<Category>()
            {
                Data=CategoryMapper,
                Message = Message.CategoryAdded,
                Status = true
            };
            return Json(result);
        }
        [HttpPost("UpdateCategory")]
        public JsonResult UpdateCategory(AddCategoryDTO addCategory)
        {
            var categoryMapper = _mapper.Map<Category>(addCategory);
            _categoryService.Update(categoryMapper);
            var result = new ResultDTO<Category>()
            {
                Data = categoryMapper,
                Message = Message.CategoryUpdated,
                Status = true
            };
            return Json(result);
        }
        [HttpGet("GetByCategoryId/{id}")]
        public JsonResult GetByCategory(int id)
        {
            var category=_categoryService.GetById(id);
            var categoryMapper= _mapper.Map<Category>(category);
            var result = new ResultDTO<Category>()
            {
                Data = categoryMapper,
                Message = Message.CategoryListed,
                Status = true
            };
            return Json(result);
        }
    }
}
