using Core.Repository;
using Core.UnitOfWork;
using Entity;
using Microsoft.Extensions.Caching.Memory;
using Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cache
{
    public class TagServiceCaching : ITagService
    {
        private const string CacheTagKey = "TacCache";
        private readonly IMemoryCache _memoryCache;
        private readonly ITagRepository _tagRepository;
        private readonly IUnitOfWork _unitOfWork;

        public TagServiceCaching(IUnitOfWork unitOfWork, ITagRepository tagRepository, IMemoryCache memoryCache)
        {
            _unitOfWork = unitOfWork;
            _tagRepository = tagRepository;
            _memoryCache = memoryCache;

            if (!_memoryCache.TryGetValue(CacheTagKey, out _))
            {
                _memoryCache.Set(CacheTagKey, _tagRepository.GetAll().ToList());
            }
        }

        public void Add(Tag entity)
        {
            _tagRepository.Add(entity);
            _unitOfWork.SaveChanges();
            CacheAllTag();
        }

        public void AddRange(IEnumerable<Tag> entities)
        {
            _tagRepository.AddRange(entities);
            _unitOfWork.SaveChanges();
            CacheAllTag();
        }

        public bool Any(Expression<Func<Tag, bool>> prediceate)
        {
            throw new NotImplementedException();
        }

        public void Delete(Tag entity)
        {
            _tagRepository.Delete(entity);
            _unitOfWork.SaveChanges();
            CacheAllTag();
        }

        public void DeleteRange(List<Tag> entities)
        {
            _tagRepository.DeleteRange(entities);
            _unitOfWork.SaveChanges();
            CacheAllTag();
        }

        public List<Tag> GetAll()
        {
            return _memoryCache.Get<List<Tag>>(CacheTagKey).ToList();
        }

        public List<Tag> GetBy(Expression<Func<Tag, bool>> predicate)
        {
           return _memoryCache.Get<List<Tag>>(CacheTagKey).Where(predicate.Compile()).ToList();
        }

        public Tag GetById(int id)
        {
            var tag = _memoryCache.Get<List<Tag>>(CacheTagKey).FirstOrDefault(x => x.Id == id);
            if (tag == null)
            {
                throw new  NullReferenceException();
            }
            return tag;
        }

        public void Update(Tag entity)
        {
            _tagRepository.Update(entity);
            _unitOfWork.SaveChanges();
            CacheAllTag();
        }
        public void CacheAllTag()
        {
            _memoryCache.Set(CacheTagKey, _tagRepository.GetAll().ToList());
        }
    }
}
