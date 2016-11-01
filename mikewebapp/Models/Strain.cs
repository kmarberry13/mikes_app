using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mikewebapp.Models
{
    public class Strain
    {
        public UInt64 ID { get; set; }
        public Strain Name { get; set; }
        public String Information { get; set; }
        public virtual IDictionary<Effect, float> Effects { get; set; }
        public virtual ICollection<Flavor> Flavors { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
        public virtual ICollection<Strain> ParentStrains { get; set; }
        public virtual ICollection<Strain> ChildStrains { get; set; }
    }
}