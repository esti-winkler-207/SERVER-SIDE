using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UkrGuru.SqlJson;
using DAL.Data;
using service.Repository;
using DAL.Procerdures;

namespace WebApplication
{
    public class Startup
    {

        private readonly IConfiguration _config;
        public Startup(IConfiguration config)
        {
            _config = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<WebAppDbContext>(options =>
            {
                options.UseSqlServer(_config.GetConnectionString("DefaultConnection"));

            });
            services.AddScoped<ICustomersRepository, CustomersRepository>();
            services.AddScoped<ICitiesRepository, CitiesRepository>();
            services.AddScoped<ICustOrderHistoryProc, CustOrderHistoryProc>();
            services.AddScoped<ICustOrderHistory, CustomerOrderHistory>();
            services.AddScoped<ISalesByCategoryProc, SalesByCategoryProc>();
            services.AddScoped<ISalesByCategoryRepository, SalesByCategoryRepository>();
            //services.AddScoped<DbService>();
            
            //services.AddSqlJson(_config.GetConnectionString("SqlJsonConnection"));
            services.AddControllers();
        
            services.AddCors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(policy => policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200"));

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //});
        }
    }
}
