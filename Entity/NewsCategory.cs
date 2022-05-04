using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class NewsCategory : Base
    {
        public int NewsId { get; set; }
        public News News { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
