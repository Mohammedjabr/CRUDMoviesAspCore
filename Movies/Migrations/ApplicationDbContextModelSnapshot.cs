﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Movies.Data;

#nullable disable

namespace Movies.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Movies.Models.Genre", b =>
                {
                    b.Property<byte>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = (byte)1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = (byte)2,
                            Name = "Drama"
                        },
                        new
                        {
                            Id = (byte)3,
                            Name = "Crime"
                        },
                        new
                        {
                            Id = (byte)4,
                            Name = "Biography"
                        },
                        new
                        {
                            Id = (byte)5,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = (byte)6,
                            Name = "Western"
                        },
                        new
                        {
                            Id = (byte)7,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = (byte)8,
                            Name = "Romance"
                        },
                        new
                        {
                            Id = (byte)9,
                            Name = "Commedy"
                        },
                        new
                        {
                            Id = (byte)10,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = (byte)11,
                            Name = "Historical"
                        },
                        new
                        {
                            Id = (byte)12,
                            Name = "Science fiction"
                        },
                        new
                        {
                            Id = (byte)13,
                            Name = "Thriller"
                        });
                });

            modelBuilder.Entity("Movies.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte>("GenreId")
                        .HasColumnType("tinyint");

                    b.Property<byte[]>("Poster")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<string>("StroreLine")
                        .IsRequired()
                        .HasMaxLength(2500)
                        .HasColumnType("nvarchar(2500)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("Movies.Models.Movie", b =>
                {
                    b.HasOne("Movies.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });
#pragma warning restore 612, 618
        }
    }
}