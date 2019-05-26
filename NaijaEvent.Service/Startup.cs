using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NaijaEvent.Application.NEvents.Command.CreateEvent;
using NaijaEvent.Application.NEvents.Query;
using NaijaEvent.Persistance;
using MediatR;
using System.Reflection;
using Swashbuckle.AspNetCore.Swagger;

namespace NaijaEvent.Service
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
          services.AddMediatR(typeof(CreateEventCommandHandler).GetTypeInfo().Assembly);
            services.AddMediatR(typeof(GetNEventDetailsHandler).GetTypeInfo().Assembly);
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2).AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<CreateEventCommandValidator>());
            services.AddDbContext<NaijaEventContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("NaijaEventDatabase")));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
            });
            //  services.AddMediatR();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");

                c.RoutePrefix = string.Empty;
            });

            app.UseMvc();
        }
    }
}
