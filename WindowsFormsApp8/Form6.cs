using MySql.Data.MySqlClient;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Buttonlogin_Click(object sender, EventArgs e)
        {
            String login = loginbox.Text;
            String pass = passbox.Text;
            Form7 Fr = new Form7();
            db DB = new db();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `Email`= @uL AND `Password`= @uP", DB.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = pass;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                Fr.Show();
                Hide();
            }
            else
                MessageBox.Show("Пользователь не авторизован");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Fmain = new Form1();
            Fmain.Show();
            Hide();
        }
    }
}
