//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Amirhome.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FreeAdvertise
    {
        public FreeAdvertise()
        {
            this.AdverKeywords = new HashSet<AdverKeyword>();
        }
    
        public int ID { get; set; }
        public string title { get; set; }
        public string title2 { get; set; }
        public string condition { get; set; }
        public Nullable<int> area { get; set; }
        public Nullable<double> price_per_meter { get; set; }
        public Nullable<double> price_total { get; set; }
        public Nullable<double> price_prepayment { get; set; }
        public Nullable<double> price_mortage { get; set; }
        public Nullable<double> price_loan { get; set; }
        public string phone { get; set; }
        public string image { get; set; }
        public System.DateTime expire_date { get; set; }
        public string district { get; set; }
        public string city { get; set; }
        public Nullable<bool> approved { get; set; }
        public string email { get; set; }
        public Nullable<System.DateTime> create_date { get; set; }
        public string edit_key { get; set; }
    
        public virtual ICollection<AdverKeyword> AdverKeywords { get; set; }
    }
}
