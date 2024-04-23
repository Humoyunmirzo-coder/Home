using Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public  static  class ConfigureService
    {
        public static void AddServises ( this IServiceCollection services  , IConfiguration configuration )
        {
            services.AddDbContext<HomeDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("ConnectionHome")));
        } 
    }
}
