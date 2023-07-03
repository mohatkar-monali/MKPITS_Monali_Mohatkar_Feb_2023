using System.ComponentModel.DataAnnotations;
namespace validationsummury.Models
{
    public class UserModel
    {
        [Required(ErrorMessage ="Name is required")]

        public string Name { get; set; }
        [Required(ErrorMessage ="Mobile number is required")]
        public string MobileNumber { get; set; }


    }
}
