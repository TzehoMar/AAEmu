﻿﻿// <auto-generated />

 using System;
 using AAEmu.Login.Models;
 using Microsoft.EntityFrameworkCore;
 using Microsoft.EntityFrameworkCore.Infrastructure;
 using Microsoft.EntityFrameworkCore.Migrations;
 using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

 namespace AAEmu.Login.Migrations
{
    [DbContext(typeof(AuthContext))]
    [Migration("20200303023336_AccountIdToUlong")]
    partial class AccountIdToUlong
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("AAEmu.Shared.Database.Models.PostgreSql.Account", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(20,0)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("LastIp")
                        .HasColumnType("text");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("timestamp without time zone");

                    b.Property<byte>("Level")
                        .HasColumnType("smallint");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("AAEmu.Shared.Database.Models.PostgreSql.GameServer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<int>("Color")
                        .HasColumnType("integer");

                    b.Property<bool>("Hidden")
                        .HasColumnType("boolean");

                    b.Property<string>("Host")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Port")
                        .HasColumnType("integer");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("GameServers");
                });
#pragma warning restore 612, 618
        }
    }
}
