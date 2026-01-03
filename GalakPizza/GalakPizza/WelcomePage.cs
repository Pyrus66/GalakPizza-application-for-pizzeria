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

namespace GalakPizza
{
    public partial class WelcomePage : UserControl
    {
        bool employee = false;
        public WelcomePage()
        {
            InitializeComponent();
        }
        private void buttonWelcomePageStart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                employee = true;
            }
        }
        private void customButton1_Click(object sender, EventArgs e)
        {
            if (employee)
            {
                LogPage logPage = new LogPage();
                logPage.Name = "LogPage";
                logPage.Location = new Point(0, 0);
                this.Parent.Controls.Add(logPage);
                this.Parent.Controls.Remove(this);
            }
            else
            {
                TakeOutPage takeOutPage = new TakeOutPage();
                takeOutPage.Name = "TakeOutPage";
                takeOutPage.Location = new Point(0, 0);
                this.Parent.Controls.Add(takeOutPage);
                this.Parent.Controls.Remove(this);
            }

        }
    }
}
