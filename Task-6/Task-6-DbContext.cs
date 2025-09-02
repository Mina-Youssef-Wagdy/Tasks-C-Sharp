using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6

{

    public class Task_6_DbContext : DbContext
    {

        public Task_6_DbContext()
        {

        }
        public Task_6_DbContext(DbContextOptions<Task_6_DbContext> Options) : base(Options)
        {

        }
        public DbSet<Employee> Employees { set; get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Data Source=ADMINISTRATOR\\SQLEXPRESS01;Initial Catalog=Task_6_DB;Integrated Security=True;Trust Server Certificate=True"
                );


            }

        }
        public class Employee
        {
            [Key]
            public int Id { get; set; }
            public string Name { get; set; }
            [Required, MaxLength(50)]
            public string Job { get; set; }
            [Required]
            public double Salary { get; set; }
            [Required]

            public byte[] Photo { get; set; }
            
        }
    }
}