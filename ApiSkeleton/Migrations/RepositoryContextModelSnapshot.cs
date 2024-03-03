﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Repository;

#nullable disable

namespace ApiSkeleton.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Entities.Models.Komentar", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<TimeSpan>("CreatedAt")
                        .HasColumnType("interval");

                    b.Property<Guid>("IdProduk")
                        .HasColumnType("uuid");

                    b.Property<string>("IsiKomentar")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<TimeSpan>("ModifiedAt")
                        .HasColumnType("interval");

                    b.HasKey("Id");

                    b.HasIndex("IdProduk");

                    b.ToTable("KomentarProduk");
                });

            modelBuilder.Entity("Entities.Models.Pemesan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Alamat")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<TimeSpan>("CreatedAt")
                        .HasColumnType("interval");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Kodepost")
                        .HasColumnType("integer");

                    b.Property<string>("Kota_Kab")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<TimeSpan>("ModifiedAt")
                        .HasColumnType("interval");

                    b.Property<string>("Nama")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Provinsi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Pemesan");
                });

            modelBuilder.Entity("Entities.Models.Pesanan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdPemesan")
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdProduk")
                        .HasColumnType("uuid");

                    b.Property<char>("Tipe")
                        .HasColumnType("character(1)");

                    b.Property<char>("Ukuran")
                        .HasColumnType("character(1)");

                    b.HasKey("Id");

                    b.HasIndex("IdPemesan");

                    b.HasIndex("IdProduk");

                    b.ToTable("Pesanan");
                });

            modelBuilder.Entity("Entities.Models.Produk", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<TimeSpan>("CreatedAt")
                        .HasColumnType("interval");

                    b.Property<string>("Deskripsi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Harga")
                        .HasColumnType("integer");

                    b.Property<TimeSpan>("ModifiedAt")
                        .HasColumnType("interval");

                    b.Property<string>("Nama")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Rating")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Produk");
                });

            modelBuilder.Entity("Entities.Models.Komentar", b =>
                {
                    b.HasOne("Entities.Models.Produk", "Produk")
                        .WithMany()
                        .HasForeignKey("IdProduk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produk");
                });

            modelBuilder.Entity("Entities.Models.Pesanan", b =>
                {
                    b.HasOne("Entities.Models.Pemesan", "Pemesan")
                        .WithMany()
                        .HasForeignKey("IdPemesan")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.Produk", "Produk")
                        .WithMany()
                        .HasForeignKey("IdProduk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pemesan");

                    b.Navigation("Produk");
                });
#pragma warning restore 612, 618
        }
    }
}
