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
    
    public partial class tblItem
    {
        public int ItemId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<System.Guid> PartnerId { get; set; }
        public string UnitName { get; set; }
        public Nullable<double> Price { get; set; }
        public string Note { get; set; }
        public bool State { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<bool> IsFinishedProduct { get; set; }
        public int Type { get; set; }
    }
}
