﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webcode.Models
{
    public class GroupCat : BaseEntity
    {
        public string Icon { get; set; }
        public string Name { get; set; }
        public List<Group> Groups { get; set; }
    }
}
