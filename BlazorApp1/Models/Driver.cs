using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BlazorApp1.Models
{
    public class Driver
    {
        [Key]
        public int idDriver { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String phoneNumber { get; set; }
        public String email { get; set; }
        public String driverLicense { get; set; }
        public String address { get; set; }
        public int idCity { get; set; }
        public int idState { get; set; }
        public String zipcode { get; set; }
        public int idCountryFrom { get; set; }
        public int idVehicleType { get; set; }
        public String vehicleModel { get; set; }
        public String vehicleBrand { get; set; }
        public String vehicleVIN { get; set; }
        public Int16 vehicleYear { get; set; }
        public String vehicleColor { get; set; }
        public int idDriverStatus { get; set; }
    }
}
