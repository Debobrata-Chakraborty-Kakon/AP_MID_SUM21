using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WebApplicationStudent.Models.Database
{
    public class Admins
    {
        SqlConnection conn;

        public Admins(SqlConnection conn)
        {
            this.conn = conn;
        }


    }
}