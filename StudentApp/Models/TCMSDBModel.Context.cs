﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TCMSDBEntities : DbContext
    {
        public TCMSDBEntities()
            : base("name=TCMSDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<classroom> classrooms { get; set; }
        public virtual DbSet<computer> computers { get; set; }
        public virtual DbSet<emp_attendence> emp_attendence { get; set; }
        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<exam> exams { get; set; }
        public virtual DbSet<fund_info> fund_info { get; set; }
        public virtual DbSet<lab> labs { get; set; }
        public virtual DbSet<repair> repairs { get; set; }
        public virtual DbSet<student_tute> student_tute { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<subject> subjects { get; set; }
        public virtual DbSet<subject_exam> subject_exam { get; set; }
        public virtual DbSet<teacher> teachers { get; set; }
        public virtual DbSet<tute> tutes { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<Allocation> Allocations { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Tax> Taxes { get; set; }
        public virtual DbSet<Tutes> Tutes1 { get; set; }
        public virtual DbSet<classroom1> classroom1 { get; set; }
        public virtual DbSet<marksInfo> marksInfoes { get; set; }
        public virtual DbSet<student_attendence> student_attendence { get; set; }
    }
}