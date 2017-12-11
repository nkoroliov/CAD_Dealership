using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form6 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form6()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=diplom.accdb;Persist Security Info=False;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Pratsіvnik WHERE Kod_Manager=" + textBox1.Text + "";
                command.ExecuteNonQuery();
                MessageBox.Show("Видалено");
                connection.Close();
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet6.Pratsіvnik". При необходимости она может быть перемещена или удалена.
            this.pratsіvnikTableAdapter.Fill(this.diplomDataSet6.Pratsіvnik);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            this.pratsіvnikTableAdapter.Fill(this.diplomDataSet6.Pratsіvnik);
            dataGridView1.CurrentCell = dataGridView1[0, i];
        }
    }
}
