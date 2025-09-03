using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

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
            [Required, MaxLength(100)]  
            public string Name { get; set; } = string.Empty;
            [Required, MaxLength(50)]
            public string Job { get; set; } = string.Empty;

            [Required]
            [Column(TypeName = "decimal(18,2)")]
            public decimal Salary { get; set; }
            [Required]

            public byte[]? Photo { get; set; }
            
        }
    }
}