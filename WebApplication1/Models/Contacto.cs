using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Picture { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string GitHub { get; set; }
        [Required]
        public string Linkdin { get; set; }
    }
}
