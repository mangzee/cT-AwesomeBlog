﻿using Autofac;
using Autofac.Extensions.DependencyInjection;
using cT.Api.Managers;
using cT.Api.Managers.Interface;
using cT.Api.Repositories;
using cT.Api.Repositories.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace cT.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            //TODO : Something related to swagger ?

            AutoMapperConfiguration.Init();
            var builder = new ContainerBuilder();
            builder.Populate(services);
            builder.RegisterType<PostManager>().As<IPostManager>();
            builder.RegisterType<PostManager>().As<IPostManager>();
            builder.RegisterType<PostRepository>().As<IPostRepository>();
            builder.RegisterType<TagRepository>().As<ITagRepository>();
            return new AutofacServiceProvider(builder.Build());
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

            //TODO : Something related to swagger?

            //TODO : Something related to swaggerUI?
        }
    }
}