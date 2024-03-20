﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Repository;

#nullable disable

namespace ApiSkeleton.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20240320161525_inisiasi_projek")]
    partial class inisiasi_projek
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Entities.Models.CompanyContext.CompanyDeparments", b =>
                {
                    b.Property<Guid>("ID_M_Company")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ID_M_Department")
                        .HasColumnType("uuid");

                    b.ToTable("CompanyDeparments");
                });

            modelBuilder.Entity("Entities.Models.CompanyContext.DepartmentDivisions", b =>
                {
                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("DivisionId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ID_M_Department")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ID_M_Division")
                        .HasColumnType("uuid");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("DivisionId");

                    b.ToTable("DepartmentDivisions");
                });

            modelBuilder.Entity("Entities.Models.CompanyContext.M_Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("M_Company");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9a454039-5104-4870-826f-dc7f389b4368"),
                            Name = "Kompi1"
                        },
                        new
                        {
                            Id = new Guid("0a2ab041-2c73-4d98-a1cb-c929ead193bd"),
                            Name = "Kompi2"
                        },
                        new
                        {
                            Id = new Guid("44ac9b0a-a06e-4322-a628-820da257ca52"),
                            Name = "Kompi3"
                        });
                });

            modelBuilder.Entity("Entities.Models.CompanyContext.M_Department", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("M_CompanyId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("M_CompanyId");

                    b.ToTable("M_Department");

                    b.HasData(
                        new
                        {
                            Id = new Guid("54c6d688-e6ef-4185-9c08-abdf3fa400f5"),
                            Name = "Dept1"
                        },
                        new
                        {
                            Id = new Guid("004851fd-df49-41d8-aa1e-e357e1a26b44"),
                            Name = "Dept2"
                        },
                        new
                        {
                            Id = new Guid("10eacbeb-6f21-4e20-a4b9-3d2e28b1cfcc"),
                            Name = "Dept3"
                        });
                });

            modelBuilder.Entity("Entities.Models.CompanyContext.M_Division", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("M_Division");
                });

            modelBuilder.Entity("M_DepartmentM_Division", b =>
                {
                    b.Property<Guid>("DepartmentsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("DivisionsId")
                        .HasColumnType("uuid");

                    b.HasKey("DepartmentsId", "DivisionsId");

                    b.HasIndex("DivisionsId");

                    b.ToTable("M_DepartmentM_Division");
                });

            modelBuilder.Entity("Entities.Models.CompanyContext.DepartmentDivisions", b =>
                {
                    b.HasOne("Entities.Models.CompanyContext.M_Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.CompanyContext.M_Division", "Division")
                        .WithMany()
                        .HasForeignKey("DivisionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Division");
                });

            modelBuilder.Entity("Entities.Models.CompanyContext.M_Department", b =>
                {
                    b.HasOne("Entities.Models.CompanyContext.M_Company", null)
                        .WithMany("Departments")
                        .HasForeignKey("M_CompanyId");
                });

            modelBuilder.Entity("M_DepartmentM_Division", b =>
                {
                    b.HasOne("Entities.Models.CompanyContext.M_Department", null)
                        .WithMany()
                        .HasForeignKey("DepartmentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.CompanyContext.M_Division", null)
                        .WithMany()
                        .HasForeignKey("DivisionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.CompanyContext.M_Company", b =>
                {
                    b.Navigation("Departments");
                });
#pragma warning restore 612, 618
        }
    }
}
