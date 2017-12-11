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
    public partial class Form10 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form10()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=diplom.accdb;Persist Security Info=False;";
        }

        private void Form10_Load_1(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select PIB_Manager from Pratsіvnik";
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["PIB_Manager"].ToString());
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("помилка" + ex);
            }
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select VIN_Nomer from Zapchasti   ";
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox2.Items.Add(reader["VIN_Nomer"].ToString());
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("помилка" + ex);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT Zapchasti.Kod_Zapchasti, Zapchasti.Nazva_Zapchasti, Virobnik.Nazva_Virobnik, Zapchasti.Cina FROM Virobnik INNER JOIN Zapchasti ON Virobnik.Kod_Virobnik = Zapchasti.Kod_Virobnik where VIN_Nomer='" + comboBox2.Text + "'";
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    textBox4.Text = reader["Kod_Zapchasti"].ToString();
                    textBox5.Text = reader["Nazva_Zapchasti"].ToString();
                    textBox6.Text = reader["Nazva_Virobnik"].ToString();
                    textBox7.Text = reader["Cina"].ToString();

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
            int id=0;
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = " INSERT INTO Klient([PIB_Klienta],[Nomer_Telefonu], Adresa )VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";﻿
                command.ExecuteNonQuery();
                MessageBox.Show("Збережено клієнта");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("помилка" + ex);
            }
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT Max(Kod_Klienta) from Klient";
                OleDbDataReader reader = command.ExecuteReader();
                 reader.Read();
                 id = reader.GetInt32(0);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("помилка" + ex);
            }

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                int selectedIndex = comboBox1.SelectedIndex+1 ;
                command.CommandText = " INSERT INTO Prodaja_zapchasti(Data,Kod_Zapchasti,Kod_Manager,Kod_Klienta )VALUES ('" + dateTimePicker1.Text + "','" + textBox4.Text + "','" + selectedIndex + "','" +id.ToString() + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("Збережено замовлення");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("помилка" + ex);
            }
      
      
        }

       

    }
    
}
