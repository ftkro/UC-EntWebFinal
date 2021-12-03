using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalProject.Models
{
    internal class HobbyConfig : IEntityTypeConfiguration<Hobby>
    {
        public void Configure(EntityTypeBuilder<Hobby> entity)
        {
            entity.HasData(
               new Hobby { HobbyId = 1, Title = "Programming", Description = "Takuro likes programming. He made his hobby for his job.", CategoryId = 1, PersonId = 1 },
               new Hobby { HobbyId = 2, Title = "Net surfing", Description = "Takuro also likes net surfing. Whenever he have free time, he did netsurfing to expand his knowledges.", CategoryId = 1, PersonId = 1 },
               new Hobby { HobbyId = 3, Title = "Japanese meal", Description = "Takuro learned how to make Japanese meal in the elementary school. And he likes to cook and eat that. Though it is not easy in the US.", CategoryId = 2, PersonId = 1 },
               new Hobby { HobbyId = 4, Title = "American meal", Description = "In the US, it is easy to cook american meal so he decide to learn how to make it.", CategoryId = 2, PersonId = 1 },
               new Hobby { HobbyId = 5, Title = "Driving", Description = "Driving between Tokyo and Osaka in 6 hours in U-Haul size truck. Speed maniac? Maybe.", CategoryId = 3, PersonId = 1 },
               new Hobby { HobbyId = 6, Title = "Airplane", Description = "Not million miler, but travel over 40000 miles per year by airplane. Mileage craze.", CategoryId = 3, PersonId = 1 },
               new Hobby { HobbyId = 7, Title = "Sleep", Description = "Can't be categorized in particular, but nourish and sleep is important, and keep me away from daily stress. Good.", CategoryId = 4, PersonId = 1 }
            );
        }
    }

}
