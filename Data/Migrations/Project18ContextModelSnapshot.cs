﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using Project18.Data;

namespace Project18.Data.Migrations
{
    [DbContext(typeof(Project18Context))]
    partial class Project18ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("Project18.Data.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ArtistId");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(160);

                    b.HasKey("AlbumId");

                    b.HasIndex("ArtistId");

                    b.ToTable("Album");
                });

            modelBuilder.Entity("Project18.Data.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(120);

                    b.HasKey("ArtistId");

                    b.ToTable("Artist");
                });

            modelBuilder.Entity("Project18.Data.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Fax")
                        .IsRequired()
                        .HasMaxLength(24);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(24);

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<int>("SupportRepId");

                    b.HasKey("CustomerId");

                    b.HasIndex("SupportRepId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Project18.Data.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Fax")
                        .IsRequired()
                        .HasMaxLength(24);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(24);

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<int>("ReportsTo");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("EmployeeId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("Project18.Data.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(120);

                    b.HasKey("GenreId");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("Project18.Data.Invoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BillingAddress")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.Property<string>("BillingCity")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("BillingCountry")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("BillingPostalCode")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("BillingState")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<int>("CustomerId");

                    b.Property<DateTime>("InvoiceDate")
                        .HasColumnType("datetime");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("InvoiceId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Invoice");
                });

            modelBuilder.Entity("Project18.Data.InvoiceItem", b =>
                {
                    b.Property<int>("InvoiceLineId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("InvoiceId");

                    b.Property<int>("Quantity");

                    b.Property<int>("TrackId");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("InvoiceLineId");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("TrackId");

                    b.ToTable("InvoiceItem");
                });

            modelBuilder.Entity("Project18.Data.MediaType", b =>
                {
                    b.Property<int>("MediaTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(120);

                    b.HasKey("MediaTypeId");

                    b.ToTable("MediaType");
                });

            modelBuilder.Entity("Project18.Data.Playlist", b =>
                {
                    b.Property<int>("PlaylistId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(120);

                    b.HasKey("PlaylistId");

                    b.ToTable("Playlist");
                });

            modelBuilder.Entity("Project18.Data.PlaylistTrack", b =>
                {
                    b.Property<int>("PlaylistId");

                    b.Property<int>("TrackId");

                    b.HasKey("PlaylistId", "TrackId");

                    b.HasIndex("TrackId");

                    b.ToTable("PlaylistTrack");
                });

            modelBuilder.Entity("Project18.Data.Track", b =>
                {
                    b.Property<int>("TrackId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AlbumId");

                    b.Property<int>("Bytes");

                    b.Property<string>("Composer")
                        .IsRequired()
                        .HasMaxLength(220);

                    b.Property<int>("GenreId");

                    b.Property<int>("MediaTypeId");

                    b.Property<int>("Milliseconds");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("TrackId");

                    b.HasIndex("AlbumId");

                    b.HasIndex("GenreId");

                    b.HasIndex("MediaTypeId");

                    b.ToTable("Track");
                });

            modelBuilder.Entity("Project18.Data.Album", b =>
                {
                    b.HasOne("Project18.Data.Artist", "Artist")
                        .WithMany("Album")
                        .HasForeignKey("ArtistId")
                        .HasConstraintName("FK_Album_Artist");
                });

            modelBuilder.Entity("Project18.Data.Customer", b =>
                {
                    b.HasOne("Project18.Data.Employee", "SupportRep")
                        .WithMany("Customer")
                        .HasForeignKey("SupportRepId")
                        .HasConstraintName("FK_Customer_Employee");
                });

            modelBuilder.Entity("Project18.Data.Invoice", b =>
                {
                    b.HasOne("Project18.Data.Customer", "Customer")
                        .WithMany("Invoice")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_Invoice_Customer");
                });

            modelBuilder.Entity("Project18.Data.InvoiceItem", b =>
                {
                    b.HasOne("Project18.Data.Invoice", "Invoice")
                        .WithMany("InvoiceItem")
                        .HasForeignKey("InvoiceId")
                        .HasConstraintName("FK_InvoiceItem_Invoice");

                    b.HasOne("Project18.Data.Track", "Track")
                        .WithMany("InvoiceItem")
                        .HasForeignKey("TrackId")
                        .HasConstraintName("FK_InvoiceItem_Track");
                });

            modelBuilder.Entity("Project18.Data.PlaylistTrack", b =>
                {
                    b.HasOne("Project18.Data.Playlist", "Playlist")
                        .WithMany("PlaylistTrack")
                        .HasForeignKey("PlaylistId")
                        .HasConstraintName("FK_PlaylistTrack_Playlist");

                    b.HasOne("Project18.Data.Track", "Track")
                        .WithMany("PlaylistTrack")
                        .HasForeignKey("TrackId")
                        .HasConstraintName("FK_PlaylistTrack_Track");
                });

            modelBuilder.Entity("Project18.Data.Track", b =>
                {
                    b.HasOne("Project18.Data.Album", "Album")
                        .WithMany("Track")
                        .HasForeignKey("AlbumId")
                        .HasConstraintName("FK_Track_Album");

                    b.HasOne("Project18.Data.Genre", "Genre")
                        .WithMany("Track")
                        .HasForeignKey("GenreId")
                        .HasConstraintName("FK_Track_Genre");

                    b.HasOne("Project18.Data.MediaType", "MediaType")
                        .WithMany("Track")
                        .HasForeignKey("MediaTypeId")
                        .HasConstraintName("FK_Track_MediaType");
                });
#pragma warning restore 612, 618
        }
    }
}
