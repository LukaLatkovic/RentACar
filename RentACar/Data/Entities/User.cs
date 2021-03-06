﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.Data.Entities
{
    [Table("aspnetusers")]
    public class User
    {
        [Key]
        [Required]
        public string Id { get; set; }
        [Required]
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
