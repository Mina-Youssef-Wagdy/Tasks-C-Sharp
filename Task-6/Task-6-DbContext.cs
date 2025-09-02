using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    public class Task_6_DbContext : DbContext
    {

        public Task_6_DbContext(DbContextOptions<Task_6_DbContext> Options):base(Options) 
        {
            
        }
        public DbSet<Employee> Employees { set; get; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Job).HasMaxLength(50);
                entity.Property(e => e.Name).HasMaxLength(50);
                entity.Property(e => e.Salary).HasColumnType("decimal(18,2)").IsRequired();

            });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ADMINISTRATOR\\SQLEXPRESS01;Initial Catalog=Task_6_DB;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
