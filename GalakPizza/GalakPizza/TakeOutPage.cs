using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GalakPizza.Form1;
namespace GalakPizza
{
    public partial class TakeOutPage : UserControl
    {
        public TakeOutPage()
        {
            SoundPlayer soundPlayer = new SoundPlayer("../../../pictures/galakpizza.wav");
            soundPlayer.Play();
            InitializeComponent();
        }

        private void EatThereButton_Click(object sender, EventArgs e)
        {
            ((Form1)this.Parent).TakeOut = false;
            MenuPageLoad();
        }
        private void TakeOutButton_Click(object sender, EventArgs e)
        {
            ((Form1)this.Parent).TakeOut = true;
            MenuPageLoad();
        }
        void MenuPageLoad()
        {
            CustomPizzaPage customPizzaPage = new CustomPizzaPage();
            customPizzaPage.Name = "CustomPizzaPage";
            customPizzaPage.Location = new Point(0, 0);
            this.Parent.Controls.Add(customPizzaPage);
            this.Parent.Controls.Remove(this);
        }
    }
}
