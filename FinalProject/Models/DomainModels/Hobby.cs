using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Hobby
    {
        public int HobbyId { get; set; }                    // PK

        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        public int CategoryId { get; set; }                      // Foreign key property
        public Category Category { get; set; }                   // Navigation property

        public int PersonId { get; set; }                        // Foreign key property
        public Person Person { get; set; }                       // Navigation property
    }
}
