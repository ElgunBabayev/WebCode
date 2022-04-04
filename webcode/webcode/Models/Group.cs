using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webcode.Models
{
    public class Group : BaseEntity
    {
        public string Name { get; set; }
        public string Teacher { get; set; }
        public List<Student> Students { get; set; }
        public int GroupCatId { get; set; }
        public GroupCat GroupCats { get; set; }
    }
}
