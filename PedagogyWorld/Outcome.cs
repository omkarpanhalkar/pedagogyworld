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
    
    public partial class Outcome
    {
        public Outcome()
        {
            this.OutcomeUnits = new HashSet<OutcomeUnit>();
        }
    
        public int Id { get; set; }
        public string OutcomeName { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<OutcomeUnit> OutcomeUnits { get; set; }
    }
}
