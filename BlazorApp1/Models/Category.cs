using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [MinLength(5, ErrorMessage = "Min Length should be 5.")]
        [MaxLength(100, ErrorMessage = "Max Length should be 100.")]
        public string Name { get; set; }
        public string Description { get; set; }


        public virtual List<Products> Products { get; set; }
    }
}
