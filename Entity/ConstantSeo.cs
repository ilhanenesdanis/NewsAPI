using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ConstantSeo:BaseEntity
    {
        public string Title { get; set; }
        public string Keyword { get; set; }
        public string Description { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
