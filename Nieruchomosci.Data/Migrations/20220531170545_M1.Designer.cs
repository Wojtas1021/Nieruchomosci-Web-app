﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nieruchomosci.Data.Data;

#nullable disable

namespace Nieruchomosci.Data.Migrations
{
    [DbContext(typeof(NieruchomosciContext))]
    [Migration("20220531170545_M1")]
    partial class M1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Nieruchomosci.Data.Data.CMS.Aktualnosc", b =>
                {
                    b.Property<int>("IdAktualnosci")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAktualnosci"), 1L, 1);

                    b.Property<bool>("CzyAktywny")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataEdycji")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataUsuniecia")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataUtworzenia")
                        .HasColumnType("datetime2");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ikona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Komentarz")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("LinkTytul")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("Pozycja")
                        .HasColumnType("int");

                    b.Property<string>("PracownikDodajacy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PracownikEdytujacy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PracownikUsuwajacy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tresc")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Tytul")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("IdAktualnosci");

                    b.ToTable("Aktualnosc");
                });

            modelBuilder.Entity("Nieruchomosci.Data.Data.CMS.Parametr", b =>
                {
                    b.Property<int>("IdParametru")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdParametru"), 1L, 1);

                    b.Property<bool>("CzyAktywny")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataEdycji")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataUsuniecia")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataUtworzenia")
                        .HasColumnType("datetime2");

                    b.Property<string>("Kod")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Komentarz")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PracownikDodajacy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PracownikEdytujacy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PracownikUsuwajacy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Przycisk")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrescPrzycisku")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Wartosc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdParametru");

                    b.ToTable("Parametr");
                });

            modelBuilder.Entity("Nieruchomosci.Data.Data.CMS.Post", b =>
                {
                    b.Property<int>("IdPostu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPostu"), 1L, 1);

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CzyAktywny")
                        .HasColumnType("bit");

                    b.Property<bool>("CzyPubliczny")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataEdycji")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataPublikacji")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataUtworzenia")
                        .HasColumnType("datetime2");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ikona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Komentarz")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("LinkPostu")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Pozycja")
                        .HasColumnType("int");

                    b.Property<string>("Przycisk")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tresc")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Tytul")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("IdPostu");

                    b.ToTable("Post");
                });

            modelBuilder.Entity("Nieruchomosci.Data.Data.CMS.Rekomendacja", b =>
                {
                    b.Property<int>("IdRekomendacji")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRekomendacji"), 1L, 1);

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CzyAktywny")
                        .HasColumnType("bit");

                    b.Property<bool>("CzyPubliczny")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataEdycji")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataPublikacji")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataUtworzenia")
                        .HasColumnType("datetime2");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ikona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Komentarz")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("LinkRekomendacji")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("Ocena")
                        .HasColumnType("int");

                    b.Property<int>("Pozycja")
                        .HasColumnType("int");

                    b.Property<string>("Przycisk")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tresc")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.HasKey("IdRekomendacji");

                    b.ToTable("Rekomendacja");
                });

            modelBuilder.Entity("Nieruchomosci.Data.Data.CMS.Strona", b =>
                {
                    b.Property<int>("IdStrony")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdStrony"), 1L, 1);

                    b.Property<bool>("CzyAktywny")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataEdycji")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataUsuniecia")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataUtworzenia")
                        .HasColumnType("datetime2");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ikona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkTytul")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("Pozycja")
                        .HasColumnType("int");

                    b.Property<string>("PracownikDodajacy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PracownikEdytujacy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PracownikUsuwajacy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tresc")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Tytul")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("IdStrony");

                    b.ToTable("Strona");
                });

            modelBuilder.Entity("Nieruchomosci.Data.Data.Nieruchomosci.Dodatki", b =>
                {
                    b.Property<int>("IdDodatku")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDodatku"), 1L, 1);

                    b.Property<string>("Basen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CzyAktywny")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataEdycji")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataUsuniecia")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataUtworzenia")
                        .HasColumnType("datetime2");

                    b.Property<string>("Lazienka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Monitoring")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Parking")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PracownikDodajacy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PracownikEdytujacy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PracownikUsuwajacy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pralnia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Silownia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sypialnia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WiFi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdDodatku");

                    b.ToTable("Dodatki");
                });

            modelBuilder.Entity("Nieruchomosci.Data.Data.Nieruchomosci.Nieruchomosc", b =>
                {
                    b.Property<int>("IdNieruchomosci")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdNieruchomosci"), 1L, 1);

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Cena")
                        .IsRequired()
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("CzyAktywny")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataEdycji")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataUsuniecia")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataUtworzenia")
                        .HasColumnType("datetime2");

                    b.Property<int>("DodatkiIdDodatku")
                        .HasColumnType("int");

                    b.Property<string>("Forma")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdDodatku")
                        .HasColumnType("int");

                    b.Property<int>("IdRodzajuNieruchomosci")
                        .HasColumnType("int");

                    b.Property<int?>("Ocena")
                        .HasColumnType("int");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Osoby")
                        .HasColumnType("int");

                    b.Property<string>("Powierzchnia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PracownikDodajacy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PracownikEdytujacy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PracownikUsuwajacy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RodzajNieruchomosciIdRodzajuNieruchomosci")
                        .HasColumnType("int");

                    b.Property<string>("Tytul")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.HasKey("IdNieruchomosci");

                    b.HasIndex("DodatkiIdDodatku");

                    b.HasIndex("RodzajNieruchomosciIdRodzajuNieruchomosci");

                    b.ToTable("Nieruchomosc");
                });

            modelBuilder.Entity("Nieruchomosci.Data.Data.Nieruchomosci.RodzajNieruchomosci", b =>
                {
                    b.Property<int>("IdRodzajuNieruchomosci")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRodzajuNieruchomosci"), 1L, 1);

                    b.Property<bool>("CzyAktywny")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataEdycji")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataUsuniecia")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataUtworzenia")
                        .HasColumnType("datetime2");

                    b.Property<string>("Kod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("PracownikDodajacy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PracownikEdytujacy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PracownikUsuwajacy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdRodzajuNieruchomosci");

                    b.ToTable("RodzajNieruchomosci");
                });

            modelBuilder.Entity("Nieruchomosci.Data.Data.Nieruchomosci.Nieruchomosc", b =>
                {
                    b.HasOne("Nieruchomosci.Data.Data.Nieruchomosci.Dodatki", "Dodatki")
                        .WithMany("Nieruchomosc")
                        .HasForeignKey("DodatkiIdDodatku")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nieruchomosci.Data.Data.Nieruchomosci.RodzajNieruchomosci", "RodzajNieruchomosci")
                        .WithMany("Nieruchomosc")
                        .HasForeignKey("RodzajNieruchomosciIdRodzajuNieruchomosci")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dodatki");

                    b.Navigation("RodzajNieruchomosci");
                });

            modelBuilder.Entity("Nieruchomosci.Data.Data.Nieruchomosci.Dodatki", b =>
                {
                    b.Navigation("Nieruchomosc");
                });

            modelBuilder.Entity("Nieruchomosci.Data.Data.Nieruchomosci.RodzajNieruchomosci", b =>
                {
                    b.Navigation("Nieruchomosc");
                });
#pragma warning restore 612, 618
        }
    }
}
