using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Service.Data
{
    public class RoomsBooked
    {
        [Key]
        public Guid RoomBookedID { get; set; }
        public Guid BookingID { get; set; }
        public int Rate { get; set; }

        public virtual ICollection<RoomsBooked> Bookingrooms { get; set; }
    }
}
