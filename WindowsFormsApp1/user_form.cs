using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class user_form : Form
    {
        int id = -1;
        public user_form()
        {
            InitializeComponent();
        }

        public user_form(int id,string name,string key)
        {
            InitializeComponent();
            this.id = id;
            Add_Button.Text = "Edit";
            Top_Label.Text = "Edit User: " + name;
            nameBox.Text = name;
            Key_Box.Text = key;
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if(nameBox.Text != "" && Key_Box.Text != "")
            {
                if(this.id != -1)
                {
                    DbUser.UpdateUser(this.id, nameBox.Text, Key_Box.Text);
                    Application.Restart();
                }
                else
                {
                    DbUser.AddUser(nameBox.Text, Key_Box.Text);
                    Application.Restart();
                }
            }
        }

        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void generate_button_Click(object sender, EventArgs e)
        {
            Key_Box.Text = RandomString(16);
        }
    }
}
