using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service.Data
{
    public class Payments
    {
        [Key]
        public int PaymentID { get; set; }
        public int RoomID { get; set; }
        public DateTime? Date { get; set; }
        public string Payment { get; set; }
        public int PaymentTypeID { get; set; }
        public int PaymentStatsID { get; set; }

        [ForeignKey("RoomID")]
        public virtual Rooms Rooms { get; set; }
        [ForeignKey("PaymentTypeID")]
        public virtual Hotels PaymentTypes { get; set; }
        [ForeignKey("PaymentStatusID")]
        public virtual PaymentStatus PaymentStatus { get; set; }
    }
}
