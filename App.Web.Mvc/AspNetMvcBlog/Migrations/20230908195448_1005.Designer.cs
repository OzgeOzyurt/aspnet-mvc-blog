﻿// <auto-generated />
using System;
using App.Persistence.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AspNetMvcBlog.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230908195448_1005")]
    partial class _1005
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AspNetMvcBlog.Data.Entity.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Technology"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Nature"
                        });
                });

            modelBuilder.Entity("AspNetMvcBlog.Data.Entity.CategoryPost", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId", "PostId");

                    b.HasIndex("PostId");

                    b.ToTable("CategoryPost");

                    b.HasData(
                        new
                        {
                            CategoryId = 2,
                            PostId = 1
                        },
                        new
                        {
                            CategoryId = 1,
                            PostId = 2
                        });
                });

            modelBuilder.Entity("AspNetMvcBlog.Data.Entity.Page", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("PageContext")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("PageTitle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Page");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PageContext = "Sed convallis, augue sit amet aliquet tempor, eros eros fringilla libero, ultrices placerat urna augue eu nisl. Praesent suscipit viverra nulla, sed condimentum ante iaculis eget. Nam auctor faucibus metus, non gravida leo pellentesque et.",
                            PageTitle = "About"
                        },
                        new
                        {
                            Id = 2,
                            PageContext = " Etiam ultricies pharetra elit, eget vulputate odio. Fusce facilisis in lacus id lacinia. In ex lacus, convallis nec sapien non, placerat consectetur ipsum. Quisque cursus ligula id ullamcorper sagittis. Vivamus ultricies mollis augue. Nunc vel erat vitae purus vestibulum egestas.",
                            PageTitle = "Contact"
                        });
                });

            modelBuilder.Entity("AspNetMvcBlog.Data.Entity.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("PostContext")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime>("PostDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PostTitle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Post");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PostContext = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce elementum, enim et dapibus efficitur, augue augue blandit ex, et scelerisque orci felis quis massa. Donec viverra risus augue, ac auctor nisl ultrices id. Aliquam luctus mauris vitae laoreet ullamcorper. Mauris suscipit nisl sapien, sed auctor arcu feugiat vel. Integer rhoncus, diam sed consectetur dignissim, elit nibh eleifend eros, et eleifend risus augue id ante. Aenean eu risus scelerisque, mollis nulla at, finibus felis. Nulla blandit ipsum eget leo eleifend lobortis. Nulla in fringilla sem. Phasellus accumsan vitae tortor non tincidunt. Sed convallis, augue sit amet aliquet tempor, eros eros fringilla libero, ultrices placerat urna augue eu nisl. Praesent suscipit viverra nulla, sed condimentum ante iaculis eget. Nam auctor faucibus metus, non gravida leo pellentesque et.",
                            PostDate = new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PostTitle = "Lorem ipsum dolor sit amet.",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            PostContext = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin vulputate id nisi tristique ullamcorper. Vestibulum aliquam ipsum ac diam lacinia, vitae posuere urna efficitur. Cras tempus quam ut condimentum iaculis. Donec euismod enim et tristique feugiat. Suspendisse non malesuada eros. Nulla id enim sit amet orci fringilla interdum. Etiam ultricies pharetra elit, eget vulputate odio. Fusce facilisis in lacus id lacinia. In ex lacus, convallis nec sapien non, placerat consectetur ipsum. Quisque cursus ligula id ullamcorper sagittis. Vivamus ultricies mollis augue. Nunc vel erat vitae purus vestibulum egestas.",
                            PostDate = new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PostTitle = "Consectetur adipiscing.",
                            UserId = 2
                        });
                });

            modelBuilder.Entity("AspNetMvcBlog.Data.Entity.PostComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("PostComment");
                });

            modelBuilder.Entity("AspNetMvcBlog.Data.Entity.PostImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostId")
                        .IsUnique();

                    b.ToTable("PostImage");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageUrl = "../images/slider/slider1.jpg",
                            PostId = 1
                        },
                        new
                        {
                            Id = 2,
                            ImageUrl = "../images/slider/slider2.jpg",
                            PostId = 2
                        });
                });

            modelBuilder.Entity("AspNetMvcBlog.Data.Entity.Setting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("DarkMode")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Setting");
                });

            modelBuilder.Entity("AspNetMvcBlog.Data.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserNick")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserSurname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserEmail = "ozozoz@gmail.com",
                            UserName = "Ozge",
                            UserNick = "ozoz",
                            UserPassword = "1234",
                            UserSurname = "Ozyurt"
                        },
                        new
                        {
                            Id = 2,
                            UserEmail = "cemh@hotmail.com",
                            UserName = "Cem",
                            UserNick = "Cemollokkko",
                            UserPassword = "cem12",
                            UserSurname = "Hossoz"
                        });
                });

            modelBuilder.Entity("AspNetMvcBlog.Data.Entity.CategoryPost", b =>
                {
                    b.HasOne("AspNetMvcBlog.Data.Entity.Category", "Category")
                        .WithMany("CategoryPosts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AspNetMvcBlog.Data.Entity.Post", "Post")
                        .WithMany("CategoryPosts")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("AspNetMvcBlog.Data.Entity.Post", b =>
                {
                    b.HasOne("AspNetMvcBlog.Data.Entity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("AspNetMvcBlog.Data.Entity.PostComment", b =>
                {
                    b.HasOne("AspNetMvcBlog.Data.Entity.Post", "Post")
                        .WithMany()
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("AspNetMvcBlog.Data.Entity.PostImage", b =>
                {
                    b.HasOne("AspNetMvcBlog.Data.Entity.Post", "Post")
                        .WithOne("PostImage")
                        .HasForeignKey("AspNetMvcBlog.Data.Entity.PostImage", "PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("AspNetMvcBlog.Data.Entity.Category", b =>
                {
                    b.Navigation("CategoryPosts");
                });

            modelBuilder.Entity("AspNetMvcBlog.Data.Entity.Post", b =>
                {
                    b.Navigation("CategoryPosts");

                    b.Navigation("PostImage")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
