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
    using System.ComponentModel.DataAnnotations;

    public partial class employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public employee()
        {
            this.emp_attendence = new HashSet<emp_attendence>();
        }
    
        public int emp_id { get; set; }

        [Required(ErrorMessage = "Required")]
        public string full_name { get; set; }

        [Required]
        [Range(1, 25000, ErrorMessage = "Employee salary can not exceed 20,000 according to institution polices")]
        public Nullable<double> salary { get; set; }

        [Required]
        public Nullable<System.DateTime> birthday { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                           @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                           @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                           ErrorMessage = "Email is not valid")]
        public string email { get; set; }

        [Required]
        [Range(0, 9999999999, ErrorMessage ="Enter a valid phone number")]
        public string contact_num { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<emp_attendence> emp_attendence { get; set; }
    }
}
