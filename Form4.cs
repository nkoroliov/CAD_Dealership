using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        private OleDbConnection connection =new OleDbConnection();
        public Form4()
        {
            InitializeComponent();
           connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=diplom.accdb;Persist Security Info=False;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = " INSERT INTO Pratsіvnik([PIB_Manager],[Nomer_Telefonu], Adresa )VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";﻿
                command.ExecuteNonQuery();
                MessageBox.Show("Збережено");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("помилка" + ex);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        
    }
}
