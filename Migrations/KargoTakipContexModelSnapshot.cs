﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Model.Contexts;

#nullable disable

namespace EntityFrameWork_1_5.Migrations
{
    [DbContext(typeof(KargoTakipContex))]
    partial class KargoTakipContexModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.2.23128.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Model.Entity.Fatura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("FaturaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("SiporisId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Faturas");
                });

            modelBuilder.Entity("Model.Entity.KargoFirmasi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KargoAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SiparisId")
                        .HasColumnType("int");

                    b.Property<string>("Temsilci")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("kargoFirmasis");
                });

            modelBuilder.Entity("Model.Entity.Kategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("KategoriAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UrunId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UrunId");

                    b.ToTable("kategoris");
                });

            modelBuilder.Entity("Model.Entity.Musteri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IlId")
                        .HasColumnType("int");

                    b.Property<string>("KimlikNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MusteriAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MusteriSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IlId")
                        .IsUnique();

                    b.ToTable("Musteris");
                });

            modelBuilder.Entity("Model.Entity.SatisTemsilcisi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("SatisTemsilcisiAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SatisTemsilcisiSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SiparisId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SiparisId");

                    b.ToTable("SatisTemsilcisis");
                });

            modelBuilder.Entity("Model.Entity.Siparis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FaturaId")
                        .HasColumnType("int");

                    b.Property<int>("KargoFirmasiId")
                        .HasColumnType("int");

                    b.Property<int>("MusteriId")
                        .HasColumnType("int");

                    b.Property<int>("SatisTemsilcisiId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SiparisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("SiparisUrunId")
                        .HasColumnType("int");

                    b.Property<decimal>("ToplamTutar")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("FaturaId")
                        .IsUnique();

                    b.HasIndex("KargoFirmasiId");

                    b.HasIndex("MusteriId");

                    b.ToTable("Siparis");
                });

            modelBuilder.Entity("Model.Entity.SiparisUrun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("BirimFiyati")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Miktari")
                        .HasColumnType("int");

                    b.Property<int>("SiparisId")
                        .HasColumnType("int");

                    b.Property<int>("UrunId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UrunId");

                    b.ToTable("SiparisUruns");
                });

            modelBuilder.Entity("Model.Entity.Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BirimFiyati")
                        .HasColumnType("int");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<int>("SiparisUrunId")
                        .HasColumnType("int");

                    b.Property<int>("StokMiktari")
                        .HasColumnType("int");

                    b.Property<string>("UrunAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Urun");
                });

            modelBuilder.Entity("Model.Entity.il", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("IlAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ils");
                });

            modelBuilder.Entity("SiparisSiparisUrun", b =>
                {
                    b.Property<int>("SiparisId")
                        .HasColumnType("int");

                    b.Property<int>("SiparisUrunId")
                        .HasColumnType("int");

                    b.HasKey("SiparisId", "SiparisUrunId");

                    b.HasIndex("SiparisUrunId");

                    b.ToTable("SiparisSiparisUrun");
                });

            modelBuilder.Entity("Model.Entity.Kategori", b =>
                {
                    b.HasOne("Model.Entity.Urun", "Urun")
                        .WithMany("Kategori")
                        .HasForeignKey("UrunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("Model.Entity.Musteri", b =>
                {
                    b.HasOne("Model.Entity.il", "il")
                        .WithOne("Musteri")
                        .HasForeignKey("Model.Entity.Musteri", "IlId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("il");
                });

            modelBuilder.Entity("Model.Entity.SatisTemsilcisi", b =>
                {
                    b.HasOne("Model.Entity.Siparis", "Siparis")
                        .WithMany("SatisTemsilcisi")
                        .HasForeignKey("SiparisId");

                    b.Navigation("Siparis");
                });

            modelBuilder.Entity("Model.Entity.Siparis", b =>
                {
                    b.HasOne("Model.Entity.Fatura", "Fatura")
                        .WithOne("Siparis")
                        .HasForeignKey("Model.Entity.Siparis", "FaturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entity.KargoFirmasi", "KargoFirmasi")
                        .WithMany("Siparis")
                        .HasForeignKey("KargoFirmasiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entity.Musteri", "Musteri")
                        .WithMany()
                        .HasForeignKey("MusteriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fatura");

                    b.Navigation("KargoFirmasi");

                    b.Navigation("Musteri");
                });

            modelBuilder.Entity("Model.Entity.SiparisUrun", b =>
                {
                    b.HasOne("Model.Entity.Urun", "Urun")
                        .WithMany("SiparisUruns")
                        .HasForeignKey("UrunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("SiparisSiparisUrun", b =>
                {
                    b.HasOne("Model.Entity.Siparis", null)
                        .WithMany()
                        .HasForeignKey("SiparisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entity.SiparisUrun", null)
                        .WithMany()
                        .HasForeignKey("SiparisUrunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.Entity.Fatura", b =>
                {
                    b.Navigation("Siparis");
                });

            modelBuilder.Entity("Model.Entity.KargoFirmasi", b =>
                {
                    b.Navigation("Siparis");
                });

            modelBuilder.Entity("Model.Entity.Siparis", b =>
                {
                    b.Navigation("SatisTemsilcisi");
                });

            modelBuilder.Entity("Model.Entity.Urun", b =>
                {
                    b.Navigation("Kategori");

                    b.Navigation("SiparisUruns");
                });

            modelBuilder.Entity("Model.Entity.il", b =>
                {
                    b.Navigation("Musteri");
                });
#pragma warning restore 612, 618
        }
    }
}
