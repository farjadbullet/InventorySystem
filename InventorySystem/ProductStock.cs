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
    
    public partial class ProductStock
    {
        public int Id { get; set; }
        public Nullable<int> ItemId { get; set; }
        public Nullable<double> Quantity { get; set; }
    
        public virtual Item Item { get; set; }
    }
}
