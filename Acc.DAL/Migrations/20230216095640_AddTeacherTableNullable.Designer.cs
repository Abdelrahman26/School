﻿// <auto-generated />
using System;
using Acc.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Acc.DAL.Migrations
{
    [DbContext(typeof(AccContext))]
    [Migration("20230216095640_AddTeacherTableNullable")]
    partial class AddTeacherTableNullable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Acc.DAL.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("cources");
                });

            modelBuilder.Entity("Acc.DAL.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("level")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("students");
                });

            modelBuilder.Entity("Acc.DAL.StudentCources", b =>
                {
                    b.Property<int>("StdId")
                        .HasColumnType("int");

                    b.Property<int>("CrsId")
                        .HasColumnType("int");

                    b.Property<int>("Crs_length")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TeacherId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("StdId", "CrsId");

                    b.HasIndex("CrsId");

                    b.HasIndex("TeacherId");

                    b.ToTable("StudentCources");
                });

            modelBuilder.Entity("Acc.DAL.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("teachers");
                });

            modelBuilder.Entity("Acc.DAL.StudentCources", b =>
                {
                    b.HasOne("Acc.DAL.Course", "Course")
                        .WithMany("StudentCources")
                        .HasForeignKey("CrsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Acc.DAL.Student", "Student")
                        .WithMany("StudentCources")
                        .HasForeignKey("StdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Acc.DAL.Teacher", "Teacher")
                        .WithMany("StudentCources")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Acc.DAL.Course", b =>
                {
                    b.Navigation("StudentCources");
                });

            modelBuilder.Entity("Acc.DAL.Student", b =>
                {
                    b.Navigation("StudentCources");
                });

            modelBuilder.Entity("Acc.DAL.Teacher", b =>
                {
                    b.Navigation("StudentCources");
                });
#pragma warning restore 612, 618
        }
    }
}
