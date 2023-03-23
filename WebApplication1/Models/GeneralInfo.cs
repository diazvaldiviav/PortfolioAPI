using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class GeneralInfo
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]    
        public string Email { get; set; }
        [Required]
        public string Message { get; set; }
    }
}
