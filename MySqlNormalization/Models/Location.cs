using System;
using System.Collections.Generic;

namespace MySqlNormalization.Models
{
    public partial class Location
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string GoogleLocation { get; set; }
    }
}
