using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ListDto
{
    public class ListNewsCategoryDto : BaseDTO
    {
        public int NewsId { get; set; }
        public ListNewsDto News { get; set; }
        public int CategoryId { get; set; }
        public ListCategoryDto Category { get; set; }
    }
}
