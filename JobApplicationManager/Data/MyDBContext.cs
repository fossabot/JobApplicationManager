﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace JobApplicationManager.Data
{
    public partial class MyDBContext : DbContext
    {
        public MyDBContext()
        {
        }

        public MyDBContext(DbContextOptions<MyDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Certificate> Certificates { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<EmploymentCert> EmploymentCerts { get; set; }
        public virtual DbSet<JobApplication> JobApplications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Certificate>(entity =>
            {
                entity.ToTable("Certificate");

                entity.HasIndex(e => e.Id, "IX_Certificate_Id")
                    .IsUnique();

                entity.Property(e => e.Date).HasColumnType("DATETIME");

                entity.Property(e => e.Order).HasColumnType("INT");

                entity.Property(e => e.Path).HasColumnType("STRING");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("Company");

                entity.HasIndex(e => e.Id, "IX_Company_Id")
                    .IsUnique();

                entity.Property(e => e.City).HasColumnType("STRING");

                entity.Property(e => e.ContactName).HasColumnType("STRING");

                entity.Property(e => e.Email).HasColumnType("STRING");

                entity.Property(e => e.Name).HasColumnType("STRING");

                entity.Property(e => e.Phone).HasColumnType("STRING");

                entity.Property(e => e.Street).HasColumnType("STRING");

                entity.Property(e => e.Zip).HasColumnType("INT");
            });

            modelBuilder.Entity<EmploymentCert>(entity =>
            {
                entity.ToTable("EmploymentCert");

                entity.HasIndex(e => e.Id, "IX_EmploymentCert_Id")
                    .IsUnique();

                entity.Property(e => e.Date).HasColumnType("DATETIME");

                entity.Property(e => e.Order).HasColumnType("INT");

                entity.Property(e => e.Path).HasColumnType("STRING");
            });

            modelBuilder.Entity<JobApplication>(entity =>
            {
                entity.ToTable("JobApplication");

                entity.Property(e => e.Id)
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.City).HasColumnType("STRING");

                entity.Property(e => e.CompanyId).HasColumnType("INT");

                entity.Property(e => e.EmailConfirmation).HasColumnType("DATETIME");

                entity.Property(e => e.EmailSent).HasColumnType("DATETIME");

                entity.Property(e => e.JobInterview).HasColumnType("DATETIME");

                entity.Property(e => e.JobOfferUrl).HasColumnType("STRING");

                entity.Property(e => e.JobTitle).HasColumnType("STRING");

                entity.Property(e => e.LastPhonecall).HasColumnType("DATETIME");

                entity.Property(e => e.Status).HasColumnType("STRING");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.JobApplications)
                    .HasForeignKey(d => d.CompanyId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}