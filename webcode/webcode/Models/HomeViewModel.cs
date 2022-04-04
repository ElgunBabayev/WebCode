using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webcode.Models
{
    public class HomeViewModel
    {
        public List<Banner> Banner { get; set; }
        public List<GroupCat> GroupCats{ get; set; }
        public List<OurWork> OurWork { get; set; }
        public Contact Contact { get; set; }
        
    }
}
