using API.Constants;
using AutoMapper;
using DTO;
using DTO.AddOrUpdateDto;
using DTO.ListDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.IService;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly INewsService _newsService;

        public NewsController(INewsService newsService, IMapper mapper)
        {
            _newsService = newsService;
            _mapper = mapper;
        }
        [HttpGet("ListNews")]
        public JsonResult ListNews()
        {
            var news = _newsService.GetAllNews();
            var newsMapper = _mapper.Map<List<ListNewsDto>>(news);
            var result = new ResultDTO<ListNewsDto>()
            {
                DataList = newsMapper,
                Message = Message.NewsListed,
                Status = true
            };
            return Json(result);
        }
        [HttpPost("AddNews")]
        public JsonResult AddNews(AddNewsDTO newsDTO)
        {
            _newsService.AddNews(newsDTO);
            var result = new ResultDTO<ListNewsDto>()
            {
                Message = Message.NewsAdded,
                Status = true
            };
            return  Json(result);
        }
    }
}
