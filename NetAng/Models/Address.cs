﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetAng.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string Value { get; set; }
        //public string Description { get; set; }
        public string Type { get; set; }
    }
}
