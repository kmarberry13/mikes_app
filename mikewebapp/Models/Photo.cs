using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mikewebapp.Models
{
    public class Photo
    {
        public UInt64 PhotoID { get; set; }
        public String Caption { get; set; }
        public virtual ICollection<Strain> PhotoOf { get; set; }
    }
}