﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReviewsSite;

namespace ReviewsSite.Migrations
{
    [DbContext(typeof(DiningContext))]
    [Migration("20201015145236_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ReviewsSite.Models.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Review")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Seafood",
                            Description = "Cleveland best seafood served on the best patio in town.",
                            Image = "",
                            Name = "Alley Cat Oyster Bar",
                            Review = "Top notch food and setting,the staff was friendly and knowledgable about the variety of seafood.Highly recommended."
                        },
                        new
                        {
                            Id = 2,
                            Category = "Asian BBQ",
                            Description = "Asian food grilled for you in front of you",
                            Image = "",
                            Name = "bd's Mongolian Grill",
                            Review = "One of my favorite places to good for asian grilled food highly recommend"
                        },
                        new
                        {
                            Id = 3,
                            Category = "Diner",
                            Description = "Upscale family restaurant",
                            Image = "",
                            Name = "Tommy's On Coventry",
                            Review = "By keeping its focus on balancing its menu between quality meat and vegetable entrees (and at an affordable price) Tommy's achieves its goal of creating  a watering hole where the carnivores and herbivores in your family can graze in peace."
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
