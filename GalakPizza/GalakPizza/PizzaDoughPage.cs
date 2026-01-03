using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GalakPizza.Form1;

namespace GalakPizza
{
    public partial class PizzaDoughPage : UserControl
    {
        List<Extras> pizzaDoughList = Form1.LoadExtras(1, 1);
        public PizzaDoughPage()
        {
            InitializeComponent();
        }
        ~PizzaDoughPage()
        {
            pizzaDoughList.Clear();
        }
        void WritePizzaDough()
        {
            this.Controls.Clear();

            Label label = new Label();
            label.Text = "Wybierz rodzaj ciasta do pizzy";
            label.Location = new Point(20, 20);
            label.Font = new Font("Microsoft Sans Serif", 24);
            label.AutoSize = true;
            this.Controls.Add(label);

            int height = 80;
            int width = 20;

            foreach (Extras a in pizzaDoughList)
            {
                Button button = new Button();
                button.Name = a.Id.ToString();
                button.Text = a.Name + "\n+" + a.Price + "zł";
                button.Size = new System.Drawing.Size(340, 380);
                button.Location = new System.Drawing.Point(width, height);
                button.TextAlign = ContentAlignment.BottomCenter;
                button.Font = new Font("Microsoft Sans Serif", 24);

                if (((CustomPizzaPage)this.Parent.Parent).PizzaDough == a.Id)
                {
                    button.BackColor = Color.FromArgb(240, 200, 144);
                }
                else
                {
                    button.BackColor = Color.FromArgb(255, 230, 194);
                }

                PictureBox picture = new PictureBox();
                picture.SizeMode = PictureBoxSizeMode.Zoom;
                picture.Location = new System.Drawing.Point(30, 5);
                try
                {
                    picture.Image = Image.FromFile(@"..\..\..\pictures\products\" + a.ImagePath);

                }
                catch (Exception e)
                {
                    picture.Image = Image.FromFile(@"..\..\..\pictures\products\error.png");
                }
                picture.Size = new Size(280, 280);
                picture.Name = a.Id.ToString();

                button.Click += new System.EventHandler(chooseProduct);
                picture.Click += new System.EventHandler(chooseProduct);

                button.Controls.Add(picture);

                this.Controls.Add(button);

                if (width > 11000)
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
        void chooseProduct(object sender, EventArgs e)
        {
            if (sender.GetType().ToString() == "System.Windows.Forms.Button")
            {
                ((CustomPizzaPage)this.Parent.Parent).PizzaDough = Int32.Parse(((Button)sender).Name);
            }
            else
            {
                ((CustomPizzaPage)this.Parent.Parent).PizzaDough = Int32.Parse(((PictureBox)sender).Name);
            }
            WritePizzaDough();
        }
        private void PizzaDoughPage_Load(object sender, EventArgs e)
        {
            if (((CustomPizzaPage)this.Parent.Parent).PizzaDough == 0)
            {
                ((CustomPizzaPage)this.Parent.Parent).PizzaDough = pizzaDoughList.First().Id;
            }
            WritePizzaDough();
        }
    }
}
