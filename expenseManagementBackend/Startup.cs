using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using expenseManagementBackend.Models;
using expenseManagementBackend.Models.Data_Manager;
using expenseManagementBackend.Models.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace expenseManagementBackend
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
            services.AddDbContext<dbContext>(options => options.UseSqlServer(Configuration["ConnectionString:DefaultConnection"]));
            services.AddScoped<IDataRepository<user>, UserManager>();
            services.AddScoped<IDataRepository<Expense>, ExpenseManager>();
            services.AddScoped<IDataRepository<ExpenseCategory>, ExpenseCategoryManager>();
            services.AddScoped<IIncomeRepository<Income>, IncomeManager>();
            services.AddScoped<IDataRepository<IncomeCategory>, IncomeCategoryManager>();
            services.AddCors(options => options.AddPolicy("Cors", builder =>
             {
                 builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();

             }));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseCors("Cors");
            }
            else
            {
                app.UseHsts();
            }
            app.UseMvc();
        }
    }
}
