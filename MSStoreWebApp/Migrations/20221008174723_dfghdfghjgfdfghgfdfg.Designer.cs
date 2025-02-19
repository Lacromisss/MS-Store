﻿// <auto-generated />
using MSStoreWebApp.Dal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MSStoreWebApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221008174723_dfghdfghjgfdfghgfdfg")]
    partial class dfghdfghjgfdfghgfdfg
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MSStoreWebApp.Models.Best", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("bests");
                });

            modelBuilder.Entity("MSStoreWebApp.Models.Catagory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("catagories");
                });

            modelBuilder.Entity("MSStoreWebApp.Models.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("colors");
                });

            modelBuilder.Entity("MSStoreWebApp.Models.ColorProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.HasIndex("ProductId");

                    b.ToTable("colorProducts");
                });

            modelBuilder.Entity("MSStoreWebApp.Models.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("genders");
                });

            modelBuilder.Entity("MSStoreWebApp.Models.Got", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("gots");
                });

            modelBuilder.Entity("MSStoreWebApp.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CatagoryId")
                        .HasColumnType("int");

                    b.Property<int>("ColorrId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CatagoryId");

                    b.HasIndex("GenderId");

                    b.ToTable("products");
                });

            modelBuilder.Entity("MSStoreWebApp.Models.Sik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("siks");
                });

            modelBuilder.Entity("MSStoreWebApp.Models.SikGot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GotId")
                        .HasColumnType("int");

                    b.Property<int>("SikId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GotId");

                    b.HasIndex("SikId");

                    b.ToTable("sikGots");
                });

            modelBuilder.Entity("MSStoreWebApp.Models.Steller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("stellers");
                });

            modelBuilder.Entity("MSStoreWebApp.Models.ColorProduct", b =>
                {
                    b.HasOne("MSStoreWebApp.Models.Color", "Color")
                        .WithMany("Colors")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MSStoreWebApp.Models.Product", "Product")
                        .WithMany("Products")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Color");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("MSStoreWebApp.Models.Product", b =>
                {
                    b.HasOne("MSStoreWebApp.Models.Catagory", "Catagory")
                        .WithMany("Products")
                        .HasForeignKey("CatagoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MSStoreWebApp.Models.Gender", "Gender")
                        .WithMany("Products")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Catagory");

                    b.Navigation("Gender");
                });

            modelBuilder.Entity("MSStoreWebApp.Models.SikGot", b =>
                {
                    b.HasOne("MSStoreWebApp.Models.Got", "Got")
                        .WithMany("Siks")
                        .HasForeignKey("GotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MSStoreWebApp.Models.Sik", "Sik")
                        .WithMany("Gots")
                        .HasForeignKey("SikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Got");

                    b.Navigation("Sik");
                });

            modelBuilder.Entity("MSStoreWebApp.Models.Steller", b =>
                {
                    b.HasOne("MSStoreWebApp.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("MSStoreWebApp.Models.Catagory", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("MSStoreWebApp.Models.Color", b =>
                {
                    b.Navigation("Colors");
                });

            modelBuilder.Entity("MSStoreWebApp.Models.Gender", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("MSStoreWebApp.Models.Got", b =>
                {
                    b.Navigation("Siks");
                });

            modelBuilder.Entity("MSStoreWebApp.Models.Product", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("MSStoreWebApp.Models.Sik", b =>
                {
                    b.Navigation("Gots");
                });
#pragma warning restore 612, 618
        }
    }
}
