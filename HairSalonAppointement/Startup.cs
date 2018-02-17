using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HairSalonAppointement.Startup))]
namespace HairSalonAppointement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
