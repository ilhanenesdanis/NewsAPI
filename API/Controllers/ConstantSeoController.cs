using API.Constants;
using AutoMapper;
using DTO;
using DTO.AddOrUpdateDto;
using DTO.ListDto;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.IService;
using System.Diagnostics;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConstantSeoController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IConstantSeoService _constant;

        public ConstantSeoController(IMapper mapper, IConstantSeoService constant)
        {
            _mapper = mapper;
            _constant = constant;
        }
        [HttpGet("ListConstant")]
        public JsonResult ListConstant()
        {
            var constant = _constant.GetAll();
            var mapper = _mapper.Map<List<ListConstantSeoDto>>(constant);
            var result = new ResultDTO<ListConstantSeoDto>()
            {
                DataList = mapper,
                Message = Message.ConstantSeoListed,
                Status = true
            };
            return Json(result);
        }
        [HttpPost("AddConstantSeo")]
        public JsonResult AddConstantSeo(AddConstantSeoDTO addConstant)
        {
            var mapper = _mapper.Map<ConstantSeo>(addConstant);
            _constant.Add(mapper);
            var result = new ResultDTO<ListConstantSeoDto>()
            {
                Message = Message.ConstantSeoAdded,
                Status = true
            };
            return Json(result);
        }
        [HttpPut("UpdateConstantSeo")]
        public JsonResult UpdateConstantSeo(AddConstantSeoDTO addConstantSeo)
        {
            var mapper=_mapper.Map<ConstantSeo>(addConstantSeo);
            _constant.Update(mapper);
            var result = new ResultDTO<ListConstantSeoDto>()
            {
                Message = Message.ConstantSeoUpdated,
                Status = true
            };
            return Json(result);
        }
    }
}
