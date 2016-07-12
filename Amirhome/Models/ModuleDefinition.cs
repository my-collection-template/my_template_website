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
    
    public partial class ModuleDefinition
    {
        public ModuleDefinition()
        {
            this.ModuleControls = new HashSet<ModuleControl>();
            this.Modules = new HashSet<Module>();
        }
    
        public int ModuleDefID { get; set; }
        public string FriendlyName { get; set; }
        public int DesktopModuleID { get; set; }
        public int DefaultCacheTime { get; set; }
        public Nullable<int> CreatedByUserID { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> LastModifiedByUserID { get; set; }
        public Nullable<System.DateTime> LastModifiedOnDate { get; set; }
        public string DefinitionName { get; set; }
    
        public virtual DesktopModule DesktopModule { get; set; }
        public virtual ICollection<ModuleControl> ModuleControls { get; set; }
        public virtual ICollection<Module> Modules { get; set; }
    }
}