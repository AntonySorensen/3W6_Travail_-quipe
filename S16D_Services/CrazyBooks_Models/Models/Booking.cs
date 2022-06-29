﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyBooks_Models.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Event { get; set; }
        public string Commentary { get; set; }
    }
}
