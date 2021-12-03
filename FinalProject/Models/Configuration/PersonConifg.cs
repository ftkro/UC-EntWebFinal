using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalProject.Models
{
    internal class PersonConfig : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> entity)
        {
            entity.HasData(
               new Person { PersonId = 1, FirstName = "Takuro", LastName = "Fukuda", Description = "Takuro Fukuda is the person born in Japan in 1999, but living in the US alone over five years. He started his carrer in programming field since he was 10 years old." }
            );
        }
    }

}
