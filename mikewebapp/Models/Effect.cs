using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mikewebapp.Models
{
    public class Effect
    {
        public UInt32 ID { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public EffectType EType { get; set; }
        public virtual ICollection<Strain> EffectOf { get; set; }
    }

    public enum  EffectType { Positive = 0, Medical = 1, Negative = 2 }
}