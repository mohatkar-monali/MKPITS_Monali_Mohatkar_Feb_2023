using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace validdataannotation.Models

{


    public class StudentModel
    {
        public int id { get; set; }
        [Required(ErrorMessage ="Name is required")]
        [StringLength(50,MinimumLength=3)]
        public string Name { get; set; }
        [Required(ErrorMessage ="Age is required")]
        [Range(1,120,ErrorMessage ="age must be between 1-120")]
        public int Age { get; set; }
        [Required(ErrorMessage ="Email is required")]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Incorrect Email Format")]
        public string Email { get; set;}

        [Required(ErrorMessage ="Confirm Email is required")]
        [DataType(DataType.EmailAddress)]
        [System.ComponentModel.DataAnnotations.Compare("Email",ErrorMessage ="Email Not maatched")]
        public string ConfirmEmail { get; set; }
    }
}
