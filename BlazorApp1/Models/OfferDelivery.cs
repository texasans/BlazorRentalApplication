using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
//using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Models
{
    public class OfferDelivery
    {
        [Key]
        public Int32 idOfferDelivery { get; set; }
        public Int32 idDelivery { get; set; }
        public Int32 idDriver { get; set; }
        public DateTime dateOffer { get; set; }
        public DateTime? dateResponse { get; set; }
        public DateTime? dateAssigned { get; set; }
        public Int32 idOIfferStatus { get; set; }
    }
}
