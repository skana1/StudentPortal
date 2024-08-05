using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentPortal.Web.Models.Entities
{
    public class Student
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
