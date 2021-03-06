﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NaijaEvent.Domain.Entities;
using NaijaEvent.Persistance;

namespace NaijaEvent.Persistance.Migrations
{
    [DbContext(typeof(NaijaEventContext))]
    [Migration("20190528194934_initialCreate")]
    partial class initialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NaijaEvent.Domain.Entities.NEvent", b =>
                {
                    b.Property<Guid>("EventId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("EventName");

                    b.Property<Guid>("Eventid");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("EventId");

                    b.ToTable("NEvents").HasData(new   {

                      EventName = "The First",
                      Description="This is the very first",
                      EndDate = new DateTime(2009,04,5),
                        StartDate = new DateTime(2009, 04, 5)


                    });
                });
#pragma warning restore 612, 618
        }
    }
}
