﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using migration_tester.Dbcontext;

#nullable disable

namespace migration_tester.Migrations
{
    [DbContext(typeof(Dbtest))]
    [Migration("20220711175407_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("migration_tester.Model.Test", b =>
                {
                    b.Property<string>("one")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("three")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("two")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("one");

                    b.ToTable("tests");
                });
#pragma warning restore 612, 618
        }
    }
}
