using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Tag : BaseEntity
    {
        public string Name { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public List<NewsTag> NewsTags { get; set; }
    }
}
