﻿using System;
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
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            display();
        }
    }
}
