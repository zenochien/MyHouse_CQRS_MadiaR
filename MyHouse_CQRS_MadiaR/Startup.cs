using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using MyHouse_CQRS_MadiaR.Infrastructure;
using Service.Command;
using Service.Command.DeleteCommand;
using Service.Command.UpdateCommand;
using Service.Data;
using Service.Queries;
using Service.Query;
using Service.Resposition;

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

            //Resposition
            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(UserIDPipe<,>));
            services.AddScoped(typeof(IRespositony<>), typeof(BaseRespository<>));
            services.AddScoped<IRespositony<Booking>, BaseRespository<Booking>>();
            services.AddScoped<IRespositony<Hotels>, BaseRespository<Hotels>>();
            services.AddScoped<IRespositony<Guests>, BaseRespository<Guests>>();
            services.AddScoped<IRespositony<BookingStatus>, BaseRespository<BookingStatus>>();
            services.AddScoped<IRespositony<Payments>, BaseRespository<Payments>>();
            services.AddScoped<IRespositony<PaymentStatus>, BaseRespository<PaymentStatus>>();
            services.AddScoped<IRespositony<PaymentTypes>, BaseRespository<PaymentTypes>>();
            services.AddScoped<IRespositony<Positions>, BaseRespository<Positions>>();
            services.AddScoped<IRespositony<Rates>, BaseRespository<Rates>>();
            services.AddScoped<IRespositony<ReservationAgents>, BaseRespository<ReservationAgents>>();
            services.AddScoped<IRespositony<Rooms>, BaseRespository<Rooms>>();
            services.AddScoped<IRespositony<RoomsBooked>, BaseRespository<RoomsBooked>>();
            services.AddScoped<IRespositony<RoomStatus>, BaseRespository<RoomStatus>>();
            services.AddScoped<IRespositony<Staff>, BaseRespository<Staff>>();
            services.AddScoped<IRespositony<StaffRooms>, BaseRespository<StaffRooms>>();


            //Query
            services.AddMediatR(typeof(GetAllBookingQuery).Assembly);
            services.AddMediatR(typeof(GetAllBookingStatusQuery).Assembly);
            services.AddMediatR(typeof(GetAllGuestQuery).Assembly);
            services.AddMediatR(typeof(GetAllHotelsQuery).Assembly);
            services.AddMediatR(typeof(GetAllReservationAgentsQuery).Assembly);
            services.AddMediatR(typeof(GetAllPaymentsQuery).Assembly);
            services.AddMediatR(typeof(GetAllPaymentStatusQuery).Assembly);
            services.AddMediatR(typeof(GetAllPositionsQuery).Assembly);
            services.AddMediatR(typeof(GetAllRatesQuery).Assembly);
            services.AddMediatR(typeof(GetAllRateTypesQuery).Assembly);
            services.AddMediatR(typeof(GetAllStaffQuery).Assembly);
            services.AddMediatR(typeof(GetAllStaffRoomsQuery).Assembly);
            services.AddMediatR(typeof(GetAllRoomBookedQuery).Assembly);

            //Create Command
            services.AddMediatR(typeof(CreateBookingCommand).Assembly);
            services.AddMediatR(typeof(CreateBookingStatusCommand).Assembly);
            services.AddMediatR(typeof(CreateHotelsCommand).Assembly);
            services.AddMediatR(typeof(CreateGuestsCommand).Assembly);
            services.AddMediatR(typeof(CreatePaymentsCommand).Assembly);
            services.AddMediatR(typeof(CreatePaymentStatusCommand).Assembly);
            services.AddMediatR(typeof(CreatePaymentTypesCommand).Assembly);
            services.AddMediatR(typeof(CreatePositionsCommand).Assembly);
            services.AddMediatR(typeof(CreateRatesCommand).Assembly);
            services.AddMediatR(typeof(CreateRateTypesCommand).Assembly);
            services.AddMediatR(typeof(CreateReservationAgentsCommand).Assembly);
            services.AddMediatR(typeof(CreateRoomsBookedCommand).Assembly);
            services.AddMediatR(typeof(CreateRoomsCommand).Assembly);
            services.AddMediatR(typeof(CreateRoomTypesCommand).Assembly);
            services.AddMediatR(typeof(CreateStaffCommand).Assembly);
            services.AddMediatR(typeof(CreateStaffRoomsCommand).Assembly);

            //Update Command
            services.AddMediatR(typeof(UpdateBookingCommand).Assembly);
            services.AddMediatR(typeof(UpdateBookingStatusCommand).Assembly);
            services.AddMediatR(typeof(UpdateHotelsCommand).Assembly);
            services.AddMediatR(typeof(UpdateGuestsCommand).Assembly);
            services.AddMediatR(typeof(UpdatePaymentsCommand).Assembly);
            services.AddMediatR(typeof(UpdatePaymentStatusCommand).Assembly);
            services.AddMediatR(typeof(UpdatePaymentTypesCommand).Assembly);
            services.AddMediatR(typeof(UpdatePositionsCommand).Assembly);
            services.AddMediatR(typeof(UpdateReservationAgentsCommand).Assembly);
            services.AddMediatR(typeof(UpdateRatesCommand).Assembly);
            services.AddMediatR(typeof(UpdateRateTypesCommand).Assembly);
            services.AddMediatR(typeof(UpdateRoomsBookedCommand).Assembly);
            services.AddMediatR(typeof(UpdateRoomsCommand).Assembly);
            services.AddMediatR(typeof(UpdateRoomStatusCommand).Assembly);
            services.AddMediatR(typeof(UpdateRoomTypesCommand).Assembly);
            services.AddMediatR(typeof(UpdateStaffCommand).Assembly);
            services.AddMediatR(typeof(UpdateStaffRoomsCommand).Assembly);

            //Delete Command
            services.AddMediatR(typeof(DeleteBookingCommand).Assembly);
            services.AddMediatR(typeof(DeleteBookingStatusCommand).Assembly);
            services.AddMediatR(typeof(DeleteHotelsCommand).Assembly);
            services.AddMediatR(typeof(DeleteGuestCommand).Assembly);
            services.AddMediatR(typeof(DeletePaymentsCommand).Assembly);
            services.AddMediatR(typeof(DeletePaymentStatusCommand).Assembly);
            services.AddMediatR(typeof(DeletePaymentTypesCommand).Assembly);
            services.AddMediatR(typeof(DeletePositionsCommand).Assembly);
            services.AddMediatR(typeof(DeleteReservationAgentsCommand).Assembly);
            services.AddMediatR(typeof(DeleteRatesCommand).Assembly);
            services.AddMediatR(typeof(DeleteRateTypesCommand).Assembly);
            services.AddMediatR(typeof(DeleteRoomsBookedCommand).Assembly);
            services.AddMediatR(typeof(DeleteRoomsCommand).Assembly);
            services.AddMediatR(typeof(DeleteRoomStatusCommand).Assembly);
            services.AddMediatR(typeof(DeleteRoomTypesCommand).Assembly);
            services.AddMediatR(typeof(DeleteStaffCommand).Assembly);
            services.AddMediatR(typeof(DeleteStaffRoomsCommand).Assembly);

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
