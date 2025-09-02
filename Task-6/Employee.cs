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
        [Required,MaxLength(50)]    
        public string Name { get; set; }   
        [Required,MaxLength(50)]
        public string Job { get; set; }
        [Required]
        public double Salary { get; set; }

        public byte[] Photo { get; set; }  

    }
}
