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
    
    public partial class ProductionDetail
    {
        public System.Guid Id { get; set; }
        public Nullable<System.Guid> ImportId { get; set; }
        public Nullable<System.Guid> ProducerId { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<decimal> Cost { get; set; }
    
        public virtual ImportItem ImportItem { get; set; }
        public virtual Producer Producer { get; set; }
    }
}
