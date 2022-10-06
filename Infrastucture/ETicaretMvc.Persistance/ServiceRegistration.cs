using ETicaretMvc.Application.Abstractions;
using ETicaretMvc.Application.Repositories;
using ETicaretMvc.Persistance.Concretes;
using ETicaretMvc.Persistance.Contexts;
using ETicaretMvc.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretMvc.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection services)
        {
            services.AddDbContext<ETicaretDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));
            services.AddScoped<ICustomerReadRepository,CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository,CustomerWriteRepository>();
            services.AddScoped<IOrderReadRepository,OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository,OrderWriteRepository>();
            services.AddScoped<IProductReadRepository,ProductReadRepository>();
            services.AddScoped<IProductWriteRepository,ProductWriteRepository>();
        }
    }
}
