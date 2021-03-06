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
    
    public partial class Company
    {
        public Company()
        {
            this.Customers = new ObservableListSource<Customer>();
            this.Producers = new ObservableListSource<Producer>();
            this.Suppliers = new ObservableListSource<Supplier>();
        }
    
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string AccountTitle { get; set; }
        public Nullable<decimal> OpeningBalance { get; set; }
        public Nullable<decimal> CurrentBalance { get; set; }
        public string Address { get; set; }
        public string Bank { get; set; }
    
        public virtual ObservableListSource<Customer> Customers { get; set; }
        public virtual ObservableListSource<Producer> Producers { get; set; }
        public virtual ObservableListSource<Supplier> Suppliers { get; set; }
    }
}
