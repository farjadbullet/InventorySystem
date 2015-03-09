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
    
    public partial class ImportItem
    {
        public ImportItem()
        {
            this.ImportExpenses = new ObservableListSource<ImportExpense>();
            this.ImportItemDetails = new ObservableListSource<ImportItemDetail>();
            this.ProductionDetails = new ObservableListSource<ProductionDetail>();
        }
    
        public int Id { get; set; }
        public string ContainerId { get; set; }
        public int SupplierId { get; set; }
        public string OrderDate { get; set; }
        public string ArrivalDate { get; set; }
        public string Status { get; set; }
    
        public virtual ObservableListSource<ImportExpense> ImportExpenses { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ObservableListSource<ImportItemDetail> ImportItemDetails { get; set; }
        public virtual ObservableListSource<ProductionDetail> ProductionDetails { get; set; }
    }
}
