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

            string sql = "datasource=schedix-db.cssjh7thmdbg.ap-southeast-2.rds.amazonaws.com; port =3306;username=admin;password=Schedix253!;database=AutoTable";
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

        public static void close()
        {

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

        public static void UpdateUser(int ID, string name,string key)
        {
            string sql = "UPDATE Users set UserName = @Name, PassKey = @key WHERE ID = @ID";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@key", MySqlDbType.VarChar).Value = key;
            cmd.Parameters.Add("@ID", MySqlDbType.Int16).Value = ID;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        public static void deleteUser(int ID)
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
