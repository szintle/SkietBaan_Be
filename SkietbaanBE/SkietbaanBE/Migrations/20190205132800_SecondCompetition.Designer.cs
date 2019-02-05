﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SkietbaanBE.Models;
using System;

namespace SkietbaanBE.Migrations
{
    [DbContext(typeof(ModelsContext))]
    [Migration("20190205132800_SecondCompetition")]
    partial class SecondCompetition
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SkietbaanBE.Models.Competition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<bool>("Status");

                    b.HasKey("Id");

                    b.ToTable("Competition");
                });

            modelBuilder.Entity("SkietbaanBE.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Admin");

                    b.Property<string>("Email");

                    b.Property<DateTime>("EntryDate");

                    b.Property<DateTime>("MemberExpiry");

                    b.Property<string>("MemberID");

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
