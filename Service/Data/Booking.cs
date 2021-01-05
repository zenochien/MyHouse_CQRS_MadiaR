using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Service.Data
{
    public class Booking 
    {
        [Key]
        public int BookingID { get; set; }
        public int HotelID { get; set; }
        public int GuestID { get; set; }
        public int ReservationAgentID { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string RoomCount { get; set; }
        public int BookingStatusID { get; set; }

        [ForeignKey("GuestID")]
        public virtual Guests Guests { get; set; }

        [ForeignKey("ReservationAgentID")]
        public virtual ReservationAgents ReservationAgents { get; set; }

        [ForeignKey("HotelID")]
        public virtual Hotels Hotels { get; set; }

        [ForeignKey("BookingStatusID")]
        public virtual BookingStatus BookingStatus { get; set; }

        [ForeignKey("RoomsBookedID")]
        public virtual RoomsBooked RoomsBookeds { get; set; }
    }
}