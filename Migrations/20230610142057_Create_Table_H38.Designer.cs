﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HUMG.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230610142057_Create_Table_H38")]
    partial class Create_Table_H38
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("HUMG.Models.H38", b =>
                {
                    b.Property<string>("H38ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("H38Name")
                        .HasColumnType("TEXT");

                    b.HasKey("H38ID");

                    b.ToTable("H38");
                });
#pragma warning restore 612, 618
        }
    }
}
