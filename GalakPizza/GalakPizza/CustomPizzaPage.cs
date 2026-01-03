using GalakPizza.CustomsItems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static GalakPizza.Form1;

namespace GalakPizza
{
    public partial class CustomPizzaPage : UserControl
    {
        bool modify = false;
        int pizzaIndex;
        int currentScreen = 1;
        int pizzaDough = 0;
        int pizzaBase = 0;
        int pizzaCheese = 0;
        List<int> pizzaMeat = new List<int>();
        List<int> pizzaNoMeat = new List<int>();
        Dictionary<int, int> pizzaSos = new Dictionary<int, int>();

        public int PizzaDough { get => pizzaDough; set => pizzaDough = value; }
        public int PizzaBase { get => pizzaBase; set => pizzaBase = value; }
        public int PizzaCheese { get => pizzaCheese; set => pizzaCheese = value; }
        public List<int> PizzaMeat { get => pizzaMeat; set => pizzaMeat = value; }
        public List<int> PizzaNoMeat { get => pizzaNoMeat; set => pizzaNoMeat = value; }
        public Dictionary<int, int> PizzaSos { get => pizzaSos; set => pizzaSos = value; }

        public CustomPizzaPage()
        {
            InitializeComponent();
            LoadPizzaDoughPage();
            CustomButton buttonNext = new CustomButton();
            buttonNext.Size = new Size(300, 100);
            buttonNext.Location = new Point(1600, 950);
            buttonNext.Text = "Dalej";
            buttonNext.Font = new Font(buttonNext.Font.FontFamily,36);
            buttonNext.Click += new EventHandler(ButtonNext_Click);
            buttonNext.BackColor = Color.DarkSlateBlue;
            this.Controls.Add(buttonNext);
            buttonNext.BringToFront();
        }
        void updateSreen()
        {
            switch(currentScreen)
            {
                case 1:
                    LoadPizzaDoughPage();
                    break;
                case 2:
                    LoadPizzaBasePage();
                    break;
                case 3:
                    LoadPizzaCheesePage();
                    break;
                case 4:
                    LoadPizzaMeatPage();
                    break;
                case 5:
                    LoadPizzaNoMeatPage();
                    break;
                case 6:
                    LoadPizzaSosPage();
                    break;
                case 7:
                    if(pizzaDough != 0 && pizzaBase != 0 && pizzaCheese != 0)
                    {
                        SendOrder();
                    }
                    else
                    {
                        currentScreen = 6;
                        LoadPizzaSosPage();
                    }
                    break;
            }
        }
        void ButtonChange(string name)
        {
            Dictionary<string, int> tmp = new Dictionary<string, int>();
            tmp.Add("PizzaDough", pizzaDough);
            tmp.Add("PizzaBase", pizzaBase);
            tmp.Add("PizzaCheese", pizzaCheese);
            tmp.Add("PizzaMeat", pizzaMeat.Count());
            tmp.Add("PizzaNoMeat", pizzaNoMeat.Count());
            tmp.Add("PizzaSos", pizzaSos.Count());

            if (tmp[name] != 0)
            {
                this.NavPanel.Controls.Find("Button" + name, false)[0].BackColor = Color.FromArgb(70, 130, 100);
            }
            else
            {
                this.NavPanel.Controls.Find("Button" + name, false)[0].BackColor = Color.DarkSlateBlue;
            }

            tmp.Clear();
        }
        void LoadPizzaDoughPage()
        {
            if(this.Controls.Find("PizzaDough", false).Count() == 0)
            {
                try
                {
                    ButtonChange(this.ContentPanel.Controls[0].Name);
                }
                catch
                { }
                this.ContentPanel.Controls.Clear();
                PizzaDoughPage pizzaDoughPage = new PizzaDoughPage();
                pizzaDoughPage.Name = "PizzaDough";
                pizzaDoughPage.Location = new Point(0, 0);
                this.ContentPanel.Controls.Add(pizzaDoughPage);
                this.NavPanel.Controls.Find("Button" + pizzaDoughPage.Name, false)[0].BackColor = Color.FromArgb(189, 92, 100);
            }
        }
        void LoadPizzaBasePage()
        {
            if (this.Controls.Find("PizzaBase", false).Count() == 0)
            {
                ButtonChange(this.ContentPanel.Controls[0].Name);
                this.ContentPanel.Controls.Clear();
                PizzaBasePage pizzaBasePage = new PizzaBasePage();
                pizzaBasePage.Name = "PizzaBase";
                pizzaBasePage.Location = new Point(0, 0);
                this.ContentPanel.Controls.Add(pizzaBasePage);
                this.NavPanel.Controls.Find("Button" + pizzaBasePage.Name, false)[0].BackColor = Color.FromArgb(189, 92, 100);
            }
        }
        void LoadPizzaCheesePage()
        {
            if (this.Controls.Find("PizzaCheese", false).Count() == 0)
            {
                ButtonChange(this.ContentPanel.Controls[0].Name);
                this.ContentPanel.Controls.Clear();
                PizzaCheesePage pizzaCheesePage = new PizzaCheesePage();
                pizzaCheesePage.Name = "PizzaCheese";
                pizzaCheesePage.Location = new Point(0, 0);
                this.ContentPanel.Controls.Add(pizzaCheesePage);
                this.NavPanel.Controls.Find("Button" + pizzaCheesePage.Name, false)[0].BackColor = Color.FromArgb(189, 92, 100);
            }
        }
        void LoadPizzaMeatPage()
        {
            if (this.Controls.Find("PizzaMeat", false).Count() == 0)
            {
                ButtonChange(this.ContentPanel.Controls[0].Name);
                this.ContentPanel.Controls.Clear();
                PizzaMeatPage pizzaMeatPage = new PizzaMeatPage();
                pizzaMeatPage.Name = "PizzaMeat";
                pizzaMeatPage.Location = new Point(0, 0);
                this.ContentPanel.Controls.Add(pizzaMeatPage);
                this.NavPanel.Controls.Find("Button" + pizzaMeatPage.Name, false)[0].BackColor = Color.FromArgb(189, 92, 100);
            }
        }
        void LoadPizzaNoMeatPage()
        {
            if (this.Controls.Find("PizzaNoMeat", false).Count() == 0)
            {
                ButtonChange(this.ContentPanel.Controls[0].Name);
                this.ContentPanel.Controls.Clear();
                PizzaNoMeatPage pizzaNoMeatPage = new PizzaNoMeatPage();
                pizzaNoMeatPage.Name = "PizzaNoMeat";
                pizzaNoMeatPage.Location = new Point(0, 0);
                this.ContentPanel.Controls.Add(pizzaNoMeatPage);
                this.NavPanel.Controls.Find("Button" + pizzaNoMeatPage.Name, false)[0].BackColor = Color.FromArgb(189, 92, 100);
            }
        }
        void LoadPizzaSosPage()
        {
            if (this.Controls.Find("PizzaSos", false).Count() == 0)
            {
                ButtonChange(this.ContentPanel.Controls[0].Name);
                this.ContentPanel.Controls.Clear();
                PizzaSosPage pizzaSosPage = new PizzaSosPage();
                pizzaSosPage.Name = "PizzaSos";
                pizzaSosPage.Location = new Point(0, 0);
                this.ContentPanel.Controls.Add(pizzaSosPage);
                this.NavPanel.Controls.Find("Button" + pizzaSosPage.Name, false)[0].BackColor = Color.FromArgb(189, 92, 100);
            }
        }
        private void ButtonPizzaDough_Click(object sender, EventArgs e)
        {
            currentScreen = 1;
            LoadPizzaDoughPage();
        }
        private void ButtonPizzaBase_Click(object sender, EventArgs e)
        {
            currentScreen = 2;
            LoadPizzaBasePage();
        }
        private void ButtonPizzaCheese_Click(object sender, EventArgs e)
        {
            currentScreen = 3;
            LoadPizzaCheesePage();
        }

        private void ButtonPizzaMeat_Click(object sender, EventArgs e)
        {
            currentScreen = 4;
            LoadPizzaMeatPage();
        }

        private void ButtonPizzaNoMeat_Click(object sender, EventArgs e)
        {
            currentScreen = 5;
            LoadPizzaNoMeatPage();
        }

        private void ButtonPizzaSos_Click(object sender, EventArgs e)
        {
            currentScreen = 6;
            LoadPizzaSosPage();
        }
        internal void ModifyPizza(int a)
        {
            modify = true;
            pizzaIndex = a;
            PizzaDough = ((Form1)this.Parent).PizzaList[pizzaIndex].PizzaDough;
            PizzaBase = ((Form1)this.Parent).PizzaList[pizzaIndex].PizzaBase;
            PizzaCheese = ((Form1)this.Parent).PizzaList[pizzaIndex].Cheeese;
            PizzaMeat = ((Form1)this.Parent).PizzaList[pizzaIndex].Meat;
            PizzaNoMeat = ((Form1)this.Parent).PizzaList[pizzaIndex].NotMeat;
            PizzaSos = ((Form1)this.Parent).PizzaList[pizzaIndex].Sos;

            Dictionary<string, int> tmp = new Dictionary<string, int>();
            tmp.Add("PizzaDough", PizzaDough);
            tmp.Add("PizzaBase", PizzaBase);
            tmp.Add("PizzaCheese", pizzaCheese);
            tmp.Add("PizzaMeat", PizzaMeat.Count());
            tmp.Add("PizzaNoMeat", PizzaNoMeat.Count());
            tmp.Add("PizzaSos", PizzaSos.Count());

            foreach (string tmpString in tmp.Keys)
            {
                if (tmp[tmpString]>0)
                {
                    this.NavPanel.Controls.Find("Button" + tmpString, false)[0].BackColor = Color.FromArgb(70, 130, 100); ;
                }
                else
                {
                    this.NavPanel.Controls.Find("Button" + tmpString, false)[0].BackColor = Color.DarkSlateBlue;
                }
            }

            LoadPizzaDoughPage();
        }
        void SendOrder()
        {
            if(modify)
            {
                ((Form1)this.Parent).PizzaList[pizzaIndex] = new Pizza(PizzaDough, PizzaBase, pizzaCheese, pizzaMeat, pizzaNoMeat, pizzaSos);
                SummaryOrderPage summaryOrderPage = new SummaryOrderPage();
                summaryOrderPage.Name = "SummaryOrderPage";
                summaryOrderPage.Location = new Point(0, 0);

                this.Parent.Controls.Add(summaryOrderPage);
                this.Parent.Controls.Remove(this);
            }
            else
            {
                ((Form1)this.Parent).PizzaList.Add(new Pizza(PizzaDough, PizzaBase, pizzaCheese, pizzaMeat, pizzaNoMeat, pizzaSos));

                SummaryOrderPage summaryOrderPage = new SummaryOrderPage();
                summaryOrderPage.Name = "SummaryOrderPage";
                summaryOrderPage.Location = new Point(0, 0);

                this.Parent.Controls.Add(summaryOrderPage);
                this.Parent.Controls.Remove(this);
            }
            
        }
        private void ButtonSummary_Click(object sender, EventArgs e)
        {
            SendOrder();
        }
        private void ButtonNext_Click(object sender, EventArgs e)
        {
            if (currentScreen + 1 <= 7)
            {
                currentScreen++;
                updateSreen();
            }
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            if(((Form1)this.Parent).PizzaList.Count>0)
            {
                SummaryOrderPage summaryOrderPage = new SummaryOrderPage();
                summaryOrderPage.Name = "SummaryOrderPage";
                summaryOrderPage.Location = new Point(0, 0);

                this.Parent.Controls.Add(summaryOrderPage);
                this.Parent.Controls.Remove(this);
            }
            else
            {
                ((Form1)this.Parent).WelcomePageLoad();
                this.Parent.Controls.Remove(this);
            }
        }

        private void ContentPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            if (pizzaDough != 0 && pizzaBase != 0 && pizzaCheese != 0)
            {
                ButtonSummary.BackColor = Color.DarkSlateBlue;
                ButtonSummary.Enabled = true;
            }
        }
    }
}