﻿// <auto-generated />
using System;
using ControlSystem.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ControlSystem.Infrastructure.Core.Data.Migrations
{
    [DbContext(typeof(SystemContext))]
    partial class SystemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ControlSystem.Domain.Entities.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("PersonId");

                    b.Property<int>("Age")
                        .HasColumnType("integer")
                        .HasColumnName("Age");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("BirthDay");

                    b.Property<string>("Identity")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("character varying(9)")
                        .HasColumnName("Identity");

                    b.Property<string>("IndividualRegistration")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("character varying(11)")
                        .HasColumnName("IndividualRegistration");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)")
                        .HasColumnName("NamePerson");

                    b.Property<bool>("Working")
                        .HasColumnType("boolean")
                        .HasColumnName("Working");

                    b.HasKey("Id")
                        .HasName("PersonId");

                    b.ToTable("People", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
