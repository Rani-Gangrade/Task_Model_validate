using System.ComponentModel.DataAnnotations;

namespace Task_Model_validate.Models
{
    public class StdModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [RegularExpression(@"^[A-Z][a-z]{2,}$", ErrorMessage = "Please Enter First letter Capital.")]

        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [RegularExpression(@"^\S+@\S+\.\S+$", ErrorMessage = "Please Enter Valid Email.")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Mobile Number is required.")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Please Enter 10 digit Mobile Number.")]
        public double Mobile { get; set; }

        public string? City { get; set; }

        
        public string Course { get; set; }


       
    }
}
