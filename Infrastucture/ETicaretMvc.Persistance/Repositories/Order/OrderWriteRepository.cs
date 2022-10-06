using ETicaretMvc.Application.Repositories;
using ETicaretMvc.Domain.Entities;
using ETicaretMvc.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretMvc.Persistance.Repositories
{
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(ETicaretDbContext context) : base(context)
        {
        }
    }
}
