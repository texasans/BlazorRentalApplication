using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
//using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Models
{
    public class Order
    {
        [Key]
        [DisplayName("Order #")]
        //[Display(Name = "Order #")]
        public Int32 idOrder { get; set; }
        public DateTime date { get; set; } = DateTime.Now;
        public Int32 idCustomer { get; set; }
        public Int32 shippedFrom { get; set; }
        public Int32 shippedTo { get; set; }
        public Int32 quantityOfItems { get; set; }
        public Double totalAmount { get; set; }
        public String note { get; set; } = null;
    }
}
