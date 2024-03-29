﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webcode.Models
{
    public class Banner :BaseEntity
    {
        public string Background { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Text { get; set; }
    }
}
