﻿// <auto-generated />
using MVCWatches.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVCWatches.Migrations
{
    [DbContext(typeof(MVCWatchesContext))]
    [Migration("20220918171941_AddWatchesToDb")]
    partial class AddWatchesToDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MVCWatches.Models.Watches", b =>
                {
                    b.Property<int>("IDWatch")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDWatch"), 1L, 1);

                    b.Property<string>("Ano")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Categoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Valor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDWatch");

                    b.ToTable("Watches");
                });
#pragma warning restore 612, 618
        }
    }
}
