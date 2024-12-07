using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }


        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }

    }
}
