using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GalakPizza.Form1;


namespace GalakPizza
{
    public partial class LogPage : UserControl
    {
        public LogPage()
        {
            InitializeComponent();
        }

        private void ButtonLog_Click(object sender, EventArgs e)
        {
            if(textBoxLogin.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Nieprawidłowe dane!");
              
                return;
            }
            string connection = "SERVER=localhost;DATABASE=galakpizza;UID=root;PASSWORD=;";
            MySqlConnection conn = new MySqlConnection(connection);
            conn.Open();
            string query = $"SELECT COUNT(IDUzytkownicy),Rola FROM uzytkownicy WHERE Login=\"{textBoxLogin.Text}\" AND Haslo=\"{textBoxPassword.Text}\";";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int role;
            if(dr.GetInt32(0)==1)
            {
                role = dr.GetInt32(1);
            }
            else
            {
                role = 0;
                MessageBox.Show("Błędne dane!");
            }
            switch (role)
            { 
                case 1:
                    AdminPage adminPage = new AdminPage();
                    adminPage.Name = "AdminPage";
                    adminPage.Location = new Point(0, 0);
                    this.Parent.Controls.Add(adminPage);
                    this.Parent.Controls.Remove(this);
                    break;
                case 2:
                    EmployeePage employeePage = new EmployeePage();
                    employeePage.Name = "EmployeePage";
                    employeePage.Location = new Point(0, 0);
                    this.Parent.Controls.Add(employeePage);
                    this.Parent.Controls.Remove(this);
                    break;
                default:
                    MessageBox.Show("Błędne dane!");
                    break;
            }

            dr.Close();
            conn.Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            ((Form1)this.Parent).WelcomePageLoad();
            this.Parent.Controls.Remove(this);
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            textBoxLogin.Text = "pracownik";
            textBoxPassword.Text = "pracownik";
            ButtonLog_Click(sender, e);
        }
    }
}
