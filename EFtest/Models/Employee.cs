using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFtest.Models
{
    // [Table("EMP")]

    public class Employee
    {
        
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public Decimal Salary { get; set; }
    }
}

 