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
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(ETicaretDbContext context) : base(context)
        {
        }
    }
}
