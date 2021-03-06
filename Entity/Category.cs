using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public List<NewsCategory> NewsCategories { get; set; }
    }
}
