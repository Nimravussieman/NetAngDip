﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetAng.Models
{
    public class ContactType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }//Клієнти   //Постачальники     //Партнери      //Інше
    }
}
