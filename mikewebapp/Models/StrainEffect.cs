using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mikewebapp.Models
{
    public class StrainEffect
    {
        public int StrainEffectID { get; set; }
        public int StrainID { get; set; }
        public int EffectID { get; set; }



        public virtual Strain Strain { get; set; }
        public virtual Effect Effect { get; set; }

    }
}