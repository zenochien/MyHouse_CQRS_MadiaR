using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service.Data
{
    public class Rooms
    {
        [Key]
        public int RoomsID { get; set; }
        public string Floor { get; set; }
        public int RoomTypeID { get; set; }
        public string RoomNumber { get; set; }
        public string Desription { get; set; }
        public int RoomStatusID { get; set; }

        [ForeignKey("RoomTypeID")]
        public virtual RoomTypes RoomTypes { get; set; }
        public virtual ICollection<StaffRooms> StaffRooms { get; set; }
        public virtual ICollection<Rates> Rates { get; set; }
        public virtual ICollection<Payments> Payments { get; set; }
    }
}
