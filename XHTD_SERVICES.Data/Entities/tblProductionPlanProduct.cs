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
    
    public partial class tblProductionPlanProduct
    {
        public int Id { get; set; }
        public string ItemCode { get; set; }
        public Nullable<double> Balancer { get; set; }
        public Nullable<double> PlanFactory { get; set; }
        public Nullable<double> PlanAgent { get; set; }
        public Nullable<double> PlanOutsource { get; set; }
        public Nullable<double> TotalNumber { get; set; }
        public Nullable<double> TotalNumberAccumulated { get; set; }
        public string Note { get; set; }
        public Nullable<System.DateTime> CreateDay { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> UpdateDay { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<int> ProductionPlanId { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<System.DateTime> BalancerDate { get; set; }
        public string ItemName { get; set; }
    }
}
