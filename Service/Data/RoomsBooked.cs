using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service.Data
{
    public class RoomsBooked
    {
        [Key]
        public Guid RoomBookedID { get; set; }
        public Guid BookingID { get; set; }
        public Guid RoomID { get; set; }
        public int Rate { get; set; }

        [ForeignKey("RoomID")]
        public virtual BookingStatus Bookings { get; set; }
    }
}
