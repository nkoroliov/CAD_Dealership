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
    public partial class Form3 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form3()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=diplom.accdb;Persist Security Info=False;";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet7.Marka". При необходимости она может быть перемещена или удалена.
            this.markaTableAdapter.Fill(this.diplomDataSet7.Marka);
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                command.CommandText = "SELECT  Auto.Kod_Auto, Marka.Nazva_Marku, Model.Nazva_Model, Tup_kuzova.Nazva_Kuzova, Kolir.Nazva_Kolir, KPP.Tup_KPP,Auto.Cina, Auto.Rik_Vupusky" +
" FROM Tup_kuzova INNER JOIN (Model INNER JOIN (Marka INNER JOIN (KPP INNER JOIN (Kolir INNER JOIN Auto ON Kolir.Kod_Kolir = Auto.Kod_Kolir) ON KPP.Kod_KPP = Auto.Kod_KPP) ON Marka.Kod_Marku = Auto.Kod_Marka) ON Model.Kod_Model = Auto.Kod_Model) ON Tup_kuzova.Kod_Kuzova = Auto.Kod_Kuzova";
                    DataTable dt = new DataTable();
                    OleDbDataAdapter da = new OleDbDataAdapter(command);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

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
                command.CommandText = "SELECT  Auto.Kod_Auto,  Marka.Nazva_Marku, Model.Nazva_Model, Tup_kuzova.Nazva_Kuzova, Kolir.Nazva_Kolir, KPP.Tup_KPP,Auto.Cina, Auto.Rik_Vupusky" +
" FROM Tup_kuzova INNER JOIN (Model INNER JOIN (Marka INNER JOIN (KPP INNER JOIN (Kolir INNER JOIN Auto ON Kolir.Kod_Kolir = Auto.Kod_Kolir) ON KPP.Kod_KPP = Auto.Kod_KPP) ON Marka.Kod_Marku = Auto.Kod_Marka) ON Model.Kod_Model = Auto.Kod_Model) ON Tup_kuzova.Kod_Kuzova = Auto.Kod_Kuzova where Nazva_Marku  like '%" + comboBox1.SelectedItem.ToString() + "%'  ";
                command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
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
                command.CommandText = "SELECT  Auto.Kod_Auto,  Marka.Nazva_Marku, Model.Nazva_Model, Tup_kuzova.Nazva_Kuzova, Kolir.Nazva_Kolir, KPP.Tup_KPP,Auto.Cina, Auto.Rik_Vupusky" +
" FROM Tup_kuzova INNER JOIN (Model INNER JOIN (Marka INNER JOIN (KPP INNER JOIN (Kolir INNER JOIN Auto ON Kolir.Kod_Kolir = Auto.Kod_Kolir) ON KPP.Kod_KPP = Auto.Kod_KPP) ON Marka.Kod_Marku = Auto.Kod_Marka) ON Model.Kod_Model = Auto.Kod_Model) ON Tup_kuzova.Kod_Kuzova = Auto.Kod_Kuzova where Nazva_Model like '%" + comboBox2.SelectedItem.ToString() + "%'  ";
                command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("помилка" + ex);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT  Auto.Kod_Auto,  Marka.Nazva_Marku, Model.Nazva_Model, Tup_kuzova.Nazva_Kuzova, Kolir.Nazva_Kolir, KPP.Tup_KPP,Auto.Cina, Auto.Rik_Vupusky" +
" FROM Tup_kuzova INNER JOIN (Model INNER JOIN (Marka INNER JOIN (KPP INNER JOIN (Kolir INNER JOIN Auto ON Kolir.Kod_Kolir = Auto.Kod_Kolir) ON KPP.Kod_KPP = Auto.Kod_KPP) ON Marka.Kod_Marku = Auto.Kod_Marka) ON Model.Kod_Model = Auto.Kod_Model) ON Tup_kuzova.Kod_Kuzova = Auto.Kod_Kuzova where Nazva_Kolir like '%" + comboBox3.SelectedItem.ToString() + "%'  ";
                command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("помилка" + ex);
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT  Auto.Kod_Auto, Marka.Nazva_Marku, Model.Nazva_Model, Tup_kuzova.Nazva_Kuzova, Kolir.Nazva_Kolir, KPP.Tup_KPP,Auto.Cina, Auto.Rik_Vupusky" +
" FROM Tup_kuzova INNER JOIN (Model INNER JOIN (Marka INNER JOIN (KPP INNER JOIN (Kolir INNER JOIN Auto ON Kolir.Kod_Kolir = Auto.Kod_Kolir) ON KPP.Kod_KPP = Auto.Kod_KPP) ON Marka.Kod_Marku = Auto.Kod_Marka) ON Model.Kod_Model = Auto.Kod_Model) ON Tup_kuzova.Kod_Kuzova = Auto.Kod_Kuzova where Tup_KPP like '%" + comboBox4.SelectedItem.ToString() + "%'  ";
                command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("помилка" + ex);
            }
        }

        
    }
}
