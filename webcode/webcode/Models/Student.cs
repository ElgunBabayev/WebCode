using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace webcode.Models
{
    public class Student :BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
        public string PhNum { get; set; }
        public int Cap { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }

    }
}
