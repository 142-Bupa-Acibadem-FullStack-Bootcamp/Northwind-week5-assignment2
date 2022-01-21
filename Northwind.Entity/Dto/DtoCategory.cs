using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entity.Base;

namespace Northwind.Entity.Dto
{
   public class DtoCategory : DtoBase
    {
        public DtoCategory()
        {
           // Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }

    }
}
