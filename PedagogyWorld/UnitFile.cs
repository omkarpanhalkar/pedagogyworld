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
    
    public partial class UnitFile
    {
        public int Id { get; set; }
        public System.Guid Unit_Id { get; set; }
        public System.Guid File_Id { get; set; }
    
        public virtual File File { get; set; }
        public virtual Unit Unit { get; set; }
    }
}
