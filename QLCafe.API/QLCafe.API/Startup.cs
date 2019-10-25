using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using QLCafe.BAL;
using QLCafe.BAL.Interface;
using QLCafe.DAL;
using QLCafe.DAL.Interface;

namespace QLCafe.API
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
            services.AddMvc();
            //table products
            services.AddTransient<IProductsService, ProductsService>();
            services.AddTransient<IProductsRepository, ProductsRepository>();
            // table bills
            services.AddTransient<IBillsService, BillsService>();
            services.AddTransient<IBillsRepository, BillsRepository>();
            // table productTypes
            services.AddTransient<IProductTypesService, ProductTypesService>();
            services.AddTransient<IProductTypesRepository, ProductTypesRepository>();
            // table tableCoffees
            services.AddTransient<ITableCoffeesService, TableCoffeesService>();
            services.AddTransient<ITableCoffeesRepository, TableCoffeesRepository>();
            // table area
            services.AddTransient<IAreaService, AreaService>();
            services.AddTransient<IAreaReponsitory, AreaReponsitory>();
            // table bill detail 
            services.AddTransient<IBillDetailService, BillDetailService>();
            services.AddTransient<IBillDetailReponsitory, BillDetailReponsitory>();
            // table unit
            services.AddTransient<IUnitRepository, UnitRepository>();
            services.AddTransient<IUnitService, UnitService>();
            // table account
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<IAccountService, AccountService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
