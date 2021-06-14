using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WebApplicationStudent.Models.Database
{
    public class Database
    {
        public Students Students { get; set; }
        public Admins Admins { get; set; }
        public Database()
        {
            string connString = @"Server=DESKTOP-26RO7OD;Database=SMS;User Id=sa;Password=123456";
            SqlConnection conn = new SqlConnection(connString);

            Students = new Students(conn);
            Admins = new Admins(conn); 

        }
    }
}