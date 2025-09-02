using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    public partial class Employee
    {
        [Key]
        public int Id { get; set; }
        public  string Name { get; set; }   
        [Required,MaxLength(50)]
        public string Job { get; set; }
        [Required]
        public double Salary { get; set; }
        [Required]  

        public byte[] Photo { get; set; }  

    }
}
