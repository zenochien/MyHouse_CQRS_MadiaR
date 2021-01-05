using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Data
{
    public class StaffRooms
    {
        [Key]
        public int StaffRoomID { get; set; }
        public int RoomID { get; set; }
        public int StaffID { get; set; }

        [ForeignKey("RoomID")]
        public virtual Rooms Rooms { get; set; }
        [ForeignKey("StaffID")]
        public virtual Rates Staff { get; set; }
    }
}
