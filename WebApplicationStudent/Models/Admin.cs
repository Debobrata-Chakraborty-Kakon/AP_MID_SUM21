using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationStudent.Models
{
    public class Admin
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}