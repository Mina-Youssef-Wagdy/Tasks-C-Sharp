using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Task_5_DbContext: DbContext
    {

        public Task_5_DbContext(DbContextOptions<Task_5_DbContext> Options):base(Options) 
        {
            
        }
        public DbSet<Employee> employees { set; get; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Job).HasMaxLength(50);
                entity.Property(e => e.Name).HasMaxLength(50);
                entity.Property(e => e.Salary);

            });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ADMINISTRATOR\\SQLEXPRESS01;Initial Catalog=Task_6_DB;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
