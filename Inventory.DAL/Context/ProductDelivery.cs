//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inventory.DAL.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductDelivery
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public long DeliveryId { get; set; }
        public short Weight { get; set; }
        public decimal Cost { get; set; }
    
        public virtual Delivery Deliveries { get; set; }
        public virtual Product Products { get; set; }
    }
}
