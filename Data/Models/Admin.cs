﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        public int MyAdminId { get; set; }
        [Required]
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
