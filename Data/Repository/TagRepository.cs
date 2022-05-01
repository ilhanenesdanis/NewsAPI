using Core.Repository;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class TagRepository : Repository<Tag>, ITagRepository
    {
        public TagRepository(Context context) : base(context)
        {
        }
    }
}
