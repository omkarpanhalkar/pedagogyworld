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
    
    public partial class UserGrade
    {
        public int Id { get; set; }
        public int UserProfile_Id { get; set; }
        public int Grade_Id { get; set; }
    
        public virtual Grade Grade { get; set; }
        public virtual UserProfile UserProfile { get; set; }
    }
}
