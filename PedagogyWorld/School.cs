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
    
    public partial class School
    {
        public School()
        {
            this.SchoolUserProfiles = new HashSet<SchoolUserProfile>();
        }
    
        public int Id { get; set; }
        public string SchoolName { get; set; }
        public int District_Id { get; set; }
        public int State_Id { get; set; }
    
        public virtual District District { get; set; }
        public virtual State State { get; set; }
        public virtual ICollection<SchoolUserProfile> SchoolUserProfiles { get; set; }
    }
}
