using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication.OAuth;

namespace BlaBCar.Installer
{
    public class FacebookAuth : IInstaller
    {
        public void InstallerService(IServiceCollection service, IConfiguration configuration)
        {
            service.AddAuthentication().AddFacebook(facebookOptions =>
            {
                facebookOptions.AppId = configuration["Authentication:Facebook:3603362123023602"];
                facebookOptions.AppSecret = configuration["Authentication:Facebook:9281966b803ff37c680df731cc10bd00"];
                facebookOptions.AccessDeniedPath = "/AccessDeniedPathInfo";
            });
        }
    }
}
