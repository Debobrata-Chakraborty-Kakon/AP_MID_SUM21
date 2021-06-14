using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;



namespace WebApplicationStudent.Models.Database
{
    public class Students
    {
        SqlConnection conn;

        public Students(SqlConnection conn) {
            this.conn = conn;
        }
        public void Insert(Student s) {
            
            string query = "Insert into StudentT values(@Name,@Id,@DOB,@Cgpa,@Credit,@DeptId)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name",s.Name);
            cmd.Parameters.AddWithValue("@Id",s.Id);
            cmd.Parameters.AddWithValue("@DOB",s.DOB);
            cmd.Parameters.AddWithValue("@Cgpa",s.Cgpa);
            cmd.Parameters.AddWithValue("@Credit", s.Credit);
            cmd.Parameters.AddWithValue("@DeptId", s.DeptId);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<Student> GetAll() {
            List<Student> students = new List<Student>();
            string query = "select * from StudentT";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                Student s = new Student()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    DOB = reader.GetString(reader.GetOrdinal("DOB")),
                    Cgpa = reader.GetFloat(reader.GetOrdinal("Cgpa")),
                    DeptId= reader.GetInt32(reader.GetOrdinal("DeptId")),
                    Credit = reader.GetInt32(reader.GetOrdinal("Credit")),

                };
                students.Add(s);
            }
            conn.Close();
            return students;
        }
        public Student Get(int id) {
            Student s = null;
            string query = $"select * from StudentT Where Id={id}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                s= new Student()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    DOB = reader.GetString(reader.GetOrdinal("DOB")),
                    Cgpa = reader.GetFloat(reader.GetOrdinal("Cgpa")),
                    DeptId = reader.GetInt32(reader.GetOrdinal("DeptId")),
                    Credit = reader.GetInt32(reader.GetOrdinal("Credit")),
                };
            }
            conn.Close();
            return s;
        }
        public void Update(Student s) {
            string query = $"Update StudentT Set Name='{s.Name}',DOB={s.DOB}, Cgpa='{s.Cgpa}', DeptId='{s.DeptId}',Credit='{s.Credit}' Where Id = {s.Id}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Delete(Student s) {
          /*  string query = $"DELETE FROM Student  Where Id = {s.Id}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();*/
        }
        
    }
}