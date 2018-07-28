﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZVRPub.MVCFrontEnd.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [Required]
        public DateTime OrderTime { get; set; }
        [Required]
        public int LocationId { get; set; }
        [Required]
        public int UserId { get; set; }

    }
}