using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Language : Base
    {
        public string Name { get; set; }
        public List<Tag> Tags { get; set; }
        public List<Category> Categories { get; set; }
        public List<ConstantSeo> ConstantSeos { get; set; }
    }
}
