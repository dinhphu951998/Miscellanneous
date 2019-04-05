using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MySqlNormalization.Models
{
    public partial class Account
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
