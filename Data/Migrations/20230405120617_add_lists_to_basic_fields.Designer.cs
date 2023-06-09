﻿// <auto-generated />
using System;
using CMS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CMS.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230405120617_add_lists_to_basic_fields")]
    partial class add_lists_to_basic_fields
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CMS.Model.BasicField", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ContentTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Required")
                        .HasColumnType("bit");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContentTypeId");

                    b.ToTable("Fields");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2f13b251-1c10-4556-9bee-f65810d0d412"),
                            ContentTypeId = new Guid("11b39c09-0658-4fb8-bd98-08d6567722f9"),
                            Name = "Creator",
                            Type = 0,
                            Value = "Regixx"
                        },
                        new
                        {
                            Id = new Guid("09a06835-9c14-4d4c-a418-18c98080a4b5"),
                            ContentTypeId = new Guid("11b39c09-0658-4fb8-bd98-08d6567722f9"),
                            Name = "TrailerVideo",
                            Type = 4,
                            Value = "http://"
                        },
                        new
                        {
                            Id = new Guid("39295625-2cde-42c5-9d73-792be629ba5b"),
                            ContentTypeId = new Guid("145fb6b8-8416-4735-bbe6-60b9ad829f81"),
                            Name = "DescriptionText",
                            Type = 0,
                            Value = "Best game ever"
                        },
                        new
                        {
                            Id = new Guid("416b9ccb-5e71-4b79-a640-8969cf091e55"),
                            ContentTypeId = new Guid("509730d7-3b0c-4dc4-8173-98cce5e98afa"),
                            Name = "Name",
                            Type = 0,
                            Value = "Star Wars"
                        },
                        new
                        {
                            Id = new Guid("8eb20398-a6b8-4d95-9a78-7bd1c36b1872"),
                            ContentTypeId = new Guid("509730d7-3b0c-4dc4-8173-98cce5e98afa"),
                            Name = "Year",
                            Type = 1,
                            Value = "2007"
                        },
                        new
                        {
                            Id = new Guid("dfc097d2-f322-4c85-bd06-025740e4be0e"),
                            ContentTypeId = new Guid("94fd58bc-90c8-4398-b9c0-f9878e652e0d"),
                            Name = "Name",
                            Type = 0,
                            Value = "Santa Monica"
                        },
                        new
                        {
                            Id = new Guid("ce07415d-9b1f-4869-b68e-f40c27172a48"),
                            ContentTypeId = new Guid("94fd58bc-90c8-4398-b9c0-f9878e652e0d"),
                            Name = "Location",
                            Type = 0,
                            Value = "USA"
                        },
                        new
                        {
                            Id = new Guid("f13a8351-1092-4e53-a43f-44dab8e326bb"),
                            ContentTypeId = new Guid("c3b18a44-3f0e-4b28-867c-fb46723094ee"),
                            Name = "indField1",
                            Type = 0,
                            Value = "value-1"
                        },
                        new
                        {
                            Id = new Guid("9053344d-51f8-44d0-90ca-9517d32aa9bf"),
                            ContentTypeId = new Guid("c3b18a44-3f0e-4b28-867c-fb46723094ee"),
                            Name = "indField2",
                            Type = 1,
                            Value = "4"
                        },
                        new
                        {
                            Id = new Guid("567cfad1-7b3f-4e40-bd03-24f0c5bbc910"),
                            ContentTypeId = new Guid("3b3a48dc-1aa0-4026-bd55-bfbe74ccd99d"),
                            Name = "ind2Field",
                            Type = 0,
                            Value = "valueee1"
                        });
                });

            modelBuilder.Entity("CMS.Model.ContentType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid>("SpaceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SysId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SysId");

                    b.ToTable("ContentTypes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("11b39c09-0658-4fb8-bd98-08d6567722f9"),
                            Name = "Trailer",
                            SpaceId = new Guid("0e824164-c360-497b-bf71-e20b47282bbe")
                        },
                        new
                        {
                            Id = new Guid("145fb6b8-8416-4735-bbe6-60b9ad829f81"),
                            Name = "Description",
                            SpaceId = new Guid("0e824164-c360-497b-bf71-e20b47282bbe")
                        },
                        new
                        {
                            Id = new Guid("509730d7-3b0c-4dc4-8173-98cce5e98afa"),
                            Description = "The game is ...",
                            Name = "Game",
                            SpaceId = new Guid("0e824164-c360-497b-bf71-e20b47282bbe")
                        },
                        new
                        {
                            Id = new Guid("94fd58bc-90c8-4398-b9c0-f9878e652e0d"),
                            Description = "Best publisher game award for the previous year",
                            Name = "Publisher",
                            SpaceId = new Guid("0e824164-c360-497b-bf71-e20b47282bbe")
                        },
                        new
                        {
                            Id = new Guid("c3b18a44-3f0e-4b28-867c-fb46723094ee"),
                            Description = "Description for the independent type",
                            Name = "independen 2",
                            SpaceId = new Guid("0e824164-c360-497b-bf71-e20b47282bbe")
                        },
                        new
                        {
                            Id = new Guid("3b3a48dc-1aa0-4026-bd55-bfbe74ccd99d"),
                            Description = "Some other description",
                            Name = "independent 3",
                            SpaceId = new Guid("0e824164-c360-497b-bf71-e20b47282bbe")
                        });
                });

            modelBuilder.Entity("CMS.Model.ContentTypeReferences", b =>
                {
                    b.Property<Guid>("ParentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ChildId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ParentId", "ChildId");

                    b.HasIndex("ChildId");

                    b.ToTable("ContentTypeReferences");

                    b.HasData(
                        new
                        {
                            ParentId = new Guid("145fb6b8-8416-4735-bbe6-60b9ad829f81"),
                            ChildId = new Guid("11b39c09-0658-4fb8-bd98-08d6567722f9")
                        },
                        new
                        {
                            ParentId = new Guid("509730d7-3b0c-4dc4-8173-98cce5e98afa"),
                            ChildId = new Guid("145fb6b8-8416-4735-bbe6-60b9ad829f81")
                        },
                        new
                        {
                            ParentId = new Guid("509730d7-3b0c-4dc4-8173-98cce5e98afa"),
                            ChildId = new Guid("94fd58bc-90c8-4398-b9c0-f9878e652e0d")
                        });
                });

            modelBuilder.Entity("CMS.Model.Organization", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("Id");

                    b.ToTable("Organizations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("44449bda-f8b9-44cd-b11a-ab47a417481d"),
                            Name = "Org1"
                        },
                        new
                        {
                            Id = new Guid("b6207be1-cb0b-4298-b2a5-de950e2c339f"),
                            Name = "Organization 2"
                        },
                        new
                        {
                            Id = new Guid("871494fd-1112-4f88-bd5a-c9daa8e6e650"),
                            Name = "Third oorg"
                        });
                });

            modelBuilder.Entity("CMS.Model.Space", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("OrganizationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Spaces");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0e824164-c360-497b-bf71-e20b47282bbe"),
                            Name = "Game shop",
                            OrganizationId = new Guid("44449bda-f8b9-44cd-b11a-ab47a417481d")
                        });
                });

            modelBuilder.Entity("CMS.Model.Sys", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("FirstPublishedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("LinkType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublishedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sys");
                });

            modelBuilder.Entity("CMS.Model.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("UserRole")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("04bcded5-2d24-4d24-abfc-47967ed34bc4"),
                            UserRole = 0
                        },
                        new
                        {
                            Id = new Guid("5d1d518e-a7e2-4918-9249-47620d173c38"),
                            UserRole = 1
                        },
                        new
                        {
                            Id = new Guid("5de99182-49cf-4e5b-963b-999788b017e7"),
                            UserRole = 0
                        });
                });

            modelBuilder.Entity("Models.ListItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<Guid?>("BasicFieldId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BasicFieldId");

                    b.ToTable("ListItem");
                });

            modelBuilder.Entity("Models.OrganizationUser", b =>
                {
                    b.Property<Guid>("OrganizationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("OrganizationId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("OrganizationUser");

                    b.HasData(
                        new
                        {
                            OrganizationId = new Guid("44449bda-f8b9-44cd-b11a-ab47a417481d"),
                            UserId = new Guid("04bcded5-2d24-4d24-abfc-47967ed34bc4")
                        },
                        new
                        {
                            OrganizationId = new Guid("44449bda-f8b9-44cd-b11a-ab47a417481d"),
                            UserId = new Guid("5d1d518e-a7e2-4918-9249-47620d173c38")
                        });
                });

            modelBuilder.Entity("CMS.Model.BasicField", b =>
                {
                    b.HasOne("CMS.Model.ContentType", "ContentType")
                        .WithMany("BasicFields")
                        .HasForeignKey("ContentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ContentType");
                });

            modelBuilder.Entity("CMS.Model.ContentType", b =>
                {
                    b.HasOne("CMS.Model.Sys", "Sys")
                        .WithMany()
                        .HasForeignKey("SysId");

                    b.Navigation("Sys");
                });

            modelBuilder.Entity("CMS.Model.ContentTypeReferences", b =>
                {
                    b.HasOne("CMS.Model.ContentType", "ChildEntity")
                        .WithMany("Parents")
                        .HasForeignKey("ChildId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CMS.Model.ContentType", "ParentEntity")
                        .WithMany("Children")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ChildEntity");

                    b.Navigation("ParentEntity");
                });

            modelBuilder.Entity("CMS.Model.Space", b =>
                {
                    b.HasOne("CMS.Model.Organization", "Organization")
                        .WithMany("Spaces")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Models.ListItem", b =>
                {
                    b.HasOne("CMS.Model.BasicField", "BasicField")
                        .WithMany("ListItems")
                        .HasForeignKey("BasicFieldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BasicField");
                });

            modelBuilder.Entity("Models.OrganizationUser", b =>
                {
                    b.HasOne("CMS.Model.Organization", "Organization")
                        .WithMany("OrganizationUser")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CMS.Model.User", "User")
                        .WithMany("OrganizationUser")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organization");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CMS.Model.BasicField", b =>
                {
                    b.Navigation("ListItems");
                });

            modelBuilder.Entity("CMS.Model.ContentType", b =>
                {
                    b.Navigation("BasicFields");

                    b.Navigation("Children");

                    b.Navigation("Parents");
                });

            modelBuilder.Entity("CMS.Model.Organization", b =>
                {
                    b.Navigation("OrganizationUser");

                    b.Navigation("Spaces");
                });

            modelBuilder.Entity("CMS.Model.User", b =>
                {
                    b.Navigation("OrganizationUser");
                });
#pragma warning restore 612, 618
        }
    }
}
