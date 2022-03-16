using AutoMapper;
using Ifeanyi.Services.productAPI.DbContexts;
using Ifeanyi.Services.productAPI.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Ifeanyi.Services.productAPI.Extensions
{
    public static class ServicesExtension
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        public static void ConfigureAutoMapper(this IServiceCollection services)
        {
            IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
            services.AddSingleton(mapper);
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }


    }
}
