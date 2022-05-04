using Core.Repository;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class NewsRepository : Repository<News>, INewsRepository
    {
        public NewsRepository(Context context) : base(context)
        {
        }
    }
}
