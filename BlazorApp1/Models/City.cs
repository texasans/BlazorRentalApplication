using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Models
{
    public class City
    {
        [Key]
        public int idCity { get; set; }
        public string Name { get; set; }
        public int idCountry { get; set; }


        [ForeignKey("idCountry")]
        public virtual Country Country { get; set; }

    }
}
