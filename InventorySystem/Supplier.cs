//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InventorySystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Supplier
    {
        public Supplier()
        {
            this.ImportItems = new ObservableListSource<ImportItem>();
        }
    
        public System.Guid Id { get; set; }
        public string SupplierName { get; set; }
        public Nullable<System.Guid> CompanyId { get; set; }
        public string Contact { get; set; }
        public string Contact2 { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual ObservableListSource<ImportItem> ImportItems { get; set; }
    }
}
