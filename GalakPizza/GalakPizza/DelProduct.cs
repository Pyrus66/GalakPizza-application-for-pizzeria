using GalakPizza.CustomsItems;
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
    public partial class DelProduct : UserControl
    {
        Dictionary<int, string> category = new Dictionary<int, string>();
        int currentCategory = 0;
        int currentProduct = 0;
        public DelProduct()
        {
            InitializeComponent();
            pullCategory();
            labelNameCategory.Text = category.ElementAt(currentCategory).Value.ToString();
            writeMenu();
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
                    category.Add(dr.GetInt32(0), dr.GetString(1));
                }
            }
            dr.Close();
            conn.Close();
        }
        public void writeMenu()
        {
            string connection = "Data Source=Damian-PC\\SQLEXPRESS;Initial Catalog=GalakPizza;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();

            string query = "SELECT * FROM Dodatki Where IDKategoriiDodatku=" + category.ElementAt(currentCategory).Key;
            SqlCommand sqlCommand = new SqlCommand(query, conn);

            SqlDataReader dr = sqlCommand.ExecuteReader();

            this.panelProducts.Controls.Clear();

            int height = 20;
            int width = 20;

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string categoryName = dr.GetString(2);
                    Button buttonCategory = new Button();
                    buttonCategory.Size = new System.Drawing.Size(340, 380);
                    buttonCategory.Location = new System.Drawing.Point(width, height);
                    buttonCategory.Text = dr.GetString(2) + "\n" + dr.GetDecimal(3) + " zł";
                    buttonCategory.TextAlign = ContentAlignment.BottomCenter;
                    buttonCategory.Name = dr.GetInt32(0).ToString();
                    buttonCategory.BackColor = Color.FromArgb(255, 230, 194);
                    buttonCategory.Font = new Font("Microsoft Sans Serif", 24);
                    PictureBox picture = new PictureBox();
                    picture.SizeMode = PictureBoxSizeMode.Zoom;
                    picture.Location = new System.Drawing.Point(30, 5);
                    picture.SizeMode = PictureBoxSizeMode.Zoom;
                    try
                    {
                        picture.Image = Image.FromFile(@"..\..\..\pictures\products\" + dr.GetString(4));

                    }
                    catch (Exception e)
                    {
                        picture.Image = Image.FromFile(@"..\..\..\pictures\products\error.png");
                    }
                    picture.Size = new Size(280, 280);
                    picture.Name = dr.GetInt32(0).ToString();

                    buttonCategory.Click += new System.EventHandler(chooseProduct);
                    picture.Click += new System.EventHandler(chooseProduct);

                    buttonCategory.Controls.Add(picture);

                    this.panelProducts.Controls.Add(buttonCategory);

                    if (width > 900)
                    {
                        height += 400;
                        width = 20;
                    }
                    else
                    {
                        width += 360;
                    }
                }
            }

            dr.Close();
            conn.Close();
        }
        private void chooseProduct(object sender, EventArgs e)
        {
            if (sender.GetType().ToString() == "System.Windows.Forms.Button")
            {
                currentProduct = Int32.Parse(((Button)sender).Name);
            }
            else
            {
                currentProduct = Int32.Parse(((PictureBox)sender).Name);
            }

            string connection = "Data Source=Damian-PC\\SQLEXPRESS;Initial Catalog=GalakPizza;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            string query = "SELECT * FROM Dodatki Where IDDodatku =" + currentProduct;
            SqlCommand sqlCommand = new SqlCommand(query, conn);

            SqlDataReader dr = sqlCommand.ExecuteReader();

            Panel panelcurrentProduct = new Panel();
            panelcurrentProduct.Name = "panelcurrentProduct";
            panelcurrentProduct.Location = new Point(0, 0);
            panelcurrentProduct.Size = new Size(1470, 1080);
            panelcurrentProduct.BackColor = Color.FromArgb(255, 242, 223);
            this.Controls.Add(panelcurrentProduct);
            panelcurrentProduct.BringToFront();

            PictureBox picture = new PictureBox();
            picture.Location = new System.Drawing.Point(548, 50);
            picture.Size = new Size(376, 376);
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            panelcurrentProduct.Controls.Add(picture);

            Label name = new Label();
            name.Name = "name";
            name.Size = new Size(400, 50);
            name.Location = new System.Drawing.Point(530, 450);
            name.Font = new Font("Microsoft Sans Serif", 32);
            name.TextAlign = ContentAlignment.MiddleCenter;
            panelcurrentProduct.Controls.Add(name);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    try
                    {
                        picture.Image = Image.FromFile(@"..\..\..\pictures\products\" + dr.GetString(4));

                    }
                    catch (Exception e2)
                    {
                        picture.Image = Image.FromFile(@"..\..\..\pictures\products\error.png");
                    }
                    panelcurrentProduct.Name = dr.GetInt32(0).ToString();
                    name.Text = dr.GetString(2);
                }
            }

            CustomButton modify = new CustomButton();
            modify.Text = "Usuń";
            modify.ForeColor = Color.White;
            modify.Size = new Size(400, 100);
            modify.Font = new Font(modify.Font.FontFamily, 28);
            modify.Location = new Point(530, 810);
            modify.Click += new System.EventHandler(delProduct);
            modify.BackColor = Color.Crimson;
            panelcurrentProduct.Controls.Add(modify);

            CustomButton cancel = new CustomButton();
            cancel.Text = "Cofnij";
            cancel.ForeColor = Color.White;
            cancel.Font = new Font(cancel.Font.FontFamily, 28);
            cancel.Size = new Size(400, 100);
            cancel.Location = new Point(530, 930);
            cancel.BackColor = Color.DarkSlateBlue;
            cancel.Click += new System.EventHandler(closePanel);
            panelcurrentProduct.Controls.Add(cancel);

            dr.Close();
            conn.Close();

        }
        void delProduct(object sender, EventArgs e)
        {
            int id = Int32.Parse(((CustomButton)sender).Parent.Name);
            Label name = (Label)((CustomButton)sender).Parent.Controls.Find("name", false)[0];

            string connection = "Data Source=Damian-PC\\SQLEXPRESS;Initial Catalog=GalakPizza;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connection);
            conn.Open();

            Dictionary<int, int> zamowienia = new Dictionary<int, int>();

            string query = $"Select IDZamowienia,count(IDSzczegolyZamowienia) from SzczegolyZamowienia " +
                $"where IDZamowienia in (Select z.IDZamowienia from Zamowienia as z, SzczegolyZamowienia as sz, SkladPizzy as sp " +
                $"where sz.IDZamowienia = z.IDZamowienia AND sz.IDSzczegolyZamowienia = sp.IDSzczegolyZamowienia AND sp.IDDodatku = {id}) group by IDZamowienia";
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            SqlDataReader dr = sqlCommand.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    zamowienia.Add(dr.GetInt32(0), dr.GetInt32(1));
                }
            }
            dr.Close();

            foreach (int a in zamowienia.Keys)
            {
                query = $"select sz.IDSzczegolyZamowienia from SzczegolyZamowienia as sz, SkladPizzy as sp " +
                    $"where sz.IDSzczegolyZamowienia = sp.IDSzczegolyZamowienia AND IDZamowienia = {a} AND sp.IDDodatku = {id}";
                sqlCommand = new SqlCommand(query, conn);
                dr = sqlCommand.ExecuteReader();
                query = $"DELETE FROM SkladPizzy WHERE IDSzczegolyZamowienia in (";
                string query2 = $"DELETE FROM SzczegolyZamowienia WHERE IDSzczegolyZamowienia in (";
                if (dr.HasRows)
                {
                    dr.Read();
                    query += $"{dr.GetInt32(0)}";
                    query2 += $"{dr.GetInt32(0)}";
                    while (dr.Read())
                    {
                        query += $",{dr.GetInt32(0)}";
                        query2 += $",{dr.GetInt32(0)}";
                    }
                }
                dr.Close();

                query += ")";
                query2 += ")";
                sqlCommand = new SqlCommand(query, conn);
                sqlCommand.ExecuteScalar();

                sqlCommand = new SqlCommand(query2, conn);
                sqlCommand.ExecuteScalar();

                if (zamowienia[a] == 1)
                {
                    query = $"DELETE FROM Zamowienia Where IDZamowienia = {a}";
                    sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.ExecuteScalar();
                }
            }

            query = $"DELETE FROM Dodatki WHERE IDDodatku={id}";
            sqlCommand = new SqlCommand(query, conn);
            sqlCommand.ExecuteScalar();

            MessageBox.Show("Usunięto pomyślnie");

            conn.Close();
            zamowienia.Clear();

            closePanel(sender, e);
        }
        void closePanel(object sender, EventArgs e)
        {
            ((CustomButton)sender).Parent.Parent.Controls.Remove(((CustomButton)sender).Parent);
            writeMenu();
        }
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (currentCategory - 1 >= 0)
            {
                currentCategory--;
                labelNameCategory.Text = category.ElementAt(currentCategory).Value.ToString();
                writeMenu();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (currentCategory + 1 <= category.Count() - 1)
            {
                currentCategory++;
                labelNameCategory.Text = category.ElementAt(currentCategory).Value.ToString();
                writeMenu();
            }
        }
    }
}
