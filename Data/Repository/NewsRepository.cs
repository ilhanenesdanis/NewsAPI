using Core.Repository;
using Entity;
using Microsoft.EntityFrameworkCore;
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

        public IQueryable<News> GetAllNews()
        {
            var result = _context.News
                .Include(x => x.NewsTags).ThenInclude(x => x.Tag)
                .Include(x => x.NewsCategories).ThenInclude(x => x.Category)
                .AsNoTracking().AsSplitQuery();
            return result;
        }
    }
}
