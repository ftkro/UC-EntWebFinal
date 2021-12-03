﻿// <auto-generated />
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinalProject.Migrations
{
    [DbContext(typeof(BiographyContext))]
    partial class BiographyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FinalProject.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Title = "Computer"
                        },
                        new
                        {
                            CategoryId = 2,
                            Title = "Cooking"
                        },
                        new
                        {
                            CategoryId = 3,
                            Title = "Traveling"
                        },
                        new
                        {
                            CategoryId = 4,
                            Title = "Misc"
                        });
                });

            modelBuilder.Entity("FinalProject.Models.Hobby", b =>
                {
                    b.Property<int>("HobbyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HobbyId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("PersonId");

                    b.ToTable("Hobbies");

                    b.HasData(
                        new
                        {
                            HobbyId = 1,
                            CategoryId = 1,
                            Description = "Takuro likes programming. He made his hobby for his job.",
                            PersonId = 1,
                            Title = "Programming"
                        },
                        new
                        {
                            HobbyId = 2,
                            CategoryId = 1,
                            Description = "Takuro also likes net surfing. Whenever he have free time, he did netsurfing to expand his knowledges.",
                            PersonId = 1,
                            Title = "Net surfing"
                        },
                        new
                        {
                            HobbyId = 3,
                            CategoryId = 2,
                            Description = "Takuro learned how to make Japanese meal in the elementary school. And he likes to cook and eat that. Though it is not easy in the US.",
                            PersonId = 1,
                            Title = "Japanese meal"
                        },
                        new
                        {
                            HobbyId = 4,
                            CategoryId = 2,
                            Description = "In the US, it is easy to cook american meal so he decide to learn how to make it.",
                            PersonId = 1,
                            Title = "American meal"
                        },
                        new
                        {
                            HobbyId = 5,
                            CategoryId = 3,
                            Description = "Driving between Tokyo and Osaka in 6 hours in U-Haul size truck. Speed maniac? Maybe.",
                            PersonId = 1,
                            Title = "Driving"
                        },
                        new
                        {
                            HobbyId = 6,
                            CategoryId = 3,
                            Description = "Not million miler, but travel over 40000 miles per year by airplane. Mileage craze.",
                            PersonId = 1,
                            Title = "Airplane"
                        },
                        new
                        {
                            HobbyId = 7,
                            CategoryId = 4,
                            Description = "Can't be categorized in particular, but nourish and sleep is important, and keep me away from daily stress. Good.",
                            PersonId = 1,
                            Title = "Sleep"
                        });
                });

            modelBuilder.Entity("FinalProject.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("PersonId");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            PersonId = 1,
                            Description = "Takuro Fukuda is the person born in Japan in 1999, but living in the US alone over five years. He started his carrer in programming field since he was 10 years old.",
                            FirstName = "Takuro",
                            LastName = "Fukuda"
                        });
                });

            modelBuilder.Entity("FinalProject.Models.Hobby", b =>
                {
                    b.HasOne("FinalProject.Models.Category", "Category")
                        .WithMany("Hobbies")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinalProject.Models.Person", "Person")
                        .WithMany("Hobbies")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
