﻿// <auto-generated />
using Labb4API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Labb4API.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    partial class ApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Labb4API.Models.Interest", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Interests");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "Creating software applications",
                            Title = "Programming"
                        },
                        new
                        {
                            ID = 2,
                            Description = "Playing and listening to music",
                            Title = "Music"
                        },
                        new
                        {
                            ID = 3,
                            Description = "Playing and watching sports",
                            Title = "Sports"
                        },
                        new
                        {
                            ID = 4,
                            Description = "Reading books and articles",
                            Title = "Reading"
                        },
                        new
                        {
                            ID = 5,
                            Description = "Playing video games",
                            Title = "Gaming"
                        });
                });

            modelBuilder.Entity("Labb4API.Models.Link", b =>
                {
                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int>("InterestId")
                        .HasColumnType("int");

                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonId", "InterestId");

                    b.HasIndex("InterestId");

                    b.ToTable("Links");

                    b.HasData(
                        new
                        {
                            PersonId = 1,
                            InterestId = 2,
                            ID = 1,
                            Url = "https://www.google.com"
                        },
                        new
                        {
                            PersonId = 2,
                            InterestId = 3,
                            ID = 2,
                            Url = "https://www.github.com"
                        },
                        new
                        {
                            PersonId = 3,
                            InterestId = 1,
                            ID = 3,
                            Url = "https://www.stackoverflow.com"
                        },
                        new
                        {
                            PersonId = 4,
                            InterestId = 5,
                            ID = 4,
                            Url = "https://www.microsoft.com"
                        },
                        new
                        {
                            PersonId = 5,
                            InterestId = 4,
                            ID = 5,
                            Url = "https://www.amazon.com"
                        });
                });

            modelBuilder.Entity("Labb4API.Models.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            FirstName = "Damir",
                            Phone = "0762445962"
                        },
                        new
                        {
                            ID = 2,
                            FirstName = "Daniel",
                            Phone = "653242784295"
                        },
                        new
                        {
                            ID = 3,
                            FirstName = "Alvin",
                            Phone = "3275839145734289"
                        },
                        new
                        {
                            ID = 4,
                            FirstName = "Charlie",
                            Phone = "3473895374896327"
                        },
                        new
                        {
                            ID = 5,
                            FirstName = "Petter",
                            Phone = "7589324653248967"
                        });
                });

            modelBuilder.Entity("Labb4API.Models.Link", b =>
                {
                    b.HasOne("Labb4API.Models.Interest", "Interest")
                        .WithMany("Links")
                        .HasForeignKey("InterestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labb4API.Models.Person", "Person")
                        .WithMany("Links")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Interest");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Labb4API.Models.Interest", b =>
                {
                    b.Navigation("Links");
                });

            modelBuilder.Entity("Labb4API.Models.Person", b =>
                {
                    b.Navigation("Links");
                });
#pragma warning restore 612, 618
        }
    }
}