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
    public partial class Form5 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form5()
        {

            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=diplom.accdb;Persist Security Info=False;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

       
    }
}
