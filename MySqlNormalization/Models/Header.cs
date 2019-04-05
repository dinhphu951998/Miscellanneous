using System;
using System.Collections.Generic;

namespace MySqlNormalization.Models
{
    public partial class Header
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string To { get; set; }
        public short? Exact { get; set; }
    }
}
