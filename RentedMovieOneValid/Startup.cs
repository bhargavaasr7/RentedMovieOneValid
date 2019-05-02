using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RentedMovieOneValid.Startup))]
namespace RentedMovieOneValid
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
