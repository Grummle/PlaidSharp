using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plaid
{
    public class Category
    {
        public string type { get; set; }
        public string[] hierarchy { get; set; }
        public string id { get; set; }
    }

}
