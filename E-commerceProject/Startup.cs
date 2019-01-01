using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Model;
using Model.Models;
using Repository;
using Repository.Interfaces;
using Repository.Repositories;
using Service;
using Service.Interfaces;
using Service.Services;
using Swashbuckle.AspNetCore.Swagger;


namespace E_commerceProject
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<AppDbContext>(options => options.UseMySql(Configuration.GetConnectionString("MyApp")));

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            // services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));

            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IAdminService, AdminService>();
            services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddScoped<IArticleService, ArticleService>();
            services.AddScoped<IArticleRepository, ArticleRepository>();
            //services.AddScoped<IRepositoryBase<Article>, RepositoryBase<Article>>();

            //swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("V0.0.1", new Info { Title = "E-Shop", Version = "V0.0.1" });
            });
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IHostingEnvironment env, IApplicationBuilder app)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();

            // Enable Swagger JSON endpoint.
            app.UseSwagger();
            // Enable swagger-ui (HTML, JS, CSS, etc.)
            app.UseSwaggerUI(c =>
            
                c.SwaggerEndpoint("/swagger/V0.0.1/swagger.json", "E-Shop  V0.0.1")
            
            );
        }
    }
}


