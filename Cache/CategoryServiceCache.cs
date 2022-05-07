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
    public class CategoryServiceCache : ICategoryService
    {
        private const string CacheCategoryKey = "CategoryCache";
        private readonly IMemoryCache _memoryCache;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICategoryRepository _categoryService;
        public CategoryServiceCache(ICategoryRepository categoryService, IUnitOfWork unitOfWork, IMemoryCache memoryCache)
        {
            _categoryService = categoryService;
            _unitOfWork = unitOfWork;
            _memoryCache = memoryCache;
            if (!_memoryCache.TryGetValue(CacheCategoryKey, out _))
            {
                _memoryCache.Set(CacheCategoryKey, _categoryService.GetAll().ToList());
            }
        }

        public void Add(Category entity)
        {
            _categoryService.Add(entity);
            _unitOfWork.SaveChanges();
            Cache();
        }

        public void AddRange(IEnumerable<Category> entities)
        {
            _categoryService.AddRange(entities);
            _unitOfWork.SaveChanges();
            Cache();
        }

        public bool Any(Expression<Func<Category, bool>> prediceate)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category entity)
        {
            _categoryService.Delete(entity);
            _unitOfWork.SaveChanges();
            Cache();
        }

        public void DeleteRange(List<Category> entities)
        {
            _categoryService.DeleteRange(entities);
            _unitOfWork.SaveChanges();
            Cache();
        }

        public List<Category> GetAll()
        {
            return _memoryCache.Get<List<Category>>(CacheCategoryKey).ToList();
        }

        public List<Category> GetBy(Expression<Func<Category, bool>> predicate)
        {
            return _memoryCache.Get<List<Category>>(CacheCategoryKey).Where(predicate.Compile()).ToList();
        }

        public Category GetById(int id)
        {
            var Category = _memoryCache.Get<List<Category>>(CacheCategoryKey).FirstOrDefault(x => x.Id == id);
            if (Category == null)
            {
                throw new NullReferenceException();
            }
            return Category;
        }

        public void Update(Category entity)
        {
            _categoryService.Update(entity);
            _unitOfWork.SaveChanges();
            Cache();
        }
        public void Cache()
        {
            _memoryCache.Set(CacheCategoryKey, _categoryService.GetAll().ToList());
        }
    }
}
