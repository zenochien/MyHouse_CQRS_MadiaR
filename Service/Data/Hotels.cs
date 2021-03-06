﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Service.Data
{
    public class Hotels
    {
        [Key]
        public int HotelID { get; set; }
        public string HotelCode { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Name { get; set; }
        public string Motto { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCOde { get; set; }
        [Required]
        [StringLength(15)]
        public string MainPhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string TooIIFreeNumber { get; set; }
        public string CompanyeMailAddress { get; set; }
        public string WebsiteAddress { get; set; }
        public string Main { get; set; }
        public string ImagePath { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }        
    }
}
