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
    public partial class Form7 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form7()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=diplom.accdb;Persist Security Info=False;";
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT Zapchasti.Kod_Zapchasti, Zapchasti.VIN_Nomer, Zapchasti.Nazva_Zapchasti, Virobnik.Nazva_Virobnik, Zapchasti.Cina FROM Virobnik INNER JOIN Zapchasti ON Virobnik.Kod_Virobnik = Zapchasti.Kod_Virobnik;";
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

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "DELETE FROM Zapchasti WHERE Kod_Zapchasti=" + textBox1.Text + "";
            command.ExecuteNonQuery();
            MessageBox.Show("Видалено");
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            //this..Fill(this.);
            dataGridView1.CurrentCell = dataGridView1[0, i];
        }
    }
}
