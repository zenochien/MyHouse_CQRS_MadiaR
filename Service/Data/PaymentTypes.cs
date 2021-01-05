using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Service.Data
{
    public class PaymentTypes
    {
        [Key]
        public Guid PaymentTypeID { get; set; }
        public string PaymentType { get; set; }
        public string SortOrder { get; set; }
        public string Active { get; set; }

        public virtual ICollection<PaymentStatus> PaymentStatuses { get; set; }
    }
}
