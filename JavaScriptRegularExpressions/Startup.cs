using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JavaScriptRegularExpressions.Startup))]
namespace JavaScriptRegularExpressions
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
