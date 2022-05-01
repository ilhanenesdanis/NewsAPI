using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ResultDTO<T> where T : class
    {
        public T Data { get; set; }
        public List<T> DataList { get; set; }
        public string Message { get; set; }
        public bool Status { get; set; }
    }
}
