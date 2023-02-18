using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    class DbUser
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=sql12.freesqldatabase.com;port=3306;username=sql12598818;password=5nZGNzw9LH;database=sql12598818";
            MySqlConnection connection = new MySqlConnection(sql);
            try
            {
                connection.Open();
            }
            catch (MySqlException e)
            {

            }
            return connection;
        }

        public static void AddUser(string name,string key)
        {
            string sql = "Insert into Users VALUES(NULL,@Name,@key)";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@key", MySqlDbType.VarChar).Value = key;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {

            }
            connection.Close();
        }

        public static void UpdateUser(User user)
        {
            string sql = "UPDATE Users set Name = @Name, PassKey = @key WHERE ID = @ID";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = user.name;
            cmd.Parameters.Add("@key", MySqlDbType.VarChar).Value = user.key;
            cmd.Parameters.Add("@ID", MySqlDbType.Int16).Value = user.ID;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {

            }
            connection.Close();
        }

        public static void deleteUser(string ID)
        {
            string sql = "Delete FROM Users Where ID = @ID";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@ID", MySqlDbType.Int16).Value = ID;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {

            }
            connection.Close();
        }

        public static void Display(DataGridView grid)
        {
            string sql = "Select * From Users";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adp.Fill(table);
            grid.DataSource = table;
            connection.Close();

        }
    }
}
