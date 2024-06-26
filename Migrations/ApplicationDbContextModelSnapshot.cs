﻿// <auto-generated />
using System;
using BbCenter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BbCenter.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BbCenter.Models.Booking", b =>
                {
                    b.Property<Guid>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BStatus")
                        .HasColumnType("int");

                    b.Property<int>("BType")
                        .HasColumnType("int");

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CenterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Slot")
                        .HasColumnType("int");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("BookingId");

                    b.HasIndex("CenterId");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("BbCenter.Models.Center", b =>
                {
                    b.Property<Guid>("CenterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CenterLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CenterName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("CenterId");

                    b.ToTable("Centers");
                });

            modelBuilder.Entity("BbCenter.Models.ClassRoom", b =>
                {
                    b.Property<Guid>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CenterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ClassDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ClassId");

                    b.HasIndex("CenterId");

                    b.ToTable("ClassRooms");
                });

            modelBuilder.Entity("BbCenter.Models.Feedback", b =>
                {
                    b.Property<Guid>("FeedBackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FeedbackDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("bit");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("FeedBackId");

                    b.HasIndex("UserId");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("BbCenter.Models.Participant", b =>
                {
                    b.Property<Guid>("ParticipantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClassId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ParticipantId");

                    b.HasIndex("ClassId");

                    b.HasIndex("UserId");

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("BbCenter.Models.Role", b =>
                {
                    b.Property<Guid>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleId = new Guid("fab0f92f-5342-4ad9-b704-298a9aacc21e"),
                            Name = "Administrator"
                        },
                        new
                        {
                            RoleId = new Guid("f8cde125-1e72-4a26-b79f-709f671b290a"),
                            Name = "CenterManager"
                        },
                        new
                        {
                            RoleId = new Guid("3c907e92-1d0f-4be3-a107-6581adff92b5"),
                            Name = "Teacher"
                        },
                        new
                        {
                            RoleId = new Guid("1fe4938d-d479-482b-af22-c79ee4ffd447"),
                            Name = "Student"
                        });
                });

            modelBuilder.Entity("BbCenter.Models.Schedule", b =>
                {
                    b.Property<Guid>("ScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ParticipantId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ScheduleDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Slot")
                        .HasColumnType("int");

                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ScheduleId");

                    b.HasIndex("ParticipantId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("BbCenter.Models.Subject", b =>
                {
                    b.Property<Guid>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SubjectDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SubjectId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("BbCenter.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid?>("CenterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Degree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId");

                    b.HasIndex("CenterId");

                    b.HasIndex("RoleId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("0c67b9de-ebd3-42d9-81ea-8242c8ae19aa"),
                            Address = "Admin Address",
                            DateOfBirth = new DateTime(2002, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Degree = "Admin",
                            Email = "admin@gmail.com",
                            FirstName = "Admin",
                            LastName = "Admin",
                            Password = "AQAAAAIAAYagAAAAECy/2LZ7mNKrEgBBIfgb/8SasA1qdmwm9zZ17IxqJdcsz1LqtleEBHXWd1HY+za9lw==",
                            PhoneNumber = "1234567890",
                            RoleId = new Guid("fab0f92f-5342-4ad9-b704-298a9aacc21e")
                        });
                });

            modelBuilder.Entity("BbCenter.Models.Booking", b =>
                {
                    b.HasOne("BbCenter.Models.Center", "Center")
                        .WithMany()
                        .HasForeignKey("CenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BbCenter.Models.User", "Student")
                        .WithMany("StudentSeleced")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BbCenter.Models.Subject", "Subject")
                        .WithMany("Bookings")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BbCenter.Models.User", "Teacher")
                        .WithMany("TeacherSelected")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Center");

                    b.Navigation("Student");

                    b.Navigation("Subject");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("BbCenter.Models.ClassRoom", b =>
                {
                    b.HasOne("BbCenter.Models.Center", null)
                        .WithMany("ClassRooms")
                        .HasForeignKey("CenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BbCenter.Models.Feedback", b =>
                {
                    b.HasOne("BbCenter.Models.User", "User")
                        .WithMany("Feedbacks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BbCenter.Models.Participant", b =>
                {
                    b.HasOne("BbCenter.Models.ClassRoom", "ClassRoom")
                        .WithMany("Participants")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BbCenter.Models.User", "User")
                        .WithMany("Participants")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClassRoom");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BbCenter.Models.Schedule", b =>
                {
                    b.HasOne("BbCenter.Models.Participant", "Participant")
                        .WithMany("Schedules")
                        .HasForeignKey("ParticipantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BbCenter.Models.Subject", "Subject")
                        .WithMany("Schedules")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Participant");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("BbCenter.Models.User", b =>
                {
                    b.HasOne("BbCenter.Models.Center", "Center")
                        .WithMany("Users")
                        .HasForeignKey("CenterId");

                    b.HasOne("BbCenter.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BbCenter.Models.Subject", "Subject")
                        .WithMany("Users")
                        .HasForeignKey("SubjectId");

                    b.Navigation("Center");

                    b.Navigation("Role");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("BbCenter.Models.Center", b =>
                {
                    b.Navigation("ClassRooms");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("BbCenter.Models.ClassRoom", b =>
                {
                    b.Navigation("Participants");
                });

            modelBuilder.Entity("BbCenter.Models.Participant", b =>
                {
                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("BbCenter.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("BbCenter.Models.Subject", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Schedules");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("BbCenter.Models.User", b =>
                {
                    b.Navigation("Feedbacks");

                    b.Navigation("Participants");

                    b.Navigation("StudentSeleced");

                    b.Navigation("TeacherSelected");
                });
#pragma warning restore 612, 618
        }
    }
}
