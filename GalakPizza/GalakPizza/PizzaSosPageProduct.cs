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
    public partial class PizzaSosPageProduct : UserControl
    {
        Extras sos;
        int count;

        internal Extras Sos { get => sos; set => sos = value; }
        public int Count { get => count; set => count = value; }
        public PictureBox PictureBox { get => pictureBox; set => pictureBox = value; }
        public Label LabelName { get => labelName; set => labelName = value; }

        public PizzaSosPageProduct()
        {
            InitializeComponent();
        }
        internal void updateLabel()
        {
            labelCount.Text = Count.ToString();
            labelPrice.Text = (Sos.Price * Count).ToString() + " zł";
        }
        private void ButtonMore_Click(object sender, EventArgs e)
        {
            if (count + 1 > 0 && count + 1 < 100)
            {
                count++;
                if (((CustomPizzaPage)this.Parent.Parent.Parent).PizzaSos.ContainsKey(sos.Id))
                {
                    ((CustomPizzaPage)this.Parent.Parent.Parent).PizzaSos[sos.Id] = count;
                }
                else
                {
                    ((CustomPizzaPage)this.Parent.Parent.Parent).PizzaSos.Add(sos.Id, count);
                }
                updateLabel();
            }
        }
        private void ButtonLess_Click(object sender, EventArgs e)
        {
            if(count - 1 == 0)
            {
                count--;
                ((CustomPizzaPage)this.Parent.Parent.Parent).PizzaSos.Remove(sos.Id);
                updateLabel();
            }
            if (count - 1 > 0 && count - 1 < 100)
            {
                count--;
                if (((CustomPizzaPage)this.Parent.Parent.Parent).PizzaSos.ContainsKey(sos.Id))
                {
                    ((CustomPizzaPage)this.Parent.Parent.Parent).PizzaSos[sos.Id] = count;
                }
                else
                {
                    ((CustomPizzaPage)this.Parent.Parent.Parent).PizzaSos.Add(sos.Id, count);
                }
                updateLabel();
            }
        }
    }
}
