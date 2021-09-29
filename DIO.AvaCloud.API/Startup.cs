using DIO.AvaCloud.Domain.Interfaces;
using DIO.AvaCloud.Infra.Context;
using DIO.AvaCloud.Infra.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DIO.AvaCloud.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddDbContext<AvaCloudDB>(option =>
                option.UseSqlServer(Configuration.GetConnectionString("AvaCloudDB")));

            services.AddScoped(typeof(IRepository<>), typeof(RepositorySQL<>));

            services.AddSwaggerGen(c => c.SwaggerDoc("v1", null));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "AvaCloud API");
                    c.RoutePrefix = string.Empty;
                });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
