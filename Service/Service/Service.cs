using Core.Repository;
using Core.Service;
using Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly IRepository<T> _repository;
        private readonly IUnitOfWork _unitOfWork;
        public Service(IUnitOfWork unitOfWork, IRepository<T> repository)
        {

            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public void Add(T entity)
        {
            _repository.Add(entity);
            _unitOfWork.SaveChanges();
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _repository.AddRange(entities);
            _unitOfWork.SaveChanges();
        }

        public bool Any(Expression<Func<T, bool>> prediceate)
        {
            return _repository.Any(prediceate);
        }

        public void Delete(T entity)
        {
            _repository.Delete(entity);
            _unitOfWork.SaveChanges();
        }

        public void DeleteRange(List<T> entities)
        {
            _repository.DeleteRange(entities);
            _unitOfWork.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _repository.GetAll().ToList();
        }

        public List<T> GetBy(Expression<Func<T, bool>> predicate)
        {
            return _repository.GetBy(predicate).ToList();
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
            _unitOfWork.SaveChanges();
        }
    }
}
