using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.AddOrUpdateDto
{
    public class AddTagDTO
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int LanguageId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsActive { get; set; }
    }
}
