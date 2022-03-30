using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class BlogLanguage : Base
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string SubTitle { get; set; }
        public string LangCode { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
