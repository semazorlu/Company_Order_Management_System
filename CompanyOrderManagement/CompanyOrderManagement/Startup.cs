using Microsoft.AspNetCore.Builder;
using Microsoft.OpenApi.Models;

namespace CompanyOrderManagement
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Company Order Management Service v1");
                c.RoutePrefix = string.Empty;
            });
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Company Order Management Service", Version = "v1" });
            });
        }
    }
}
