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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void display()
        {
            DbUser.Display(dataGridView1);
        }
        private void add_button_Click(object sender, EventArgs e)
        {
            user_form form = new user_form();
            form.Show();
            DbUser.Display(dataGridView1);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            display();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                var id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                if(MessageBox.Show("Are you sure you want to delete the user?","Information",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbUser.deleteUser(int.Parse(id));
                    DbUser.Display(dataGridView1);
                }
            }

            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                var id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                string name = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                user_form edit = new user_form(int.Parse(id),name);
                edit.Show();
                DbUser.Display(dataGridView1);
            }
        }
    }
}
