using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ListDto
{
    public class ListNewsTagDto : BaseDTO
    {
        public int NewsId { get; set; }
        public ListNewsDto News { get; set; }
        public int TagId { get; set; }
        public ListTagDto Tag { get; set; }
    }
}
