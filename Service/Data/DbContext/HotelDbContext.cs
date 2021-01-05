using Microsoft.EntityFrameworkCore;

namespace Service.Data
{
    public class HotelDbContext : DbContext
    {
        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options)
        {
        }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BookingStatus> bookingStatuses { get; set; }
        public DbSet<Positions> guests { get; set; }
        public DbSet<Hotels> hotels { get; set; }
        public DbSet<Payments> payments { get; set; }
        public DbSet<PaymentStatus> paymentStatuses { get; set; }
        public DbSet<PaymentTypes> paymentTypes { get; set; }
        public DbSet<Positions> positions { get; set; }
        public DbSet<Rates> rates { get; set; }
        public DbSet<RateTypes> rateTypes { get; set; }
        public DbSet<ReservationAgents> reservationAgents { get; set; }
        public DbSet<Rooms> rooms { get; set; }
        public DbSet<RoomsBooked> roomsBookeds { get; set; }
        public DbSet<RoomStatus> roomStatuses { get; set; }
        public DbSet<RoomTypes> roomTypes { get; set; }
        public DbSet<Staff> staffs { get; set; }
        public DbSet<StaffRooms> staffRooms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
