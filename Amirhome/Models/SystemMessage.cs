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
    
    public partial class SystemMessage
    {
        public int MessageID { get; set; }
        public Nullable<int> PortalID { get; set; }
        public string MessageName { get; set; }
        public string MessageValue { get; set; }
    
        public virtual Portal Portal { get; set; }
    }
}