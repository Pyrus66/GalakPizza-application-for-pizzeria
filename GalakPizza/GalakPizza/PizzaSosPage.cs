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
    public partial class PizzaSosPage : UserControl
    {
        List<Extras> pizzaSosList = Form1.LoadExtras(6, 1);
        public PizzaSosPage()
        {
            InitializeComponent();
        }
        ~PizzaSosPage()
        {
            pizzaSosList.Clear();
        }
        internal void WritePizzaSos()
        {
            this.Controls.Clear();

            Label label = new Label();
            label.Text = "Wybierz sos do pizzy(opcjonalne)";
            label.Location = new Point(20, 20);
            label.Font = new Font("Microsoft Sans Serif", 24);
            label.AutoSize = true;
            this.Controls.Add(label);

            int height = 80;
            int width = 20;

            foreach (Extras a in pizzaSosList)
            {

                PizzaSosPageProduct pizzaSosPageProduct = new PizzaSosPageProduct();

                pizzaSosPageProduct.Sos = a;
                if (((CustomPizzaPage)this.Parent.Parent).PizzaSos.ContainsKey(a.Id))
                {
                    pizzaSosPageProduct.Count = ((CustomPizzaPage)this.Parent.Parent).PizzaSos[a.Id];
                }
                else
                {
                    pizzaSosPageProduct.Count = 0;
                }
                pizzaSosPageProduct.LabelName.Text = a.Name;

                try
                {
                    pizzaSosPageProduct.PictureBox.Image = Image.FromFile(@"..\..\..\pictures\products\" + a.ImagePath);

                }
                catch (Exception)
                {
                    pizzaSosPageProduct.PictureBox.Image = Image.FromFile(@"..\..\..\pictures\products\error.png");
                }

                pizzaSosPageProduct.Location = new Point(width, height);
                pizzaSosPageProduct.updateLabel();
                this.Controls.Add(pizzaSosPageProduct);

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
        private void PizzaSosPage_Load(object sender, EventArgs e)
        {
            WritePizzaSos();
        }
    }
}
