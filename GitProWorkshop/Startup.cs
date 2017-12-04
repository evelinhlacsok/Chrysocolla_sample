using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using GitProWorkshop.Models;
using Microsoft.EntityFrameworkCore;
using GitProWorkshop.Entities;
using Microsoft.EntityFrameworkCore.Design;
using GitProWorkshop.Repositories;

namespace GitProWorkshop
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            var connection = @"Server=(localdb)\mssqllocaldb;Database=GitProWorkshop;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<WorkshopContext>(options => options.UseSqlite(connection));
            services.AddScoped<WorkshopContext>();
            services.AddScoped<WorkshopRepository>();
            
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
