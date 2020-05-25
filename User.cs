using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agentstvo
{
    class User
    {
        private string _login;
        private string _password;

        public String ConnStr = @"Data Source=WIN-NI9N3CBIQ6D\SQLEXPRESS;Initial Catalog=Agentstvo_nedwizmost;Integrated Security=True";
        public User(string login, string password)
        {
            _login = login;
            _password = password;
        }

        public bool IsUserExist()
        {
            String SqlQuest = "SELECT COUNT(*) FROM [Users] WHERE [Login]= '" + _login+ "'";
            SqlDataAdapter da = new SqlDataAdapter(SqlQuest, ConnStr);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1") return false;
            else return true;
         
        }

        public bool Check(string loginUser, string passUser)
        {
            var hashedpassUser = Hash(passUser);
            String SqlQuest = "SELECT COUNT(*) FROM [Users] WHERE [Login]= '" + loginUser + "' and Password = '" + hashedpassUser + "'";
            SqlDataAdapter da = new SqlDataAdapter(SqlQuest, ConnStr);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1") return true;
            else return false;
        }

        private string Hash(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
        public void SaveToDb()
        {
            var hashedpassUser = Hash(_password);
            String SqlQuest = "INSERT INTO [Users] ([Login], [Password], [Flag]) values('"+_login+"', '"+hashedpassUser+"', '3') ";
            SqlConnection cn;
            SqlCommand cmd;
            cn = new SqlConnection(ConnStr);
            cn.Open();
            cmd = cn.CreateCommand();
            cmd.CommandText = SqlQuest; 
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public int Role(string loginUser, string passUser)
        {
            int flag = 0;
            var hashedpassUser = Hash(passUser);
            String SqlQuest = "SELECT [Flag] FROM [Users] WHERE [Login]= '" + loginUser + "' and Password = '" + hashedpassUser + "'";
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                SqlCommand cmd = new SqlCommand(SqlQuest, conn);
                conn.Open();
                flag = (Int32)cmd.ExecuteScalar(); 
            }
            return flag;
        }

        public int ID(string loginUser, string passUser)
        {
            int flag = 0;
            var hashedpassUser = Hash(passUser);
            String SqlQuest = "SELECT [ID] FROM [Users] WHERE [Login]= '" + loginUser + "' and Password = '" + hashedpassUser + "'";
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                SqlCommand cmd = new SqlCommand(SqlQuest, conn);
                conn.Open();
                flag = (Int32)cmd.ExecuteScalar();
            }
            return flag;
        }

        public void Flag(int ID, int Flag)
        {
            String SqlQuest = "INSERT INTO [Temp] ([ID], [Flag]) values('" +ID+ "', '" + Flag + "') ";
            SqlConnection cn;
            SqlCommand cmd;
            cn = new SqlConnection(ConnStr);
            cn.Open();
            cmd = cn.CreateCommand();
            cmd.CommandText = SqlQuest;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
