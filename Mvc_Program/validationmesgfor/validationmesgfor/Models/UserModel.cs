using System.ComponentModel.DataAnnotations;
namespace validationmesgfor.Models
{
    public class UserModel
    {
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }
    }
}
