//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webapi
{
    using System;
    using System.Collections.Generic;
    
    public partial class tagsTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tagsTable()
        {
            this.listTables = new HashSet<listTable>();
        }
    
        public int tagid { get; set; }
        public string tagname { get; set; }
        public Nullable<System.DateTime> updatedon { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<listTable> listTables { get; set; }
    }
}
