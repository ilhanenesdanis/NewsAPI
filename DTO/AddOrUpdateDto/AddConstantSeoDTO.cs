using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.AddOrUpdateDto
{
    public class AddConstantSeoDTO
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public string Keyword { get; set; }
        public string Description { get; set; }
        public int LanguageId { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
