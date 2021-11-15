using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using LibraryDAL.UoW;
using LibraryDAL.Context;

namespace LibraryBLL
{
    public static class ServiceProviderExtensions
    {

        public static void AddLibraryContext(this IServiceCollection services, string connection)
        {
            services.AddDbContext<LibraryContext>(options =>
                options.UseSqlServer(connection));
        }
        
    }
}
