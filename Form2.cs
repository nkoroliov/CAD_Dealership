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
    public partial class Form2 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form2()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=diplom.accdb;Persist Security Info=False;";
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet5.KPP". При необходимости она может быть перемещена или удалена.
            this.kPPTableAdapter.Fill(this.diplomDataSet5.KPP);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet4.Kolir". При необходимости она может быть перемещена или удалена.
            this.kolirTableAdapter.Fill(this.diplomDataSet4.Kolir);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet3.Tup_kuzova". При необходимости она может быть перемещена или удалена.
            this.tup_kuzovaTableAdapter.Fill(this.diplomDataSet3.Tup_kuzova);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet2.Model". При необходимости она может быть перемещена или удалена.
            this.modelTableAdapter.Fill(this.diplomDataSet2.Model);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet1.Marka". При необходимости она может быть перемещена или удалена.
            this.markaTableAdapter.Fill(this.diplomDataSet1.Marka);
        }
        private void button1_Click(object sender, EventArgs e)
        {
             
            try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    int selectedIndex = comboBox1.SelectedIndex + 5;
                    int selectedIndex1 = comboBox2.SelectedIndex + 10;
                    int selectedIndex2 = comboBox3.SelectedIndex + 7;
                    int selectedIndex3 = comboBox4.SelectedIndex + 4;
                    int selectedIndex4 = comboBox5.SelectedIndex + 6;
                    
                     command.CommandText = " INSERT INTO Auto([Kod_Marka],[Kod_Model],[Kod_Kolir],[Kod_KPP],Kod_Kuzova,Cina,[Rik_Vupusky] )VALUES ('"+selectedIndex+"','"+selectedIndex1+"','"+selectedIndex2+"','"+selectedIndex3+"','"+selectedIndex4+"','"+textBox2.Text+"','"+comboBox6.SelectedItem.ToString()+"')";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Збережено");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("помилка" + ex);
                }
            }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number !=46 ) 
            {
                e.Handled = true;
            }
        }

        }
    }

