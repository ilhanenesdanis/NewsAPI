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
    public class NewsService : Service<News>, INewsService
    {
        public NewsService(IUnitOfWork unitOfWork, IRepository<News> repository) : base(unitOfWork, repository)
        {
        }
    }
}
