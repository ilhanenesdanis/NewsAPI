using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class News : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public string SeoKeyword { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTitle { get; set; }
        public string SeoUrl { get; set; }
        public List<NewsCategory> NewsCategories { get; set; }
        public List<NewsTag> NewsTags { get; set; }
    }
}
