using AutoMapper;
using Core.Repository;
using Core.UnitOfWork;
using DTO.AddOrUpdateDto;
using Entity;
using Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class NewsService : Service<News>, INewsService
    {
        private readonly IMapper _mapper;
        private readonly INewsRepository _newsRepository;
        private readonly INewsCategoryRepository _newsCategoryRepository;
        private readonly INewsTagRepository _newsTagRepository;
        private readonly IUnitOfWork _unitOfWork;
        public NewsService(IUnitOfWork unitOfWork, IRepository<News> repository, IMapper mapper, INewsRepository newsRepository, INewsCategoryRepository newsCategoryRepository, INewsTagRepository newsTagRepository) : base(unitOfWork, repository)
        {
            _mapper = mapper;
            _newsRepository = newsRepository;
            _newsCategoryRepository = newsCategoryRepository;
            _newsTagRepository = newsTagRepository;
            _unitOfWork = unitOfWork;
        }

        public void AddNews(AddNewsDTO addNews)
        {
            var NewsMapper = _mapper.Map<News>(addNews);
            _newsRepository.Add(NewsMapper);
            _unitOfWork.SaveChanges();
            foreach (var item in addNews.CategoryId)
            {
                AddNewsCategoryDTO addNewsCategory = new AddNewsCategoryDTO()
                {
                    CategoryId = item,
                    NewsId = NewsMapper.Id,
                };
                var CategoryMap = _mapper.Map<NewsCategory>(addNewsCategory);
                _newsCategoryRepository.Add(CategoryMap);
                _unitOfWork.SaveChanges();
            }
            foreach (var item in addNews.TagId)
            {
                AddNewsTagDto newsTagDto = new AddNewsTagDto()
                {
                    NewsId = NewsMapper.Id,
                    TagId = item
                };
                var TagMap = _mapper.Map<NewsTag>(newsTagDto);
                _newsTagRepository.Add(TagMap);
                _unitOfWork.SaveChanges();
            }
        }

        public List<News> GetAllNews()
        {
            return _newsRepository.GetAllNews().ToList();
        }
    }
}
