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
    
    public partial class PARENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PARENT()
        {
            this.NOTIFICATIONs = new HashSet<NOTIFICATION>();
            this.STUDENTs = new HashSet<STUDENT>();
        }
    
        public int parent_id { get; set; }
        public string parent_fullname { get; set; }
        public string parent_email { get; set; }
        public string parent_phone { get; set; }
        public Nullable<int> student_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTIFICATION> NOTIFICATIONs { get; set; }
        public virtual STUDENT STUDENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STUDENT> STUDENTs { get; set; }
    }
}
