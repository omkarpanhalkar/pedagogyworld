//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PedagogyWorld
{
    using System;
    using System.Collections.Generic;
    
    public partial class Grade
    {
        public Grade()
        {
            this.StrandDomains = new HashSet<StrandDomain>();
            this.Units = new HashSet<Unit>();
            this.UnitStandards = new HashSet<UnitStandard>();
        }
    
        public int Id { get; set; }
        public string GradeName { get; set; }
    
        public virtual ICollection<StrandDomain> StrandDomains { get; set; }
        public virtual ICollection<Unit> Units { get; set; }
        public virtual ICollection<UnitStandard> UnitStandards { get; set; }
    }
}
