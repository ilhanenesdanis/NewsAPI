using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository
{
    public interface INewsRepository:IRepository<News>
    {
        IQueryable<News> GetAllNews();
    }
}
