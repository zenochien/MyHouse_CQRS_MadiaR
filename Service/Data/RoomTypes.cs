﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Data
{
    public class RoomTypes
    {
        [Key]
        public int RoomTypeID { get; set; }
        public string RoomType { get; set; }
        public string Description { get; set; }
        public string SortOrder { get; set; }
        public string Active { get; set; }

        public virtual ICollection<Rooms> Rooms { get; set; }
    }
}
