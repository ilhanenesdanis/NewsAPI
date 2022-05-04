using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.AddOrUpdateDto
{
    public class AddNewsDTO
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public string SeoKeyword { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTitle { get; set; }
        public string SeoUrl { get; set; }
        public DateTime UpdateDate { get; set; }
        public List<int> CategoryId { get; set; }
        public List<int> TagId { get; set; }
    }
}
