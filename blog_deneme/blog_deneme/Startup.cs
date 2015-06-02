using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(blog_deneme.Startup))]
namespace blog_deneme
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
