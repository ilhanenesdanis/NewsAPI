using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.AddOrUpdateDto
{
    public class AddTagDTO:BaseDTO
    {
        public string Name { get; set; }
        public int LanguageId { get; set; }
    }
}
