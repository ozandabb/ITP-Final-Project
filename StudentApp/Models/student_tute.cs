//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class student_tute
    {
        public int st_id { get; set; }
        public int tute_id { get; set; }
        public Nullable<int> t_mark { get; set; }
    
        public virtual Student Student { get; set; }
        public virtual tute tute { get; set; }
    }
}
