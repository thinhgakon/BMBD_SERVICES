//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XHTD_SERVICES.Data.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblDistrict
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblDistrict()
        {
            this.tblWards = new HashSet<tblWard>();
            this.tblWards1 = new HashSet<tblWard>();
            this.tblWards2 = new HashSet<tblWard>();
            this.tblWards3 = new HashSet<tblWard>();
        }
    
        public string Name { get; set; }
        public int Code { get; set; }
        public string DivisionType { get; set; }
        public string CodeName { get; set; }
        public Nullable<int> ProvineCode { get; set; }
    
        public virtual tblProvine tblProvine { get; set; }
        public virtual tblProvine tblProvine1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblWard> tblWards { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblWard> tblWards1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblWard> tblWards2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblWard> tblWards3 { get; set; }
    }
}