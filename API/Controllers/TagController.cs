﻿using API.Constants;
using API.Filters;
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
    public class TagController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ITagService _tagService;
        public TagController(IMapper mapper, ITagService tagService)
        {
            _mapper = mapper;
            _tagService = tagService;
        }
        [HttpGet("GetAllTag")]
        public JsonResult GetAllTags()
        {
            var Tags = _tagService.GetAll();
            var TagMapping = _mapper.Map<List<ListTagDto>>(Tags);
            var result = new ResultDTO<ListTagDto>()
            {
                DataList = TagMapping,
                Message = Message.TagListed,
                Status = true
            };
            return Json(result);
        }
        [HttpPost("AddTag")]
        public JsonResult AddTag(AddTagDTO addTag)
        {
            var tagMapper=_mapper.Map<Tag>(addTag);
            _tagService.Add(tagMapper);
            var result = new ResultDTO<ListTagDto>()
            {
                Message = Message.TagAdded,
                Status = true
            };
            return Json(result);
        }
    }
}
