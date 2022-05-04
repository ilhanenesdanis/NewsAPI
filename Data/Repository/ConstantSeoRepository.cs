using Core.Repository;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class ConstantSeoRepository : Repository<ConstantSeo>, IConstantSeoRepository
    {
        public ConstantSeoRepository(Context context) : base(context)
        {
        }
    }
}
