//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentInfoEx3AConsoleApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class AssignmentGrade
    {
        public int Id { get; set; }
        public short Points { get; set; }
        public System.DateTime DateCompleted { get; set; }
    
        public virtual Assignment Assignment { get; set; }
        public virtual Enrollment Enrollment { get; set; }
    }
}
