using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MTS.Application.Contracts.Persistance;
using MTS.Persistence.DatabaseContext;
using MTS.Persistence.Repositories;

namespace MTS.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            //services.AddDbContext<MtstestContext>();
            services.AddDbContext<MtstestContext>(options => {
                options.UseSqlServer(configuration.GetConnectionString("MTSDBconn"));
            });
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUsermasterRepository, UsermasterRepository>();
            services.AddScoped<IUserMenuRepository, UserMenuRepository>();
            services.AddScoped<IInwardRepository, InwardRepository>();
            services.AddScoped<IGetCalibrationRepository, GetCalibrationRepository>();
            services.AddScoped<IGetDevicePrinterRepository, GetDevicePrinterRepository>();
            return services;
        }

    }
}
