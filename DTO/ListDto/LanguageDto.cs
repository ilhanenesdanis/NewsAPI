using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ListDto
{
    public class LanguageDto : BaseDTO
    {
        public string Name { get; set; }
        public List<ListTagDto> Tags { get; set; }
    }
}
