using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.progressBar1.Value = this.progressBar1.Value + 5;
        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

        private void testToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Text = "Test1";
        }

        private void testToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Text = "Test2";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
