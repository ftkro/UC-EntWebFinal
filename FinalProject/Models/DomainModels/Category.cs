using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Category
    {
        public int CategoryId { get; set; }                    // PK

        [Display(Name = "Title")]
        public string Title { get; set; }

        public ICollection<Hobby> Hobbies { get; set; }       // Navigation property
    }
}
