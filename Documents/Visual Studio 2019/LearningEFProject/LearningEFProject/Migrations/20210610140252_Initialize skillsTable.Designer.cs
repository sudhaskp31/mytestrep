﻿// <auto-generated />
using System;
using LearningEFProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LearningEFProject.Migrations
{
    [DbContext(typeof(SampleContext))]
    [Migration("20210610140252_Initialize skillsTable")]
    partial class InitializeskillsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LearningEFProject.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date_Of_Birth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 101,
                            Date_Of_Birth = new DateTime(1990, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "ABC"
                        });
                });

            modelBuilder.Entity("LearningEFProject.Models.SkillsTable", b =>
                {
                    b.Property<string>("SkillName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SkillDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SkillName");

                    b.ToTable("skills");

                    b.HasData(
                        new
                        {
                            SkillName = "Java",
                            SkillDescription = "OOPS"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
