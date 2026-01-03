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
    public partial class PizzaCheesePage : UserControl
    {
        List<Extras> pizzaCheeseList = Form1.LoadExtras(3, 1);
        public PizzaCheesePage()
        {
            InitializeComponent();
        }
        ~PizzaCheesePage()
        {
            pizzaCheeseList.Clear();
        }
        void WritePizzaCheese()
        {
            this.Controls.Clear();

            Label label = new Label();
            label.Text = "Wybierz ilość sera do pizzy";
            label.Location = new Point(20, 20);
            label.Font = new Font("Microsoft Sans Serif", 24);
            label.AutoSize = true;
            this.Controls.Add(label);

            int height = 80;
            int width = 20;

            foreach (Extras a in pizzaCheeseList)
            {
                Button button = new Button();
                button.Name = a.Id.ToString();
                button.Text = a.Name + "\n+" + a.Price + "zł";
                button.Size = new System.Drawing.Size(340, 380);
                button.Location = new System.Drawing.Point(width, height);
                button.TextAlign = ContentAlignment.BottomCenter;
                button.Font = new Font("Microsoft Sans Serif", 24);

                if (((CustomPizzaPage)this.Parent.Parent).PizzaCheese == a.Id)
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

                if (width > 1100)
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
                ((CustomPizzaPage)this.Parent.Parent).PizzaCheese = Int32.Parse(((Button)sender).Name);
            }
            else
            {
                ((CustomPizzaPage)this.Parent.Parent).PizzaCheese = Int32.Parse(((PictureBox)sender).Name);
            }
            WritePizzaCheese();
        }
        private void PizzaCheesePage_Load(object sender, EventArgs e)
        {
            if (((CustomPizzaPage)this.Parent.Parent).PizzaCheese == 0)
            {
                ((CustomPizzaPage)this.Parent.Parent).PizzaCheese = pizzaCheeseList.First().Id;
            }
            WritePizzaCheese();
        }
    }
}
