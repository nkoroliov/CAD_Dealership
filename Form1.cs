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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
          this.Close();
        }

        private void додатиАвтоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Hide();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void пошукАвтоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Hide();
            f.Show();
        }

        private void додатиПрацівникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Hide();
            f.Show();
        }

        private void вилучитиПрацівникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Hide();
            f.Show();
        }

       

        private void додатиВиробникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f = new Form8();
            f.Hide();
            f.Show();

        }

        private void додатиЗапчастинуиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 f = new Form9();
            f.Hide();
            f.Show();
        }

        private void оформитиЗамовленняToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form10 f = new Form10();
            f.Hide();
            f.Show();
        }

        private void оформитиЗамовленняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 f = new Form11();
            f.Hide();
            f.Show();
        }

        private void пошукЗапчастинToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 f = new Form12();
            f.Hide();
            f.Show();
        }

        private void вилучитиЗапчастинуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            f.Hide();
            f.Show();
        }

        private void вилучитиАвтоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 f = new Form13();
            f.Hide();
            f.Show();
        }

        private void продажіАвтоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14 f = new Form14();
            f.Hide();
            f.Show();
        }

        private void продажіЗапчастинToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form15 f = new Form15();
            f.Hide();
            f.Show();
        }
     
           
    }
}
