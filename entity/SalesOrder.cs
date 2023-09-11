using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace entity
{
    public class SalesOrder
    {
        [Key]
        public int SalesOrderId { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        // Other sales order properties

        public virtual ICollection<SalesOrderLineItem> SalesOrderLineItems { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }

}
