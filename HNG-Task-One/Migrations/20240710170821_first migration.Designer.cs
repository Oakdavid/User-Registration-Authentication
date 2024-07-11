﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using User_Registartion.Context;

#nullable disable

namespace User_Registartion.Migrations
{
    [DbContext(typeof(UserDBContext))]
    [Migration("20240710170821_first migration")]
    partial class firstmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("OrganisationUser", b =>
                {
                    b.Property<string>("OrganisationsOrgId")
                        .HasColumnType("text");

                    b.Property<string>("UsersUserId")
                        .HasColumnType("text");

                    b.HasKey("OrganisationsOrgId", "UsersUserId");

                    b.HasIndex("UsersUserId");

                    b.ToTable("OrganisationUser");
                });

            modelBuilder.Entity("User_Registartion.Entity.Organisation", b =>
                {
                    b.Property<string>("OrgId")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("OrgId");

                    b.ToTable("Organisations");
                });

            modelBuilder.Entity("User_Registartion.Entity.User", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("OrganisationUser", b =>
                {
                    b.HasOne("User_Registartion.Entity.Organisation", null)
                        .WithMany()
                        .HasForeignKey("OrganisationsOrgId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("User_Registartion.Entity.User", null)
                        .WithMany()
                        .HasForeignKey("UsersUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
