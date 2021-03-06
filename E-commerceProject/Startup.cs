﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
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
using Microsoft.IdentityModel.Tokens;
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

            new DependenceInjection(services);

            SetupAuth(services);
            SetupGoogleAuth(services);
            //swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("V0.0.1", new Info { Title = "E-Shop", Version = "V0.0.1" });
            });

            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });
        }
        //method auth
        private void SetupAuth(IServiceCollection services)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = Configuration["Jwt:Issuer"],
                    ValidAudience = Configuration["Jwt:Issuer"],
                    IssuerSigningKey =
                        new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:key"]))

                };
            });
        }
        //Auth with google API
        private void SetupGoogleAuth(IServiceCollection services)
        {
            services.AddAuthentication().AddGoogle(googleOptions =>
            {
             googleOptions.ClientId = Configuration["Authentication:Google:ClientId"];
             googleOptions.ClientSecret = Configuration["Authentication:Google:ClientSecret"];
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
            app.UseAuthentication();
            app.UseCors("CorsPolicy");
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


