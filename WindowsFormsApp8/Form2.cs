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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Fmain = new Form1();
            Fmain.Show();
            Hide();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            

        }

        private void cash_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
