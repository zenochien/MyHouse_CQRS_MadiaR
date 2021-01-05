using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Data
{
    public class Rates
    {
        [Key]
        public int RateID { get; set; }
        public int RoomID { get; set; }
        public int Rate { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int RateTypeID { get; set; }

        [ForeignKey("RateTypeID")]
        public virtual RateTypes RateTypes { get; set; }
    }
}
