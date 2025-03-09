using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
//using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Models
{
    public class Order
    {
        //[DisplayName("Order #")]
        //[Display(Name = "Order #")]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int idOrder { get; set; }
        public DateTime date { get; set; } = DateTime.Now;
        public Int32 idCustomer { get; set; }
        public Int32 shippedFrom { get; set; } = 1;
        public Int32 shippedTo { get; set; } = 1;
        public Int32 quantityOfItems { get; set; }
        public Double totalAmount { get; set; }
        public String note { get; set; }
        public Boolean isDelivery { get; set; } = false;
    }
}
