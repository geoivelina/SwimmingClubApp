﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SwimmingClubApp.Data;

#nullable disable

namespace SwimmingClubApp.Data.Migrations
{
    [DbContext(typeof(SimmingClubDbContext))]
    [Migration("20230703065056_SomeChanges")]
    partial class SomeChanges
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("SwimmingClubApp.Data.Models.Coach", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobPosition")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SquadId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SquadId");

                    b.ToTable("Coaches");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "e.harris@mail.com",
                            FullName = "Emma Harris",
                            Image = "https://tse4.mm.bing.net/th?id=OIP.6Ue-IdphavC3AxW8adedCAHaHa&pid=Api",
                            JobPosition = "Coach",
                            SquadId = 1
                        },
                        new
                        {
                            Id = 2,
                            Email = "sam.smith@mail.com",
                            FullName = "Sam Smith",
                            Image = "https://tse2.mm.bing.net/th?id=OIP.5cla8U39A4eNC8xzRCMDiQHaHa&pid=Api",
                            JobPosition = "Junior Head Coach",
                            SquadId = 2
                        },
                        new
                        {
                            Id = 3,
                            Email = "justin.robin@mail.com",
                            FullName = "Justin Robin",
                            Image = "https://tse2.mm.bing.net/th?id=OIP.5cla8U39A4eNC8xzRCMDiQHaHa&pid=Api",
                            JobPosition = "Senior Swimming Instructor",
                            SquadId = 2
                        },
                        new
                        {
                            Id = 4,
                            Email = "cindy.somerton@mail.com",
                            FullName = "Cindy Somerton",
                            Image = "https://tse4.mm.bing.net/th?id=OIP.6Ue-IdphavC3AxW8adedCAHaHa&pid=Api",
                            JobPosition = "General Manager",
                            SquadId = 2
                        });
                });

            modelBuilder.Entity("SwimmingClubApp.Data.Models.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Desctioption")
                        .IsRequired()
                        .HasMaxLength(2500)
                        .HasColumnType("nvarchar(2500)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Newses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2023, 7, 3, 9, 50, 55, 659, DateTimeKind.Local).AddTicks(4594),
                            Desctioption = "Here are our athletes for the month of January. Begginer 1: Levi Miller & Lena Yang. Begginer 2: Leah Jin & Alex Xiao. Begginer 3: Karim Belal & Angela Xiao.  Fithness 1: Austin Ouyang & Ava Senn. Fithness 2: Brock Sever & Lucy Bojrab. 3: Flynn Keyser & Ella Harrity. Professional 1: Adam Smith & Maggie Welsh. Professional 2: Chis Martin & Nina Simone. Professionals 3: Sam Burg & Ava Max. ",
                            Image = "https://i.pinimg.com/originals/c8/67/fb/c867fbdf7a1952905f883e8294eb6498.jpg",
                            Title = "January Swimmers of the Month"
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(2023, 7, 3, 9, 50, 55, 659, DateTimeKind.Local).AddTicks(4643),
                            Desctioption = "Here are our athletes for the month of February. Begginer 1: Levi Miller & Lena Yang. Begginer 2: Leah Jin & Alex Xiao. Begginer 3: Karim Belal & Angela Xiao. Fithness 1: Austin Ouyang & Ava Senn. Fithness 2: Brock Sever & Lucy Bojrab. Fithness 3: Flynn Keyser & Ella Harrity. Professional 1: Adam Smith & Maggie Welsh. Professional 2: Chis Martin & Nina Simone. Professionals 3: Sam Burg & Ava Max. ",
                            Image = "https://i.pinimg.com/originals/c8/67/fb/c867fbdf7a1952905f883e8294eb6498.jpg",
                            Title = "February Swimmers of the Month"
                        },
                        new
                        {
                            Id = 3,
                            DateCreated = new DateTime(2023, 7, 3, 9, 50, 55, 659, DateTimeKind.Local).AddTicks(4647),
                            Desctioption = "Join us on 24th of July 2023 in SemmerSet Venue at 20:00 h for our Anual Fundrising gathering. You can meet our athleats, their coaches and see their result. Tickets for the event could be found at the receprion desk. If you need more information or would like to join organisation team contact the coordinators: event@mail.com. ",
                            Image = "https://s3.amazonaws.com/images.ecwid.com/images/16075414/1126948529.jpg",
                            Title = "Anual Fundrising Event"
                        },
                        new
                        {
                            Id = 4,
                            DateCreated = new DateTime(2023, 7, 3, 9, 50, 55, 659, DateTimeKind.Local).AddTicks(4651),
                            Desctioption = "Here are our athletes for the month of March. Begginer 1: Levi Miller & Lena Yang. Begginer 2: Leah Jin & Alex Xiao. Begginer 3: Karim Belal & Angela Xiao. Fithness 1: Austin Ouyang & Ava Senn. Fithness 2:  Sever & Lucy Bojrab. Fithness 3: Flynn Keyser & Ella Harrity. Professional 1: Adam Smith & Maggie Welsh. Professional 2: Chis Martin & Nina Simone. Professionals 3: Sam Burg & Ava Max.",
                            Image = "https://i.pinimg.com/originals/c8/67/fb/c867fbdf7a1952905f883e8294eb6498.jpg",
                            Title = "March Swimmers of the Month"
                        });
                });

            modelBuilder.Entity("SwimmingClubApp.Data.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("SizeOptionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductCategoryId");

                    b.HasIndex("SizeOptionId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "/wwwroot/img/Eshop/bottle.jpg",
                            Name = "Star Swimming Club Bottle",
                            Price = 7.00m,
                            ProductCategoryId = 4,
                            SizeOptionId = 13
                        },
                        new
                        {
                            Id = 2,
                            Image = "/wwwroot/img/Eshop/Fins.jpg",
                            Name = "Fins",
                            Price = 30.00m,
                            ProductCategoryId = 4,
                            SizeOptionId = 13
                        },
                        new
                        {
                            Id = 3,
                            Image = "/wwwroot/img/Eshop/googles.jpg",
                            Name = "Adult Googles",
                            Price = 11.00m,
                            ProductCategoryId = 4,
                            SizeOptionId = 14
                        },
                        new
                        {
                            Id = 4,
                            Image = "/wwwroot/img/Eshop/Hat.jpg",
                            Name = "Star Swimming Club Hat",
                            Price = 5.00m,
                            ProductCategoryId = 4,
                            SizeOptionId = 13
                        },
                        new
                        {
                            Id = 5,
                            Image = "/wwwroot/img/Eshop/KickBoard.jpg",
                            Name = "Kickboard",
                            Price = 15.00m,
                            ProductCategoryId = 4,
                            SizeOptionId = 13
                        },
                        new
                        {
                            Id = 6,
                            Image = "/wwwroot/img/Eshop/towel.jpg",
                            Name = "Star Swimming Club Towel",
                            Price = 15.00m,
                            ProductCategoryId = 4,
                            SizeOptionId = 13
                        });
                });

            modelBuilder.Entity("SwimmingClubApp.Data.Models.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Junior"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Women"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Men"
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Traning Aids"
                        });
                });

            modelBuilder.Entity("SwimmingClubApp.Data.Models.SizeOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<bool>("IsChecked")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("SizeOptions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Kids M",
                            IsChecked = false
                        },
                        new
                        {
                            Id = 2,
                            Description = "Kids L",
                            IsChecked = false
                        },
                        new
                        {
                            Id = 3,
                            Description = "Kids XL",
                            IsChecked = false
                        },
                        new
                        {
                            Id = 4,
                            Description = "Adult XS",
                            IsChecked = false
                        },
                        new
                        {
                            Id = 5,
                            Description = "Adult S",
                            IsChecked = false
                        },
                        new
                        {
                            Id = 6,
                            Description = "Adult M",
                            IsChecked = false
                        },
                        new
                        {
                            Id = 7,
                            Description = "Adult L",
                            IsChecked = false
                        },
                        new
                        {
                            Id = 8,
                            Description = "Adult XL",
                            IsChecked = false
                        },
                        new
                        {
                            Id = 9,
                            Description = "Age 7 - 8",
                            IsChecked = false
                        },
                        new
                        {
                            Id = 10,
                            Description = "Age 9 - 11",
                            IsChecked = false
                        },
                        new
                        {
                            Id = 11,
                            Description = "Age 12 - 13",
                            IsChecked = false
                        },
                        new
                        {
                            Id = 12,
                            Description = "Junior",
                            IsChecked = false
                        },
                        new
                        {
                            Id = 13,
                            Description = "None",
                            IsChecked = false
                        },
                        new
                        {
                            Id = 14,
                            Description = "Adult",
                            IsChecked = false
                        });
                });

            modelBuilder.Entity("SwimmingClubApp.Data.Models.Sponsor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Sponsors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Link = "https://www.speedo.com/",
                            Logo = "https://tse3.mm.bing.net/th?id=OIP.-89jNjevESq6UU7GNDD6ywHaER&pid=Api",
                            Name = "Speedo"
                        },
                        new
                        {
                            Id = 2,
                            Link = "https://www.arenasport.com/en_uk/",
                            Logo = "https://tse2.mm.bing.net/th?id=OIP.L9mMbV_HUGSUrCUZfDW8RQHaE-&pid=Api",
                            Name = "Arena"
                        },
                        new
                        {
                            Id = 3,
                            Link = "https://www.finisswim.com/",
                            Logo = "https://tse2.mm.bing.net/th?id=OIP.YyCM6JJqMvSDO_OtmAmCiwHaEo&pid=Api",
                            Name = "Finis"
                        },
                        new
                        {
                            Id = 4,
                            Link = "https://www.zoggs.com/en_GB/",
                            Logo = "https://tse1.mm.bing.net/th?id=OIP.CZ6BOVZa1BgrQKmQ7ojKoQHaDu&pid=Api",
                            Name = "Zoggs"
                        });
                });

            modelBuilder.Entity("SwimmingClubApp.Data.Models.Squad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("SquadName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Squads");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            SquadName = "Beginner"
                        },
                        new
                        {
                            Id = 2,
                            SquadName = "Professional"
                        },
                        new
                        {
                            Id = 3,
                            SquadName = "Fithness"
                        });
                });

            modelBuilder.Entity("SwimmingClubApp.Data.Models.Swimmer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("ContactPersonName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit");

                    b.Property<string>("MedicalDatails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RelationshipToSwimmer")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SquadId")
                        .HasColumnType("int");

                    b.Property<string>("SwimmingExperience")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Swimmers");
                });

            modelBuilder.Entity("SwimmingClubApp.Data.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

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

                    b.Property<string>("UserFullName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SwimmingClubApp.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SwimmingClubApp.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SwimmingClubApp.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SwimmingClubApp.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SwimmingClubApp.Data.Models.Coach", b =>
                {
                    b.HasOne("SwimmingClubApp.Data.Models.Squad", "Squad")
                        .WithMany("Coaches")
                        .HasForeignKey("SquadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Squad");
                });

            modelBuilder.Entity("SwimmingClubApp.Data.Models.Product", b =>
                {
                    b.HasOne("SwimmingClubApp.Data.Models.ProductCategory", "ProductCategory")
                        .WithMany("Products")
                        .HasForeignKey("ProductCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SwimmingClubApp.Data.Models.SizeOption", "SizeOption")
                        .WithMany()
                        .HasForeignKey("SizeOptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductCategory");

                    b.Navigation("SizeOption");
                });

            modelBuilder.Entity("SwimmingClubApp.Data.Models.ProductCategory", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("SwimmingClubApp.Data.Models.Squad", b =>
                {
                    b.Navigation("Coaches");
                });
#pragma warning restore 612, 618
        }
    }
}
