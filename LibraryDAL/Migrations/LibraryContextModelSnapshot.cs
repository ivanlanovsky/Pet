﻿// <auto-generated />
using System;
using LibraryDAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibraryDAL.Migrations
{
    [DbContext(typeof(LibraryContext))]
    partial class LibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LibraryDAL.Model.ListType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ListTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ListTypes");
                });

            modelBuilder.Entity("LibraryDAL.Model.Title", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Series")
                        .HasColumnType("int");

                    b.Property<int?>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Titles");
                });

            modelBuilder.Entity("LibraryDAL.Model.TitleList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ListTypeId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ListTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("TitleLists");
                });

            modelBuilder.Entity("LibraryDAL.Model.TitleListItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("TitleId")
                        .HasColumnType("int");

                    b.Property<int>("TitleListId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TitleId");

                    b.HasIndex("TitleListId");

                    b.ToTable("TitleListItems");
                });

            modelBuilder.Entity("LibraryDAL.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LibraryDAL.Model.TitleList", b =>
                {
                    b.HasOne("LibraryDAL.Model.ListType", "ListType")
                        .WithMany("TitleLists")
                        .HasForeignKey("ListTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryDAL.Model.User", "User")
                        .WithMany("TitleLists")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ListType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LibraryDAL.Model.TitleListItem", b =>
                {
                    b.HasOne("LibraryDAL.Model.Title", "Title")
                        .WithMany("TitleListItems")
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryDAL.Model.TitleList", "TitleList")
                        .WithMany("TitleListItems")
                        .HasForeignKey("TitleListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Title");

                    b.Navigation("TitleList");
                });

            modelBuilder.Entity("LibraryDAL.Model.ListType", b =>
                {
                    b.Navigation("TitleLists");
                });

            modelBuilder.Entity("LibraryDAL.Model.Title", b =>
                {
                    b.Navigation("TitleListItems");
                });

            modelBuilder.Entity("LibraryDAL.Model.TitleList", b =>
                {
                    b.Navigation("TitleListItems");
                });

            modelBuilder.Entity("LibraryDAL.Model.User", b =>
                {
                    b.Navigation("TitleLists");
                });
#pragma warning restore 612, 618
        }
    }
}
