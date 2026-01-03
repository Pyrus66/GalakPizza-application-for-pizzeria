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
    public partial class PaymentPage : UserControl
    {
        public PaymentPage(Form1 a)
        {
            InitializeComponent();

            string connection = "Data Source=Damian-PC\\SQLEXPRESS;Initial Catalog=GalakPizza;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            int boolConverter;
            if (a.TakeOut)
            {
                boolConverter = 1;
            }
            else
            {
                boolConverter = 0;
            }
            try
            {

                string query = $"INSERT INTO Zamowienia (Data, Godzina, NaWynos, Zrealizowano) OUTPUT INSERTED.IDZamowienia Values (Convert(Date,GETDATE()), Convert(time,GETDATE()), {boolConverter}, 0);";
                SqlCommand sqlCommand = new SqlCommand(query, conn);

                int idOrder = Int32.Parse(sqlCommand.ExecuteScalar().ToString());
                labelInfo.Text += $"\n{idOrder}";

                foreach (Pizza tmpPizza in a.PizzaList)
                {
                    query = $"Insert into SzczegolyZamowienia ( IDZamowienia, Przygotowane) OUTPUT INSERTED.IDSzczegolyZamowienia values({idOrder}, 0)";
                    sqlCommand = new SqlCommand(query, conn);
                    int idOrderDetails = Int32.Parse(sqlCommand.ExecuteScalar().ToString());

                    //PizzaDough
                    query = $"Insert into SkladPizzy ( IDSzczegolyZamowienia, IDDodatku, Ilosc) values({idOrderDetails}, {tmpPizza.PizzaDough}, 1)";
                    sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.ExecuteScalar();
                    //PizzaBase
                    query = $"Insert into SkladPizzy ( IDSzczegolyZamowienia, IDDodatku, Ilosc) values({idOrderDetails}, {tmpPizza.PizzaBase}, 1)";
                    sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.ExecuteScalar();
                    //PizzaCheese
                    query = $"Insert into SkladPizzy ( IDSzczegolyZamowienia, IDDodatku, Ilosc) values({idOrderDetails}, {tmpPizza.Cheeese}, 1)";
                    sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.ExecuteScalar();
                    //PizzaMeat
                    foreach(int tmpInt in tmpPizza.Meat)
                    {
                        query = $"Insert into SkladPizzy ( IDSzczegolyZamowienia, IDDodatku, Ilosc) values({idOrderDetails}, {tmpInt}, 1)";
                        sqlCommand = new SqlCommand(query, conn);
                        sqlCommand.ExecuteScalar();
                    }
                    //PizzaNoMeat
                    foreach (int tmpInt in tmpPizza.NotMeat)
                    {
                        query = $"Insert into SkladPizzy ( IDSzczegolyZamowienia, IDDodatku, Ilosc) values({idOrderDetails}, {tmpInt}, 1)";
                        sqlCommand = new SqlCommand(query, conn);
                        sqlCommand.ExecuteScalar();
                    }
                    //PizzaSos
                    foreach (int tmpInt in tmpPizza.Sos.Keys)
                    {
                        query = $"Insert into SkladPizzy ( IDSzczegolyZamowienia, IDDodatku, Ilosc) values({idOrderDetails}, {tmpInt}, {tmpPizza.Sos[tmpInt]})";
                        sqlCommand = new SqlCommand(query, conn);
                        sqlCommand.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("no jakiś błąd kolego :c"); 
            }
            conn.Close();
        }

        private void PaymentPage_Click(object sender, EventArgs e)
        {
            ((Form1)this.Parent).ResetVar();
            ((Form1)this.Parent).WelcomePageLoad();
            this.Parent.Controls.Remove(this);
        }
    }
}
