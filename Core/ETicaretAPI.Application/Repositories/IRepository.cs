using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositories
{
    public interface IRepository <T> where T : class //constrait
    {
        DbSet<T> Table { get; }//DbSet veritabanın da Table a denk geliyor. DbSet te Table alınır ancak herhangi bir set işlemi yapılmaz.
    }
  
     
}
