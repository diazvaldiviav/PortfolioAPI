using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Clients
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
    }
}

//[Required(ErrorMessage = "El departamento es requerido")]
//[Display(Name = "Departamento")]
