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

    public partial class marksInfo
    {
        public int m_id { get; set; }
        public Nullable<int> sub_id { get; set; }
        public Nullable<int> e_id { get; set; }
        public Nullable<int> stu_id { get; set; }
        public Nullable<int> marks { get; set; }
    
        public virtual exam exam { get; set; }
        public virtual Student Student { get; set; }
        public virtual subject subject { get; set; }

        [NotMapped]
        public List<subject> subCollection { get; set; }

        [NotMapped]
        public List<exam> examCollection { get; set; }

        [NotMapped]
        public List<Student> stuCollection { get; set; }
    }
}
