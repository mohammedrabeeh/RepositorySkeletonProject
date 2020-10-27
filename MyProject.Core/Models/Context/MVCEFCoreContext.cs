using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;



namespace DB.Core.Models
{
    public partial class MVCEFCoreContext : DbContext
    {
        //private readonly IUserService userService;
        public MVCEFCoreContext()
        {
            
        }
      
        public virtual DbSet<Employee> Employees { get; set; }
      

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                #warning To protect potentially sensitive information in your connection string, you should move it out of source code and keep it in web config.
                 optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=MyDb;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>(entity =>
            //{
            //   // entity.HasKey(e => e.StudentId);

            //    entity.Property(e => e.EmpCity)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.EmpCountry)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.EmpName)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);
            //});
        }

    }
}
