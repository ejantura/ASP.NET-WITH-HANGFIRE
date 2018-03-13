using System;
using System.Threading.Tasks;
using Hangfire;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(EJ.HangFire.Startup))]

namespace EJ.HangFire
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            GlobalConfiguration.Configuration.UseSqlServerStorage("HangFireDbConnection");
            app.UseHangfireDashboard();
            app.UseHangfireServer();
        }
    }
}
