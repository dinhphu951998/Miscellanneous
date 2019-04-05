using System;
using System.Collections.Generic;

namespace MySqlNormalization.Models
{
    public partial class Appointment
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public string Phone { get; set; }
        public short? IsNew { get; set; }
    }
}
