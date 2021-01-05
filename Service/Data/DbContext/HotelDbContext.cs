using Microsoft.EntityFrameworkCore;

namespace Service.Data
{
    public class HotelDbContext : DbContext
    {
        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options)
        {
        }

        public DbSet<Booking> bookings { get; set; }
        public DbSet<BookingStatus> bookingStatuses { get; set; }
        public DbSet<Guests> guests { get; set; }
        public DbSet<Hotels> hotels { get; set; }
        public DbSet<ReservationAgents> reservationAgents { get; set; }
        public DbSet<RoomsBooked> roomsBookeds { get; set; }
    }
}
