using System;
using System.Collections.Generic;

namespace Service.Data
{
    public class BookingStatus
    {
        public Guid BookingStatusID { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public string SortOrder { get; set; }
        public string Active { get; set; }

        public virtual ICollection<BookingStatus> BookingStatuses { get; set; }
    }
}
