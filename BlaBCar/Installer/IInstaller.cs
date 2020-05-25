using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlaBCar.Installer
{
    public interface IInstaller
    {
        void InstallerService(IServiceCollection service, IConfiguration configuration);
    }
}
