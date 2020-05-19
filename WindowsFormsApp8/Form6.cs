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
            /* String login = loginbox.Text;
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
 */
            string connection = "Database=marathon-skills-2020;" + "Data Source=127.0.0.1;" + "User Id=root;" + "Password=root;";
            MySqlConnection connect = new MySqlConnection(connection);
            connect.Open();
            
            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) ,RoleId,Password,Email,FirstName,LastName " + "FROM user "
                + "WHERE Email LIKE'" + loginbox.Text + "'" + " AND " + "Password LIKE '" + passbox.Text + "';", connect);
            
            int countuser = 0;
            string role = "";
            string firsname = "";
            string lasname = "";
            string login = "";
           
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                countuser = reader.GetInt32(0);
                role = reader.GetString("RoleId");
                login = reader.GetString("Email");
                firsname = reader.GetString("FirstName");
                lasname = reader.GetString("LastName");
            }
            reader.Close();
            if (countuser != 0) 
            { 
                if (role == "R") 
                {
                    Form7 runnermenu = new Form7();
                    runnermenu.Show();
                    this.Hide();
                }
                if (role == "A") 
                {
                    Form9 form = new Form9();
                    form.Show();
                    this.Hide();
                }
                if (role == "C") 
                {
                    Form8 koordmenu = new Form8();
                    koordmenu.Show();
                    this.Hide();
                }
                connect.Close(); 
            }
            else
            {
                MessageBox.Show("Не верно введен логин или пароль"); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Fmain = new Form1();
            Fmain.Show();
            Hide();
        }
    }
}
