using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Controllers;
using API.Data;
using API.Data.Reposytory;
using API.Entities;
using API.Interfaceses;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace API
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
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("SqlConnectionStr"));
            });
            services.AddControllers();
            services.AddScoped<IUserReposytiry, UserRepository>();
            services.AddScoped<ICarRepository, CarRepository>();
<<<<<<< HEAD
           
            services.AddScoped<IEnimalRepository<Animal>, AnimalRepository>();
            services.AddScoped<IShopReposytory<Shop>, ShopRepository>();
            services.AddScoped<ITrainsReposytory<Train>, TrainRepository>();

           // services.AddScoped(typeof(IGenericRepository<>), typeof(AnimalRepository<>));
=======
            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<IGenericRepository<Animal>, AnimalRepository<Animal>>();
         
>>>>>>> 1d0166b709d4b0466e20656b5fbf2d57d96a8618
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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
