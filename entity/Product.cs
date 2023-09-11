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

     
}

 

