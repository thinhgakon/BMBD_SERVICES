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
    
    public partial class tblWard
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public string DivisionType { get; set; }
        public string CodeName { get; set; }
        public Nullable<int> DistrictCode { get; set; }
    
        public virtual tblDistrict tblDistrict { get; set; }
        public virtual tblDistrict tblDistrict1 { get; set; }
        public virtual tblDistrict tblDistrict2 { get; set; }
        public virtual tblDistrict tblDistrict3 { get; set; }
    }
}
