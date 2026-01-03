using GalakPizza.CustomsItems;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GalakPizza.Form1;

namespace GalakPizza
{
    public partial class SummaryOrderPage : UserControl
    {
        decimal price;

        public SummaryOrderPage()
        {
            InitializeComponent();
        }
        void WriteOrder()
        {
            this.panelContent.Controls.Clear();
            price = 0;
            string connection = "Data Source=Damian-PC\\SQLEXPRESS;Initial Catalog=GalakPizza;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            string query = "SELECT * FROM KategoriaDodatkow Order By IDKategoriiDodatku";
            SqlCommand sqlCommand = new SqlCommand(query, conn);

            SqlDataReader dr = sqlCommand.ExecuteReader();

            Dictionary<int, string> categoryName = new Dictionary<int, string>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    categoryName.Add(dr.GetInt32(0),dr.GetString(1));
                }
            }

            dr.Close();

            int height = 20;

            foreach (Pizza a in ((Form1)this.Parent).PizzaList)
            {
                Panel panel = new Panel();
                panel.Name = ((Form1)this.Parent).PizzaList.IndexOf(a).ToString();
                panel.Size = new System.Drawing.Size(1860, 300);
                panel.AutoScroll = true;
                panel.Location = new System.Drawing.Point( 20, height);
                panel.BackColor = Color.FromArgb(240, 200, 144);

                query = $"select * From Dodatki Where IDDodatku in ( {a.PizzaDough}, {a.PizzaBase}, {a.Cheeese}";
                foreach(int tmp in a.Meat)
                {
                    query += ", "+tmp;
                }
                foreach (int tmp in a.NotMeat)
                {
                    query += ", " + tmp;
                }
                foreach (int tmp in a.Sos.Keys)
                {
                    query += ", " + tmp;
                }
                query += ") Order by IDKategoriiDodatku, Nazwa";
                Label composition = new Label();
                composition.Location = new Point(0, 0);
                composition.Text = "";
                composition.Font = new Font("Microsoft Sans Serif", 24);
                composition.Size = new System.Drawing.Size(1400, 300);
                composition.AutoEllipsis = true;
                panel.Controls.Add(composition);

                sqlCommand = new SqlCommand(query, conn);

                dr = sqlCommand.ExecuteReader();
                int tmpInt = 0;

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if(dr.GetInt32(1) != tmpInt)
                        {
                            if(tmpInt!=0)
                            {
                                composition.Text += "\n";
                            }
                            tmpInt = dr.GetInt32(1);
                            composition.Text += $"{categoryName[tmpInt]}: ";
                        }
                        if(tmpInt!=6)
                        {
                            composition.Text += $"{dr.GetString(2)}; ";
                            price += dr.GetDecimal(3);
                        }
                        else
                        {
                            composition.Text += $"{dr.GetString(2)} x {a.Sos[dr.GetInt32(0)]} ";
                            price += dr.GetDecimal(3) * a.Sos[dr.GetInt32(0)];
                        }
                    }
                    
                }

                dr.Close();
                
                CustomButton modify = new CustomButton();
                modify.Text = "Modyfikuj";
                modify.Name = "ButtonModify";
                modify.Size = new Size(200, 80);
                modify.Location = new Point(1425, 200);
                modify.Click += new EventHandler(ModifyPizza);
                modify.Font=new Font("Microsoft Sans Serif", 24);
                modify.BackColor = Color.DarkSlateBlue;
                panel.Controls.Add(modify);

                CustomButton del = new CustomButton();
                del.Text = "Usuń";
                del.Name = "ButtonDel";
                del.Size = new Size(200, 80);
                del.Location = new Point(1650, 200);
                del.Click += new EventHandler(DelPizza);
                del.Font = new Font("Microsoft Sans Serif", 24);
                del.BackColor = Color.Crimson;
                panel.Controls.Add(del);
                labelPrice.Text = $"Za całość: {price} zł";
                this.panelContent.Controls.Add(panel);

                height += 320;
            }
            conn.Close();
            labelPrice.Text = $"Za całość: {price} zł";
        }
        void ModifyPizza(object sender, EventArgs e)
        {
            CustomPizzaPage customPizzaPage = new CustomPizzaPage();
            customPizzaPage.Name = "CustomPizzaPage";
            customPizzaPage.Location = new Point(0, 0);
            this.Parent.Controls.Add(customPizzaPage);
            customPizzaPage.ModifyPizza( Int32.Parse(((CustomButton)sender).Parent.Name) );
            this.Parent.Controls.Remove(this);
        }
        void DelPizza(object sender, EventArgs e)
        {
            ((Form1)this.Parent).PizzaList.RemoveAt(Int32.Parse(((CustomButton)sender).Parent.Name));
            if (((Form1)this.Parent).PizzaList.Count() > 0)
            {
                WriteOrder();
            }
            else
            {
                CustomPizzaPage customPizzaPage = new CustomPizzaPage();
                customPizzaPage.Name = "CustomPizzaPage";
                customPizzaPage.Location = new Point(0, 0);
                this.Parent.Controls.Add(customPizzaPage);
                this.Parent.Controls.Remove(this);
            }
        }
        private void SummaryOrderPage_Load(object sender, EventArgs e)
        {
            WriteOrder();
        }
        void ButtonAdd(object sender, EventArgs e)
        {
            CustomPizzaPage customPizzaPage = new CustomPizzaPage();
            customPizzaPage.Name = "CustomPizzaPage";
            customPizzaPage.Location = new Point(0, 0);
            this.Parent.Controls.Add(customPizzaPage);
            this.Parent.Controls.Remove(this);
        }
        private void ButtonPay_Click(object sender, EventArgs e)
        {
            PaymentPage paymentPage = new PaymentPage(((Form1)this.Parent));
            paymentPage.Name = "PaymentPage";
            paymentPage.Location = new Point(0, 0);
            this.Parent.Controls.Add(paymentPage);
            this.Parent.Controls.Remove(this);
        }

        private void ButtonCancelOrder_Click(object sender, EventArgs e)
        {
            ((Form1)this.Parent).ResetVar();
            ((Form1)this.Parent).WelcomePageLoad();
            this.Parent.Controls.Remove(this);
        }
    }
}
