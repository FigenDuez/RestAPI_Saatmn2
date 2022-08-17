using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using RestAPI_SaatmannTest2.Models;

namespace RestAPI_SaatmannTest2.Data
{
    public partial class ITAssessmentContext : DbContext
    {
        public ITAssessmentContext()
        {
            
        }

        public ITAssessmentContext(DbContextOptions<ITAssessmentContext> options)
            : base(options)
        {

        }


        public virtual DbSet<Entgelte> Entgeltes { get; set; } = null!;
        public virtual DbSet<Fab> Fabs { get; set; } = null!;
        public virtual DbSet<Fall> Falls { get; set; } = null!;
        public virtual DbSet<Icd> Icds { get; set; } = null!;
        public virtual DbSet<Ops> Ops { get; set; } = null!;



        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Entgelte>().ToTable("Entgeltes");
        //    modelBuilder.Entity<Fab>().ToTable("Fabs");
        //    modelBuilder.Entity<Fall>().ToTable("Falls");
        //    modelBuilder.Entity<Icd>().ToTable("Icds");
        //    modelBuilder.Entity<Ops>().ToTable("Ops");
        //}
    }
}
