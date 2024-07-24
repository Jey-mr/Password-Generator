using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator.PGClasses
{
    internal class NewTable
    {
        public int Id { get; set; } 
        public string Password { get; set; }
        static string mycs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(mycs);
            DataTable dt = new DataTable();

            try
            {
                string sql = "select * from new_table";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            { 
            
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public DataTable GetPassword()
        {
            SqlConnection conn = new SqlConnection(mycs);
            DataTable dt = new DataTable();

            try
            {
                string sql = "select password from new_table";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public bool Insert(string password)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(mycs);

            try
            {
                string sql = "insert into new_table values(@Password)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Password", password);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            { 
            
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
    }
}
