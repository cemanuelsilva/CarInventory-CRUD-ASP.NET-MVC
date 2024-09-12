using System.ComponentModel.DataAnnotations;
namespace LearnApp.Models

{
    public class Car
    {

        public int carId { get; set; }

        [Required(ErrorMessage = "Plate is required")]
        public string plate { get; set; }
        [Required(ErrorMessage = "Date of Plate is required")]
        public DateOnly datePlate { get; set; }
        [Required(ErrorMessage = "Car Owner is required")]
        public string carOwner { get; set; }
        [Required(ErrorMessage = "Car Name is required")]
        public string carName { get; set; }
        [Required(ErrorMessage = "Brand is required")]
        public string mark { get; set; }


        public Car() { }
    }
}
