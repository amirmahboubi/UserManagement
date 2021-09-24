﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UserManagement.Server.Infrastructure.Persistence.Contexts;

namespace UserManagement.Server.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(UserManagementDbContext))]
    partial class UserManagementDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UserManagement.Server.Core.Domain.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            FirstName = "Admin",
                            IsActive = true,
                            LastName = "AdminZadeh",
                            Mobile = "+989171112233",
                            Password = "admin*963",
                            UserName = "Admin"
                        },
                        new
                        {
                            UserId = 2,
                            FirstName = "Amir",
                            IsActive = true,
                            LastName = "Mahboubi",
                            Mobile = "+989227609862",
                            Password = "amir*963",
                            UserName = "a.mahboubi"
                        },
                        new
                        {
                            UserId = 3,
                            FirstName = "Amin",
                            IsActive = false,
                            LastName = "Amini",
                            Mobile = "+989121112233",
                            Password = "amin*963",
                            UserName = "a.amini"
                        },
                        new
                        {
                            UserId = 4,
                            FirstName = "Amir",
                            IsActive = false,
                            LastName = "Amiri",
                            Mobile = "+989121112233",
                            Password = "amiri*963",
                            UserName = "a.amiri"
                        },
                        new
                        {
                            UserId = 5,
                            FirstName = "Mina",
                            IsActive = true,
                            LastName = "Minaee",
                            Mobile = "+989121112233",
                            Password = "mina*963",
                            UserName = "m.minaee"
                        },
                        new
                        {
                            UserId = 6,
                            FirstName = "Sara",
                            IsActive = true,
                            LastName = "Saravi",
                            Mobile = "+989121114433",
                            Password = "sara*963",
                            UserName = "s.saravi"
                        });
                });

            modelBuilder.Entity("UserManagement.Server.Core.Domain.Entities.UserDetail", b =>
                {
                    b.Property<int>("UserDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UserDetailId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserDetails");

                    b.HasData(
                        new
                        {
                            UserDetailId = 1,
                            Address = "Iran",
                            BirthDate = new DateTime(2001, 9, 24, 0, 0, 0, 0, DateTimeKind.Local),
                            Email = "admin@admin.com",
                            UserId = 1
                        },
                        new
                        {
                            UserDetailId = 2,
                            Address = "Shiraz",
                            BirthDate = new DateTime(1995, 9, 24, 0, 0, 0, 0, DateTimeKind.Local),
                            Email = "AmirMahboubi@outlook.com",
                            UserId = 2
                        },
                        new
                        {
                            UserDetailId = 3,
                            Address = "Tabriz",
                            BirthDate = new DateTime(1992, 9, 24, 0, 0, 0, 0, DateTimeKind.Local),
                            Email = "Tabriz@admin.com",
                            UserId = 3
                        },
                        new
                        {
                            UserDetailId = 4,
                            Address = "Tehran",
                            BirthDate = new DateTime(1998, 9, 24, 0, 0, 0, 0, DateTimeKind.Local),
                            Email = "Tehran@admin.com",
                            UserId = 4
                        },
                        new
                        {
                            UserDetailId = 5,
                            Address = "Shiraz",
                            BirthDate = new DateTime(1993, 9, 24, 0, 0, 0, 0, DateTimeKind.Local),
                            Email = "Shiraz@admin.com",
                            UserId = 5
                        });
                });

            modelBuilder.Entity("UserManagement.Server.Core.Domain.Entities.UserDetail", b =>
                {
                    b.HasOne("UserManagement.Server.Core.Domain.Entities.User", "User")
                        .WithOne("Detail")
                        .HasForeignKey("UserManagement.Server.Core.Domain.Entities.UserDetail", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("UserManagement.Server.Core.Domain.Entities.User", b =>
                {
                    b.Navigation("Detail")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
