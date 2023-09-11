using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entity
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        // Other product properties

        public virtual ICollection<PurchaseLineItem> PurchaseLineItems { get; set; }
        public virtual ICollection<SalesOrderLineItem> SalesOrderLineItems { get; set; }
    }

    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }

        [Required]
        public string Name { get; set; }

        // Other supplier properties

        public virtual ICollection<Purchase> Purchases { get; set; }
    }

    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        // Other order properties

        public virtual ICollection<OrderLineItem> OrderLineItems { get; set; }
    }

    public class OrderLineItem
    {
        [Key]
        public int OrderLineItemId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal UnitPrice { get; set; }

        // Other order line item properties

        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
     
}

 

