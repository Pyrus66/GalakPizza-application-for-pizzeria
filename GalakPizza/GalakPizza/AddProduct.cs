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

namespace GalakPizza
{
    public partial class AddProduct : UserControl
    {
        Dictionary<string, int> category = new Dictionary<string, int>();
        public AddProduct()
        {
            InitializeComponent();
            pullCategory();
        }
        void pullCategory()
        {
            string connection = "Data Source=Damian-PC\\SQLEXPRESS;Initial Catalog=GalakPizza;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            string query = "SELECT * FROM KategoriaDodatkow";
            SqlCommand sqlCommand = new SqlCommand(query, conn);

            SqlDataReader dr = sqlCommand.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    category.Add(dr.GetString(1), dr.GetInt32(0));
                    chooseCategory.Items.Add(dr.GetString(1));
                }
            }
            dr.Close();
            conn.Close();
        }
        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            if (chooseCategory.SelectedItem == null || nameProduct.Text == "" || pictureProduct.Text == "" || priceProduct.Text == "")
            {
                MessageBox.Show("Brakuje danych!");
                return;
            }

            double a;
            string query;

            if (double.TryParse(priceProduct.Text, out a) || (double.TryParse(priceProduct.Text, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.CultureInfo.InvariantCulture, out a)))
            {
                query = $"Insert into Dodatki (Nazwa, IDKategoriiDodatku, Cena, Zdjecie, Dostepny) values ('{nameProduct.Text}',{category[chooseCategory.SelectedItem.ToString()]}, convert(decimal(5,2), replace('{priceProduct.Text}',',','.')), '{pictureProduct.Text}', 0)";
            }
            else
            {
                MessageBox.Show("Błedny format ceny!");
                return;
            }
            string connection = "Data Source=Damian-PC\\SQLEXPRESS;Initial Catalog=GalakPizza;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();

            SqlCommand sqlCommand = new SqlCommand(query, conn);
            sqlCommand.ExecuteScalar();

            MessageBox.Show("Produkt został dodany pomyślnie");

            conn.Close();
        }
    }
}
