using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            lTime.Text = "Осталось " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds;
        }

        private void btRunner_Click(object sender, EventArgs e)
        {

        }

        private void btSponsor_Click(object sender, EventArgs e)
        {

        }

        private void btInfo_Click(object sender, EventArgs e)
        {

        }

        private void mbLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
