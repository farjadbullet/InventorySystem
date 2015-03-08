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
    
    public partial class Item
    {
        public Item()
        {
            this.ImportItemDetails = new ObservableListSource<ImportItemDetail>();
            this.OrderDetails = new ObservableListSource<OrderDetail>();
            this.ProductStocks = new ObservableListSource<ProductStock>();
            this.RawStocks = new ObservableListSource<RawStock>();
        }
    
        public System.Guid Id { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public string Class { get; set; }
        public Nullable<bool> Active { get; set; }
    
        public virtual ObservableListSource<ImportItemDetail> ImportItemDetails { get; set; }
        public virtual ObservableListSource<OrderDetail> OrderDetails { get; set; }
        public virtual ObservableListSource<ProductStock> ProductStocks { get; set; }
        public virtual ObservableListSource<RawStock> RawStocks { get; set; }
    }
}
