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
    
    public partial class StrandDomain
    {
        public StrandDomain()
        {
            this.Headers = new HashSet<Header>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string ConceptualCategory { get; set; }
        public int State_Id { get; set; }
        public int Grade_Id { get; set; }
        public int Subject_Id { get; set; }
    
        public virtual Grade Grade { get; set; }
        public virtual ICollection<Header> Headers { get; set; }
        public virtual State State { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
