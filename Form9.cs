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
    public partial class Form9 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form9()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=diplom.accdb;Persist Security Info=False;";

        }
        private void Form9_Load(object sender, EventArgs e)
        {
             try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select Kod_Virobnik, Nazva_Virobnik from Virobnik";
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["Kod_Virobnik"]+"   |   "+reader["Nazva_Virobnik"]);
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("помилка" + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                int selectedIndex = comboBox1.SelectedIndex+3;
                command.CommandText = " INSERT INTO Zapchasti(VIN_Nomer,Nazva_Zapchasti,Kod_Virobnik, Cina )VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','"+selectedIndex.ToString()+"','" + textBox3.Text + "')";﻿
                command.ExecuteNonQuery();
                MessageBox.Show("Збережено");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("помилка" + ex);
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 46) 
            {
                e.Handled=true;
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

