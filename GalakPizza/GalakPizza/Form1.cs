using NAudio.Wave;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GalakPizza.TakeOutPage;
namespace GalakPizza
{
    public partial class Form1 : Form
    {
        List<Pizza> pizzaList = new List<Pizza>();
        bool takeOut;

        internal List<Pizza> PizzaList { get => pizzaList;  set => pizzaList = value;  }
        public bool TakeOut { get { return takeOut; } set { takeOut = value; } }

        public Form1()
        {
            InitializeComponent();
            ResetVar();
            WelcomePageLoad();
        }
        internal class Pizza
        {
            int pizzaID;
            int pizzaDough;
            int pizzaBase;
            int cheeese;
            List<int> meat = new List<int>();
            List<int> notMeat = new List<int>();
            Dictionary<int, int> sos = new Dictionary<int, int>();
            public int PizzaDough { get => pizzaDough; set => pizzaDough = value; }
            public int PizzaBase { get => pizzaBase; set => pizzaBase = value; }
            public int Cheeese { get => cheeese; set => cheeese = value; }
            public List<int> Meat { get => meat; set => meat = value; }
            public List<int> NotMeat { get => notMeat; set => notMeat = value; }
            public Dictionary<int, int> Sos { get => sos; set => sos = value; }
            internal Pizza(int pizzaDough, int pizzaBase, int cheeese, List<int> meat, List<int> notMeat, Dictionary<int, int> sos)
            {
                this.pizzaDough = pizzaDough;
                this.pizzaBase = pizzaBase;
                this.cheeese = cheeese;
                this.meat = meat;
                this.notMeat = notMeat;
                this.sos = sos;
            }
            internal Pizza(int pizzaID, int pizzaDough, int pizzaBase, int cheeese, List<int> meat, List<int> notMeat, Dictionary<int, int> sos)
            {
                this.pizzaID = pizzaID;
                this.pizzaDough = pizzaDough;
                this.pizzaBase = pizzaBase;
                this.cheeese = cheeese;
                this.meat = meat;
                this.notMeat = notMeat;
                this.sos = sos;
            }

        }
        internal class Extras
        {
            int id;
            int idkd;
            string name;
            decimal price;
            string imagePath;
            bool available;

            public int Id { get => id; set => id = value; }
            public int Idkd { get => idkd; set => idkd = value; }
            public string Name { get => name; set => name = value; }
            public decimal Price { get => price; set => price = value; }
            public string ImagePath { get => imagePath; set => imagePath = value; }

            public Extras(int id, int idkd, string name, decimal price, string imagePath)
            {
                this.id = id;
                this.idkd = idkd;
                this.name = name;
                this.price = price;
                this.imagePath = imagePath;
            }
            public Extras(int id, int idkd, string name, decimal price, string imagePath, bool available)
            {
                this.id = id;
                this.idkd = idkd;
                this.name = name;
                this.price = price;
                this.imagePath = imagePath;
                this.available = available;
            }
        }
        internal void ResetVar()
        {
            takeOut = false;
            pizzaList.Clear();
        }
        internal void WelcomePageLoad()
        {
            WelcomePage welcomePage = new WelcomePage();
            welcomePage.Name = "WelcomePage";
            welcomePage.Location = new Point(0, 0);
            this.Controls.Add(welcomePage);
            welcomePage.Show();
        }
        static internal List<Extras> LoadExtras(int category, int? available = null)
        {
            List<Extras> tmp = new List<Extras>();
            string connection = "Data Source=Damian-PC\\SQLEXPRESS;Initial Catalog=GalakPizza;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();

            string query;

            if (available != null)
            {
                query = $"select * From Dodatki Where IDKategoriiDodatku={category} AND Dostepny={available}";
            }
            else
            {
               query = $"select * From Dodatki Where IDKategoriiDodatku={category}";
            }
            SqlCommand sqlCommand = new SqlCommand(query, conn);

            SqlDataReader dr = sqlCommand.ExecuteReader();

            if (dr.HasRows & available != null)
            {
                while (dr.Read())
                {
                    tmp.Add(new Extras(dr.GetInt32(0), dr.GetInt32(1), dr.GetString(2), dr.GetDecimal(3), dr.GetString(4)));
                }
            }
            if (dr.HasRows & available == null)
            {
                while (dr.Read())
                {
                    tmp.Add(new Extras(dr.GetInt32(0), dr.GetInt32(1), dr.GetString(2), dr.GetDecimal(3), dr.GetString(4), dr.GetBoolean(5)));
                }
            }

            dr.Close();
            conn.Close();

            return tmp;
        }
    }
}
