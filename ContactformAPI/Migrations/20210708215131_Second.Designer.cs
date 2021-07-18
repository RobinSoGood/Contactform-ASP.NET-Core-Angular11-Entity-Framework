﻿// <auto-generated />
using ContactformAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ContactformAPI.Migrations
{
    [DbContext(typeof(ContactformDetailContext))]
    [Migration("20210708215131_Second")]
    partial class Second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ContactformAPI.Models.ContactformDb", b =>
                {
                    b.Property<int>("ContactformDbId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DbMessage")
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Theme")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("UserContactformId")
                        .HasColumnType("int");

                    b.HasKey("ContactformDbId");

                    b.HasIndex("UserContactformId");

                    b.ToTable("ContactformDbs");
                });

            modelBuilder.Entity("ContactformAPI.Models.ContactformDetail", b =>
                {
                    b.Property<int>("ContactformDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Theme")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ContactformDetailId");

                    b.ToTable("ContactformDetails");
                });

            modelBuilder.Entity("ContactformAPI.Models.Themes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Theme")
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Themes");
                });

            modelBuilder.Entity("ContactformAPI.Models.UserContactform", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserTelephone")
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("UserContactforms");
                });

            modelBuilder.Entity("ContactformAPI.Models.ContactformDb", b =>
                {
                    b.HasOne("ContactformAPI.Models.UserContactform", "UserContactform")
                        .WithMany()
                        .HasForeignKey("UserContactformId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserContactform");
                });
#pragma warning restore 612, 618
        }
    }
}