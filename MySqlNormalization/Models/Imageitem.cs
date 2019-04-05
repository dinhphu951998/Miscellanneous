using System;
using System.Collections.Generic;

namespace MySqlNormalization.Models
{
    public partial class Imageitem
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public int? ServiceItemId { get; set; }

        public virtual Serviceitem ServiceItem { get; set; }
    }
}
