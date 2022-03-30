using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Blog : Base
    {
        public DateTime PublishDate { get; set; }
        public string PhotoURL { get; set; }
        public string UserName { get; set; }
    }
}
