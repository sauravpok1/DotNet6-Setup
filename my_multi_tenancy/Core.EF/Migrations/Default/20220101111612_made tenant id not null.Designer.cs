﻿// <auto-generated />
using System;
using Core.EF.Data.Context.Default;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Core.EF.Migrations.Default
{
    [DbContext(typeof(DefaultContext))]
    [Migration("20220101111612_made tenant id not null")]
    partial class madetenantidnotnull
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Core.EF.IdentityModels.ApplicationRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text")
                        .HasColumnName("concurrency_stamp");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid")
                        .HasColumnName("created_by");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_on");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uuid")
                        .HasColumnName("deleted_by");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deleted_on");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_deleted");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid")
                        .HasColumnName("modified_by");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("modified_on");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("text")
                        .HasColumnName("normalized_name");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uuid")
                        .HasColumnName("tenant_id");

                    b.HasKey("Id")
                        .HasName("pk_role");

                    b.HasIndex("NormalizedName")
                        .HasDatabaseName("ix_role_normalized_name");

                    b.HasIndex("NormalizedName", "TenantId")
                        .IsUnique()
                        .HasDatabaseName("ix_role_normalized_name_tenant_id");

                    b.ToTable("role", "dbo");
                });

            modelBuilder.Entity("Core.EF.IdentityModels.ApplicationRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text")
                        .HasColumnName("claim_type");

                    b.Property<string>("ClaimValue")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("claim_value");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid")
                        .HasColumnName("role_id");

                    b.HasKey("Id")
                        .HasName("pk_role_claim");

                    b.HasIndex("RoleId")
                        .HasDatabaseName("ix_role_claim_role_id");

                    b.ToTable("role_claim", "dbo");
                });

            modelBuilder.Entity("Core.EF.IdentityModels.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer")
                        .HasColumnName("access_failed_count");

                    b.Property<Guid>("BranchId")
                        .HasColumnType("uuid")
                        .HasColumnName("branch_id");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text")
                        .HasColumnName("concurrency_stamp");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid")
                        .HasColumnName("created_by");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_on");

                    b.Property<DateTime?>("DOB")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("dob");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uuid")
                        .HasColumnName("deleted_by");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deleted_on");

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean")
                        .HasColumnName("email_confirmed");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("first_name");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text")
                        .HasColumnName("image_url");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true)
                        .HasColumnName("is_active");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_deleted");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("last_name");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean")
                        .HasColumnName("lockout_enabled");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("lockout_end");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid")
                        .HasColumnName("modified_by");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("modified_on");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("text")
                        .HasColumnName("normalized_email");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("text")
                        .HasColumnName("normalized_user_name");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text")
                        .HasColumnName("password_hash");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text")
                        .HasColumnName("phone_number");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean")
                        .HasColumnName("phone_number_confirmed");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text")
                        .HasColumnName("security_stamp");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uuid")
                        .HasColumnName("tenant_id");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean")
                        .HasColumnName("two_factor_enabled");

                    b.Property<string>("UserName")
                        .HasColumnType("text")
                        .HasColumnName("user_name");

                    b.HasKey("Id")
                        .HasName("pk_user");

                    b.ToTable("user", "dbo");
                });

            modelBuilder.Entity("Core.EF.IdentityModels.ApplicationUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text")
                        .HasColumnName("claim_type");

                    b.Property<string>("ClaimValue")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("claim_value");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_user_claim");

                    b.ToTable("user_claim", "dbo");
                });

            modelBuilder.Entity("Core.EF.IdentityModels.ApplicationUserLogin", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text")
                        .HasColumnName("login_provider");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text")
                        .HasColumnName("provider_display_name");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text")
                        .HasColumnName("provider_key");

                    b.HasKey("UserId")
                        .HasName("pk_user_login");

                    b.ToTable("user_login", "dbo");
                });

            modelBuilder.Entity("Core.EF.IdentityModels.ApplicationUserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid")
                        .HasColumnName("role_id");

                    b.HasKey("UserId", "RoleId")
                        .HasName("pk_user_role");

                    b.HasIndex("RoleId")
                        .HasDatabaseName("ix_user_role_role_id");

                    b.ToTable("user_role", "dbo");
                });

            modelBuilder.Entity("Core.EF.IdentityModels.ApplicationUserToken", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text")
                        .HasColumnName("login_provider");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Value")
                        .HasColumnType("text")
                        .HasColumnName("value");

                    b.HasKey("UserId")
                        .HasName("pk_user_token");

                    b.ToTable("user_token", "dbo");
                });

            modelBuilder.Entity("Core.Entities.Tenant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Database")
                        .HasColumnType("text")
                        .HasColumnName("database");

                    b.Property<int>("DatabaseType")
                        .HasColumnType("integer")
                        .HasColumnName("database_type");

                    b.Property<string>("Identifier")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("identifier");

                    b.Property<string>("Password")
                        .HasColumnType("text")
                        .HasColumnName("password");

                    b.Property<string>("Port")
                        .HasColumnType("text")
                        .HasColumnName("port");

                    b.Property<string>("Server")
                        .HasColumnType("text")
                        .HasColumnName("server");

                    b.Property<string>("User")
                        .HasColumnType("text")
                        .HasColumnName("user");

                    b.HasKey("Id")
                        .HasName("pk_tenant");

                    b.ToTable("tenant", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("4249f843-d4a3-4d9c-b0ff-bc1a9d3cd5e1"),
                            Database = "multitenant_dev_db",
                            DatabaseType = 1,
                            Identifier = "sme1:5001",
                            Password = "Admin",
                            Port = "5432",
                            Server = "localhost",
                            User = "postgres"
                        },
                        new
                        {
                            Id = new Guid("5249f843-d4a3-4d9c-b0ff-bc1a9d3cd5e1"),
                            Database = "multitenant1_dev_db",
                            DatabaseType = 1,
                            Identifier = "sme2:5001",
                            Password = "Admin",
                            Port = "5432",
                            Server = "localhost",
                            User = "postgres"
                        });
                });

            modelBuilder.Entity("Core.EF.IdentityModels.ApplicationRoleClaim", b =>
                {
                    b.HasOne("Core.EF.IdentityModels.ApplicationRole", "ApplicationRole")
                        .WithMany("ApplicationRoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_role_claim_role_role_id");

                    b.Navigation("ApplicationRole");
                });

            modelBuilder.Entity("Core.EF.IdentityModels.ApplicationUserRole", b =>
                {
                    b.HasOne("Core.EF.IdentityModels.ApplicationRole", "ApplicationRole")
                        .WithMany("ApplicationUserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_user_role_role_role_id");

                    b.HasOne("Core.EF.IdentityModels.ApplicationUser", "ApplicationUser")
                        .WithMany("ApplicationUserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_user_role_user_user_id");

                    b.Navigation("ApplicationRole");

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("Core.EF.IdentityModels.ApplicationRole", b =>
                {
                    b.Navigation("ApplicationRoleClaims");

                    b.Navigation("ApplicationUserRoles");
                });

            modelBuilder.Entity("Core.EF.IdentityModels.ApplicationUser", b =>
                {
                    b.Navigation("ApplicationUserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
