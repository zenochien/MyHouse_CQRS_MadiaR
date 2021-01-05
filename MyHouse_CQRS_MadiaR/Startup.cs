using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MediatR;
using Service.Query;
using MyHouse_CQRS_MadiaR.Infrastructure;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Service.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace MyHouse_CQRS_MadiaR
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
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });

            services.AddDbContext<HotelDbContext>(builder =>
            {
                builder.UseSqlServer(Configuration.GetConnectionString("ketnoisql"), b => b.MigrationsAssembly("MyHouse_CQRS_MadiaR"));
            });

            services.AddHttpContextAccessor();

            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(UserIDPipe<,>));

            services.AddMediatR(typeof(GetAllBookingQuery).Assembly);
            services.AddMediatR(typeof(GetAllBookingStatusQuery).Assembly);
            services.AddMediatR(typeof(GetAllGuestQuery).Assembly);
            services.AddMediatR(typeof(GetAllHotelsQuery).Assembly);
            services.AddMediatR(typeof(GetAllReservationAgentsQuery).Assembly);
            services.AddMediatR(typeof(GetAllRoomBookedQuery).Assembly);

            services.AddControllers();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.Authority = Configuration["Auth:Authority"];
                    options.Audience = Configuration["Auth:Audience"];
                    options.RequireHttpsMetadata = false;
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
