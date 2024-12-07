using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public int GenderId { get; set; } //male,female,others
        public bool Status { get; set; } 


        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }


        [ForeignKey("CityId")]
        public virtual City City { get; set; }
    }
}
