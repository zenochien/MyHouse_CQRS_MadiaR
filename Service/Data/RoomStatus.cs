using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Data
{
    public class RoomStatus
    {
        [Key]
        public int RoomStatusID { get; set; }
        public  string RoomsStatus { get; set; }
        public string Description { get; set; }
        public string SortOrder { get; set; }
        public string Active { get; set; }

        public virtual ICollection<Rooms> Rooms { get; set; }
    }
}
