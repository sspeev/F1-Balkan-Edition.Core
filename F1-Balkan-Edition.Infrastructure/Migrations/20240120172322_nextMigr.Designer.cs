﻿// <auto-generated />
using F1_Balkan_Edition.Infrastrucure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace F1_Balkan_Edition.Infrastructure.Migrations
{
    [DbContext(typeof(F1BalkanEditionContext))]
    [Migration("20240120172322_nextMigr")]
    partial class nextMigr
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("F1_Balkan_Edition.Infrastrucure.Data.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Identificator of the car");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CarBrand")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasComment("The brand of the car");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("The model of the car");

                    b.Property<string>("Power")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("The horsepower of the car");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("F1_Balkan_Edition.Infrastrucure.Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Identificator of the user");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarId")
                        .HasColumnType("int")
                        .HasComment("Identificator of the car");

                    b.Property<string>("LapTime")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)")
                        .HasComment("Lap time formatted: 00:00:00");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("The name of the racer");

                    b.Property<string>("Track")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("This is the track where the lap has been set");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("F1_Balkan_Edition.Infrastrucure.Data.Models.User", b =>
                {
                    b.HasOne("F1_Balkan_Edition.Infrastrucure.Data.Models.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });
#pragma warning restore 612, 618
        }
    }
}
