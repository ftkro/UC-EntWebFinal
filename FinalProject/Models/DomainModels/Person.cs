using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Person
    {
        public int PersonId { get; set; }                    // PK

        [Display(Name = "First Name")]
        [StringLength(100, ErrorMessage = "First name may not exceed 100 characters.")]
        [Required(ErrorMessage = "Please enter a first name.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(100, ErrorMessage = "Last name may not exceed 100 characters.")]
        [Required(ErrorMessage = "Please enter a last name.")]
        public string LastName { get; set; }

        public string Description { get; set; }

        public ICollection<Hobby> Hobbies { get; set; }       // Navigation property

        // read-only display property
        public string FullName => $"{FirstName} {LastName}";
    }
}
