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
    public class NewsTagService : Service<NewsTag>, INewsTagService
    {
        public NewsTagService(IUnitOfWork unitOfWork, IRepository<NewsTag> repository) : base(unitOfWork, repository)
        {
        }
    }
}
