using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationStudent.Models
{
    public class Student
    {
        [Required]
        public string Name { get; set; }
        public int Id { get; set; }
        [Required]
        public int Credit { get; set; }
        [Required]
        public float Cgpa { get; set; }
        [Required]
        public string DOB { get; set; }
        [Required]
        public int DeptId { get; set; }

    }
}