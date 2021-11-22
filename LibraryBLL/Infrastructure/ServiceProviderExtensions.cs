using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using LibraryDAL.UoW;
using LibraryDAL.Context;
using AutoMapper;
using LibraryBLL.Services;

namespace LibraryBLL.Infrastructure
{
    public static class ServiceProviderExtensions
    {

        public static void AddLibraryContext(this IServiceCollection services, string connection)
        {
            services.AddDbContext<LibraryContext>(options =>
                options.UseSqlServer(connection));
        }
        public static void AddAutoMapper(this IServiceCollection services)
        {
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MapperConfigurator(cfg));
            });

            services.AddSingleton<IMapper>(mapperConfiguration.CreateMapper());
        }

        public static void AddDataServices(this IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<ITitleService, TitleService>();
        }


    }
}
