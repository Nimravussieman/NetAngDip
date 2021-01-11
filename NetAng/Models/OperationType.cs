﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetAng.Models
{
    public class OperationType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
