﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetAng.Models
{
    public class Employe
    {
        [Key]
        public int Id { get; set; }
        public string Position { get; set; }
        public string Role { get; set; }
        public Contact Contact { get; set; }
    }
}
