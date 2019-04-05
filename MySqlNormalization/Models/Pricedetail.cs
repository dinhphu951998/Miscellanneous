using System;
using System.Collections.Generic;

namespace MySqlNormalization.Models
{
    public partial class Pricedetail
    {
        public int Id { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public float Price { get; set; }
        public int? ServiceItemId { get; set; }
        public string Title { get; set; }

        public virtual Serviceitem ServiceItem { get; set; }
    }
}
