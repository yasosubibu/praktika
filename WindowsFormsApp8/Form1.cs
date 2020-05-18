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
        DateTime date; 
        public Form1()
        {
            InitializeComponent();
            date = new DateTime(2020, 11, 24, 6, 0, 0);
            timerDay.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //*long tick = DateTime.Now.Ticks - date.Ticks;
            //DateTime stopWatch = new DateTime();
            //stopWatch = stopWatch.AddTicks(tick);
            //lTime.Text = String.Format("{0:HH:mm:ss:ff}", stopWatch);
            TimeSpan remaining = date - DateTime.Now;
            lTime.Text = remaining.ToString();
        }

        private void btRunner_Click(object sender, EventArgs e)
        {
            Form6 FRlog = new Form6();
            FRlog.Show();
            Hide();

        }

        private void btSponsor_Click(object sender, EventArgs e)
        {
            Form2 Fdonat = new Form2();
            Fdonat.Show();
            Hide();
        }

        private void btInfo_Click(object sender, EventArgs e)
        {

        }

        private void mbLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
