using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BlazorApp1.Models
{
    public class Driver
    {
        [Key]
        public Int32 idDriver { get; set; }
        public String firsName { get; set; }
        public String lastName { get; set; }
        public String driverLicense { get; set; }
        public String address { get; set; }
        public Int32 idCity { get; set; }
        public Int32 idState { get; set; }
        public Int32 idCountry { get; set; }
        public String zipcode { get; set; }
        public Int32 idVehicleType { get; set; }
        public String vehicleModel { get; set; }
        public String vehicleBrand { get; set; }
        public String vehicleVIN { get; set; }
        public Int32 vehicleYear { get; set; }
        public String vehicleColor { get; set; }
        public Int32 idDriverStatus{ get; set; }
    }
}
