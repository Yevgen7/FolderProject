﻿// <auto-generated />
using System;
using FolderProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FolderProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231117103039_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("FolderProject.Models.Folder", b =>
                {
                    b.Property<int>("FolderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("ParentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("FolderId");

                    b.HasIndex("ParentId");

                    b.ToTable("Folder");
                });

            modelBuilder.Entity("FolderProject.Models.Folder", b =>
                {
                    b.HasOne("FolderProject.Models.Folder", "ParentDirectory")
                        .WithMany("ChildDirectories")
                        .HasForeignKey("ParentId");

                    b.Navigation("ParentDirectory");
                });

            modelBuilder.Entity("FolderProject.Models.Folder", b =>
                {
                    b.Navigation("ChildDirectories");
                });
#pragma warning restore 612, 618
        }
    }
}
