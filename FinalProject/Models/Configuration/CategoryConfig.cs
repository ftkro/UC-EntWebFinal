using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalProject.Models
{
    internal class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> entity)
        {
            entity.HasData(
               new Category { CategoryId = 1, Title = "Computer" },
               new Category { CategoryId = 2, Title = "Cooking" },
               new Category { CategoryId = 3, Title = "Traveling" },
               new Category { CategoryId = 4, Title = "Misc" }
            );
        }
    }

}
