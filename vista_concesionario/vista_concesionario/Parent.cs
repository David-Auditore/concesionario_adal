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
    public partial class Parent : Form
    {
        public Parent()
        {
            InitializeComponent();
        }

        private void VehiculosSheet_Click(object sender, EventArgs e)
        {
            if (!FormIsOpen("FacturasV"))
            {
                FacturasV emp = FacturasV.Ventana_unica();
                emp.MdiParent = this;
                emp.WindowState = FormWindowState.Maximized;
                emp.ShowIcon = false;
                emp.Show();
                tssUsuario.Text = "Facturas";
                emp.BringToFront();
            }
        }
    }
}
