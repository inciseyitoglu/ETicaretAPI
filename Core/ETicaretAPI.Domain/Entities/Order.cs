using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Domain.Entities
{
    public class Order : BaseEntity
    {
        public string Description { get; set; }
        public string Adress { get; set; }
        public ICollection<Product> Products { get; set; } // Bir order ın birden fazla product ı vardır anlamına gelir.
        public Customer Customer { get; set; } // Bir order ın yalnızca bir tane customer ı olabilir 
    }
}
