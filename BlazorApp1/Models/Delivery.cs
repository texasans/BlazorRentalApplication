using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
//using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Models
{
    public class Delivery
    {
        [Key]
        public Int32 idDelivery { get; set; }
        public Int32 idOrder { get; set; }
        public Int32 idDriver { get; set; }
        public DateTime date { get; set; } = DateTime.Now;
        public Int32 idCustomer { get; set; }
        public Int32 shippedFrom { get; set; }
        public Int32 shippedTo { get; set; }
        public Int32 quantityOfItems { get; set; }
        public Double totalAmount { get; set; }
        public String note { get; set; }
        public Boolean isDelivery { get; set; } = false;
    }
}
