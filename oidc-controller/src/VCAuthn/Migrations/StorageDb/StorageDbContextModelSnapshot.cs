﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using VCAuthn.Migrations;

namespace VCAuthn.Migrations
{
    [DbContext(typeof(StorageDbContext))]
    partial class StorageDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("VCAuthn.Models.AuthSession", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ExpiredTimestamp");

                    b.Property<string>("PresentationRecordId");

                    b.Property<string>("PresentationRequest");

                    b.Property<string>("PresentationRequestId");

                    b.Property<bool>("PresentationRequestSatisfied");

                    b.Property<string>("Proof");

                    b.Property<string>("RequestParams");

                    b.HasKey("Id");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("VCAuthn.Models.MappedUrl", b =>
                {
                    b.Property<string>("Key")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Url");

                    b.HasKey("Key");

                    b.ToTable("MappedUrls");
                });

            modelBuilder.Entity("VCAuthn.Models.PresentationConfiguration", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Config");

                    b.Property<string>("SubjectIdentifier");

                    b.HasKey("Id");

                    b.ToTable("PresentationConfigurations");
                });
#pragma warning restore 612, 618
        }
    }
}
