using BlaBCar.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlaBCar.Installer
{
    public class DbInstaller : IInstaller
    {
        public void InstallerService(IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<BlaBCarContext>(options => options.UseSqlServer
            (
                configuration.GetConnectionString("DefaultConnection"))
            );

            service.AddScoped<IAuthRepository, AuthRepository>();

        }
    }
}
