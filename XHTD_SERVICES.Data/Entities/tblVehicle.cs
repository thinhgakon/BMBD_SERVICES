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
    
    public partial class tblVehicle
    {
        public int IDVehicle { get; set; }
        public string Vehicle { get; set; }
        public Nullable<double> Tonnage { get; set; }
        public Nullable<double> TonnageDefault { get; set; }
        public string NameDriver { get; set; }
        public string IdCardNumber { get; set; }
        public Nullable<double> HeightVehicle { get; set; }
        public Nullable<double> WidthVehicle { get; set; }
        public Nullable<double> LongVehicle { get; set; }
        public Nullable<int> UnladenWeight1 { get; set; }
        public Nullable<System.DateTime> UnladenWeight1LastUpdate { get; set; }
        public Nullable<int> UnladenWeight2 { get; set; }
        public Nullable<System.DateTime> UnladenWeight2LastUpdate { get; set; }
        public Nullable<int> UnladenWeight3 { get; set; }
        public Nullable<System.DateTime> UnladenWeight3LastUpdate { get; set; }
        public Nullable<bool> IsSetMediumUnladenWeight { get; set; }
        public Nullable<System.DateTime> CreateDay { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> UpdateDay { get; set; }
        public string UpdateBy { get; set; }
    }
}