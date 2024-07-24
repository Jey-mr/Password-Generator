using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator.PGClasses
{
    internal class PasswordGen
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        static string mycs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(mycs);
            DataTable dt = new DataTable();

            try
            {
                string sql = "select * from password";
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

        public DataTable FindByURL(string url)
        {
            SqlConnection conn = new SqlConnection(mycs);
            DataTable dt = new DataTable();

            try
            {
                //string sql = "select * from password";
                string sql = "select * from password where url like @Url";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Url", url);
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

        public bool Insert(string url, string userName, string password)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(mycs);

            try
            {
                string sql = "insert into password values(@Url, @UserName, @Password)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Url", url);
                cmd.Parameters.AddWithValue("@UserName", userName);
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
