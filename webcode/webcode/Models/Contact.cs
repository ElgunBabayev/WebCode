using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webcode.Models
{
    public class Contact : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string PhNum { get; set; }
        [Required]
        public string Operator { get; set; }
        [Required]
        public string Subject { get; set; }
    }
}
