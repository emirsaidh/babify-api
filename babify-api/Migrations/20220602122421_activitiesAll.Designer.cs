﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using babify_api.Data;

#nullable disable

namespace babify_api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220602122421_activitiesAll")]
    partial class activitiesAll
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("babify_api.Models.Activity.BottleMilk", b =>
                {
                    b.Property<int>("BottleMilkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BottleMilkId"), 1L, 1);

                    b.Property<int>("ActivityId")
                        .HasColumnType("int");

                    b.Property<string>("Amount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BottleMilkType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BottleMilkId");

                    b.HasIndex("ActivityId");

                    b.ToTable("BottleMilkActivities");
                });

            modelBuilder.Entity("babify_api.Models.Activity.Diaper", b =>
                {
                    b.Property<int>("DiaperId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DiaperId"), 1L, 1);

                    b.Property<int>("ActivityId")
                        .HasColumnType("int");

                    b.Property<string>("DiaperType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DiaperId");

                    b.HasIndex("ActivityId");

                    b.ToTable("DiaperActivities");
                });

            modelBuilder.Entity("babify_api.Models.Activity.Measure", b =>
                {
                    b.Property<int>("MeasureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MeasureId"), 1L, 1);

                    b.Property<int>("ActivityId")
                        .HasColumnType("int");

                    b.Property<string>("Head")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Height")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Weight")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MeasureId");

                    b.HasIndex("ActivityId");

                    b.ToTable("MeasureActivities");
                });

            modelBuilder.Entity("babify_api.Models.Activity.Medication", b =>
                {
                    b.Property<int>("MedicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MedicationId"), 1L, 1);

                    b.Property<int>("ActivityId")
                        .HasColumnType("int");

                    b.Property<string>("Dose")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MedicationId");

                    b.HasIndex("ActivityId");

                    b.ToTable("MedicationActivities");
                });

            modelBuilder.Entity("babify_api.Models.Activity.Pumping", b =>
                {
                    b.Property<int>("PumpingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PumpingId"), 1L, 1);

                    b.Property<int>("ActivityId")
                        .HasColumnType("int");

                    b.Property<string>("Amount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PumpingType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PumpingId");

                    b.HasIndex("ActivityId");

                    b.ToTable("PumpingActivities");
                });

            modelBuilder.Entity("babify_api.Models.Activity.Vaccination", b =>
                {
                    b.Property<int>("VaccinationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VaccinationId"), 1L, 1);

                    b.Property<int>("ActivityId")
                        .HasColumnType("int");

                    b.Property<string>("VaccinationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VaccinationId");

                    b.HasIndex("ActivityId");

                    b.ToTable("VaccinationActivities");
                });

            modelBuilder.Entity("babify_api.Models.Authentication.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("babify_api.Models.Authentication.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("babify_api.Models.TimerActivity.ActivityModel", b =>
                {
                    b.Property<int>("ActivityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ActivityId"), 1L, 1);

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ActivityId");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("babify_api.Models.TimerActivity.Bath", b =>
                {
                    b.Property<int>("BathId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BathId"), 1L, 1);

                    b.Property<int>("ActivityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FinishTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Seconds")
                        .HasColumnType("int");

                    b.HasKey("BathId");

                    b.HasIndex("ActivityId");

                    b.ToTable("BathActivities");
                });

            modelBuilder.Entity("babify_api.Models.TimerActivity.BreastFeeding", b =>
                {
                    b.Property<int>("BreastFeedingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BreastFeedingId"), 1L, 1);

                    b.Property<int>("ActivityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FinishTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Seconds")
                        .HasColumnType("int");

                    b.HasKey("BreastFeedingId");

                    b.HasIndex("ActivityId");

                    b.ToTable("BreastFeedingActivities");
                });

            modelBuilder.Entity("babify_api.Models.TimerActivity.Sleep", b =>
                {
                    b.Property<int>("SleepId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SleepId"), 1L, 1);

                    b.Property<int>("ActivityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FinishTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Seconds")
                        .HasColumnType("int");

                    b.HasKey("SleepId");

                    b.HasIndex("ActivityId");

                    b.ToTable("SleepActivities");
                });

            modelBuilder.Entity("babify_api.Models.TimerActivity.Tummy", b =>
                {
                    b.Property<int>("TummyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TummyId"), 1L, 1);

                    b.Property<int>("ActivityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FinishTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Seconds")
                        .HasColumnType("int");

                    b.HasKey("TummyId");

                    b.HasIndex("ActivityId");

                    b.ToTable("TummyActivities");
                });

            modelBuilder.Entity("babify_api.Models.TimerActivity.Walk", b =>
                {
                    b.Property<int>("WalkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WalkId"), 1L, 1);

                    b.Property<int>("ActivityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FinishTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Seconds")
                        .HasColumnType("int");

                    b.HasKey("WalkId");

                    b.HasIndex("ActivityId");

                    b.ToTable("WalkActivities");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("babify_api.Models.Activity.BottleMilk", b =>
                {
                    b.HasOne("babify_api.Models.TimerActivity.ActivityModel", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");
                });

            modelBuilder.Entity("babify_api.Models.Activity.Diaper", b =>
                {
                    b.HasOne("babify_api.Models.TimerActivity.ActivityModel", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");
                });

            modelBuilder.Entity("babify_api.Models.Activity.Measure", b =>
                {
                    b.HasOne("babify_api.Models.TimerActivity.ActivityModel", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");
                });

            modelBuilder.Entity("babify_api.Models.Activity.Medication", b =>
                {
                    b.HasOne("babify_api.Models.TimerActivity.ActivityModel", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");
                });

            modelBuilder.Entity("babify_api.Models.Activity.Pumping", b =>
                {
                    b.HasOne("babify_api.Models.TimerActivity.ActivityModel", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");
                });

            modelBuilder.Entity("babify_api.Models.Activity.Vaccination", b =>
                {
                    b.HasOne("babify_api.Models.TimerActivity.ActivityModel", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");
                });

            modelBuilder.Entity("babify_api.Models.TimerActivity.Bath", b =>
                {
                    b.HasOne("babify_api.Models.TimerActivity.ActivityModel", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");
                });

            modelBuilder.Entity("babify_api.Models.TimerActivity.BreastFeeding", b =>
                {
                    b.HasOne("babify_api.Models.TimerActivity.ActivityModel", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");
                });

            modelBuilder.Entity("babify_api.Models.TimerActivity.Sleep", b =>
                {
                    b.HasOne("babify_api.Models.TimerActivity.ActivityModel", "Activity")
                        .WithMany("SleepActivities")
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");
                });

            modelBuilder.Entity("babify_api.Models.TimerActivity.Tummy", b =>
                {
                    b.HasOne("babify_api.Models.TimerActivity.ActivityModel", "Activity")
                        .WithMany("TummyActivities")
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");
                });

            modelBuilder.Entity("babify_api.Models.TimerActivity.Walk", b =>
                {
                    b.HasOne("babify_api.Models.TimerActivity.ActivityModel", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("babify_api.Models.Authentication.UserRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("babify_api.Models.Authentication.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("babify_api.Models.Authentication.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("babify_api.Models.Authentication.UserRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("babify_api.Models.Authentication.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("babify_api.Models.Authentication.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("babify_api.Models.TimerActivity.ActivityModel", b =>
                {
                    b.Navigation("SleepActivities");

                    b.Navigation("TummyActivities");
                });
#pragma warning restore 612, 618
        }
    }
}
