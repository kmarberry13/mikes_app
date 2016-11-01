using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mikewebapp.Models
{
    public class Flavor
    {
        public UInt16 ID { get; set; }
        public String Name { get; set; }
        public virtual ICollection<Strain> FlavorOf { get; set; }

    }
}