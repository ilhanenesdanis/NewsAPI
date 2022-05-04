using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class NewsTag : Base
    {
        public int NewsId { get; set; }
        public News News { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
