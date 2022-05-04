using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ListDto
{
    public class ListNewsDto:BaseDTO
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public string SeoKeyword { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTitle { get; set; }
        public string SeoUrl { get; set; }
        public List<ListNewsCategoryDto> NewsCategories { get; set; }
        public List<ListNewsTagDto> NewsTags { get; set; }
    }
}
