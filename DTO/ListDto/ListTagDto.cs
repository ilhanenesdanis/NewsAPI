using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ListDto
{
    public class ListTagDto:BaseDTO
    {
        public string Name { get; set; }
        public int LanguageId { get; set; }
        public LanguageDto Language { get; set; }
    }
}
