//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentInfo_App.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ACCESS_LOG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACCESS_LOG()
        {
            this.NOTIFICATIONs = new HashSet<NOTIFICATION>();
        }
    
        public int log_id { get; set; }
        public Nullable<int> student_id { get; set; }
        public Nullable<System.DateTime> entry_time { get; set; }
        public Nullable<System.DateTime> exit_time { get; set; }
    
        public virtual STUDENT STUDENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTIFICATION> NOTIFICATIONs { get; set; }
    }
}
