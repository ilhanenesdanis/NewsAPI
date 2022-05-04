using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ListDto
{
    public class ListConstantSeoDto:BaseDTO
    {
        public string Title { get; set; }
        public string Keyword { get; set; }
        public string Description { get; set; }
        public int LanguageId { get; set; }
        public LanguageDto Language { get; set; }
    }
}
