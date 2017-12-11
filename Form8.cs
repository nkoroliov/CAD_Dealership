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
    public partial class Form8 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form8()
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
                command.CommandText = " INSERT INTO Virobnik([Nazva_Virobnik],[Nomer_Telefonu], Adresa )VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";﻿
                command.ExecuteNonQuery();
                MessageBox.Show("Збережено");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("помилка" + ex);
            }

        }
        private void Form8_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select Nazva_Virobnik from Virobnik   ";
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["Nazva_Virobnik"].ToString());
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("помилка" + ex);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from Virobnik where Nazva_Virobnik='" + comboBox1.Text + "'";
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.Text = reader["Nazva_Virobnik"].ToString();
                    textBox2.Text = reader["Nomer_Telefonu"].ToString();
                    textBox3.Text = reader["Adresa"].ToString(); 

                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("помилка" + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "DELETE FROM Virobnik where Nazva_Virobnik='" + comboBox1.Text + "'";
            command.ExecuteNonQuery();
            MessageBox.Show("Видалено");
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}

   

