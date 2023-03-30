using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vista_concesionario
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pgrBar.Increment(1);
            if (pgrBar.Value == pgrBar.Maximum)
            {
                timer1.Stop();
                this.Hide();
                Parent formParent = new Parent();
                formParent.ShowDialog();
            }
        }
    }
}
