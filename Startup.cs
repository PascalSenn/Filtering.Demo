using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Filtering.Demo
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddPooledDbContextFactory<ApplicationContext>(
                x => x.UseSqlite("Data Source=blogging.db")
                    .LogTo((e, i) => e == RelationalEventId.CommandExecuted, LogToFile.Log));

            services
                .AddRouting()
                .AddGraphQLServer()
                .AddProjections()
                .AddFiltering<CustomFilteringConvention>()
                .AddSorting()
                .AddQueryType<Query>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGraphQL();
            });
        }
    }
}
