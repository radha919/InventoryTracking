using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static entity.SalesOrder;

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

    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        public string Name { get; set; }

        // Other customer properties

        public virtual ICollection<SalesOrder> SalesOrders { get; set; }
    }

    public class SalesOrder
    {
        [Key]
        public int SalesOrderId { get; set; }
        public class Order
        {
            [Key]
            public int OrderId { get; set; }


            [Required]
            public DateTime OrderDate { get; set; }


            // Other sales order properties

            public virtual ICollection<SalesOrderLineItem> SalesOrderLineItems { get; set; }

            [ForeignKey("Customer")]
            public int CustomerId { get; set; }
            public virtual Customer Customer { get; set; }
        }

        public class SalesOrderLineItem
        {
            [Key]
            public int SalesOrderLineItemId { get; set; }
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

            // Other sales order line item properties

            [ForeignKey("SalesOrder")]
            public int SalesOrderId { get; set; }
            public virtual SalesOrder SalesOrder { get; set; }
            // Other order line item properties

            [ForeignKey("Order")]
            public int OrderId { get; set; }
            public virtual Order Order { get; set; }


            [ForeignKey("Product")]
            public int ProductId { get; set; }
            public virtual Product Product { get; set; }
        }

    }

    public class Purchase
    {
        [Key]
        public int PurchaseId { get; set; }

        [Required]
        public DateTime PurchaseDate { get; set; }

        // Other purchase properties

        public virtual ICollection<PurchaseLineItem> PurchaseLineItems { get; set; }

        [ForeignKey("Supplier")]
        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }
    }

    public class PurchaseLineItem
    {
        [Key]
        public int PurchaseLineItemId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal UnitPrice { get; set; }

        // Other purchase line item properties

        [ForeignKey("Purchase")]
        public int PurchaseId { get; set; }
        public virtual Purchase Purchase { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}




