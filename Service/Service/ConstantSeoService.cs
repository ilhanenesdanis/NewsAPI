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
    public class ConstantSeoService : Service<ConstantSeo>, IConstantSeoService
    {
        public ConstantSeoService(IUnitOfWork unitOfWork, IRepository<ConstantSeo> repository) : base(unitOfWork, repository)
        {
        }
    }
}
