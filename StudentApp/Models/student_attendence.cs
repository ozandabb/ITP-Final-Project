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
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class student_attendence
    {
        public int att_id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> stu_id { get; set; }
    
        public virtual Student Student { get; set; }

        [NotMapped]
        public List<Student> studentCollection { get; set; }
    }
}
