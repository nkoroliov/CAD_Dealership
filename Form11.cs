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
    public partial class Form11 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form11()
        {
            InitializeComponent();

            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=diplom.accdb;Persist Security Info=False;";
        }
        private void Form11_Load(object sender, EventArgs e)
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
                command.CommandText = "select Kod_Auto from Auto   ";
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox2.Items.Add(reader["Kod_Auto"].ToString());
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
                if (comboBox2.SelectedIndex != -1)
                {
                    int cod = Int32.Parse(comboBox2.Text);

                    command.CommandText = "SELECT Auto.Cina, Auto.Rik_Vupusky, Marka.Nazva_Marku, Model.Nazva_Model, Tup_kuzova.Nazva_Kuzova, Kolir.Nazva_Kolir, KPP.Tup_KPP" +
" FROM Tup_kuzova INNER JOIN (Model INNER JOIN (Marka INNER JOIN (KPP INNER JOIN (Kolir INNER JOIN Auto ON Kolir.Kod_Kolir = Auto.Kod_Kolir) ON KPP.Kod_KPP = Auto.Kod_KPP) ON Marka.Kod_Marku = Auto.Kod_Marka) ON Model.Kod_Model = Auto.Kod_Model) ON Tup_kuzova.Kod_Kuzova = Auto.Kod_Kuzova" +
" where  Auto.Kod_Auto=" + cod + ";";
                   
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        textBox4.Text = reader["Nazva_Marku"].ToString();
                        textBox5.Text = reader["Nazva_Model"].ToString();
                        textBox6.Text = reader["Nazva_Kolir"].ToString();
                        textBox7.Text = reader["Nazva_Kuzova"].ToString();
                        textBox10.Text = reader["Tup_KPP"].ToString();
                        textBox8.Text = reader["Cina"].ToString();
                        textBox9.Text = reader["Rik_Vupusky"].ToString();

                    }

                    connection.Close();
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
                int selectedIndex2 = comboBox2.SelectedIndex + 1;
                command.CommandText = " INSERT INTO Prodaja_auto(Data,Kod_Auto,Kod_Manager,Kod_Klienta )VALUES ('" + dateTimePicker1.Text + "','"+selectedIndex2+"','" + selectedIndex + "','" +id.ToString() + "')";
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
