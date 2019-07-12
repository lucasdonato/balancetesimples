using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalanceteSimples
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progresso.Value < 100)
            {
                progresso.Value = progresso.Value + 2;
            }
            else
            {
                timer1.Enabled = false;
                this.Visible = false;
                Login log = new Login();
                log.Show();
            }
        }
    }
}
