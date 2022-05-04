using Core.Repository;
using Core.UnitOfWork;
using Entity;
using Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class NewsCategoryService : Service<NewsCategory>, INewsCategoryService
    {
        public NewsCategoryService(IUnitOfWork unitOfWork, IRepository<NewsCategory> repository) : base(unitOfWork, repository)
        {
        }
    }
}
