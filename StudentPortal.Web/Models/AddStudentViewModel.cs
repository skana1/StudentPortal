using System.ComponentModel.DataAnnotations;

namespace StudentPortal.Web.Models
{
    public class AddStudentViewModel
    {

        [Key]
        public Guid Id { get; set; } // Use Guid for unique identifier

        [Required]
        public string Name { get; set; } // Use string for text

        [Required]
        public string Email { get; set; } // Use string for text

        [Required]
        public string Phone { get; set; } // Use string for text

        public bool Subscriber { get; set; } // Use bool for bit
    }
}
