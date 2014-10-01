using System;
using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;

namespace vNextGeekLunch
{
    public class Startup
    {
        public void Configure(IBuilder app)
        {
            app.UseErrorPage();
            app.UseStaticFiles();
            app.UseServices(services =>
            {
                services.AddMvc();
                services.AddInstance<IMessagingService>(new MessagingService());
            });

            app.UseMvc();

        }
    }
}
