﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api.model;

#nullable disable

namespace api.Migrations
{
    [DbContext(typeof(MySqlContext))]
    partial class MySqlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8_general_ci")
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8");

            modelBuilder.Entity("api.model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("create_time");

                    b.Property<string>("CreateUser")
                        .HasColumnType("longtext")
                        .HasColumnName("create_user");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("password");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("update_time");

                    b.Property<string>("UpdateUser")
                        .HasColumnType("longtext")
                        .HasColumnName("update_user");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("username");

                    b.HasKey("Id");

                    b.ToTable("sys_user", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
