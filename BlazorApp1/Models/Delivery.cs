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
        public Int32? idDriver { get; set; }
        public String address { get; set; }
        public Int32 idCity { get; set; }
        public Int32 idState { get; set; }
        public String zipcode { get; set; }
        public DateTime dateCreated { get; set; } = DateTime.Now;
        public DateTime? dateShipped { get; set; }
        public DateTime? dateDelivered { get; set; }
        public String? recipient { get; set; }
        public Int32 idDeliveryStatus { get; set; }
    }
}
