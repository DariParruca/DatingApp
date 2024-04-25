using DatingApp.Interfaces;
using DatingApp.Services;
using DattingApp.Data;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, 
            IConfiguration config)
        {
            services.AddDbContext<DataContext>(opt =>
                opt.UseSqlServer(config.GetConnectionString("DatingAppDb")));

            services.AddCors();

            services.AddScoped<ITokenService, TokenService>();

            return services;
        }
    }
}
