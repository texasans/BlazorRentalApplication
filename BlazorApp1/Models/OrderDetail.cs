using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BlazorApp1.Models
{
    public class OrderDetail
    {
        public Int32 idOrder { get; set; }
        [Key]
        public Int32 item { get; set; }
        public Int32 productId { get; set; }
        public String description { get; set; }
        public Int32 quantity { get; set; }
        public Double unitPrice { get; set; }
        public Double total { get; set; }
        
    }
}
