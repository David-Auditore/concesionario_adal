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
            if (!FormIsOpen("Vehiculos"))
            {
                Vehiculos emp = Vehiculos.Ventana_unica();
                emp.MdiParent = this;
                emp.WindowState = FormWindowState.Maximized;
                emp.ShowIcon = false;
                emp.Show();
                emp.BringToFront();
            }
        }
        bool FormIsOpen(string nameForm)
        {
            //Recorre cada children y si está abierto lo trae al frente
            foreach (var item in this.MdiChildren)
            {
                if (item.Text == nameForm)
                {
                    item.BringToFront();
                    return true;
                }
            }
            return false;
        }

        private void propietariosSheet_Click(object sender, EventArgs e)
        {
            if (!FormIsOpen("Propietario"))
            {
                Propietario emp = Propietario.Ventana_unica();
                emp.MdiParent = this;
                emp.WindowState = FormWindowState.Maximized;
                emp.ShowIcon = false;
                emp.Show();
                emp.BringToFront();
            }
        }

        private void Parent_Load(object sender, EventArgs e)
        {
            this.propietariosSheet_Click(sender, e);
        }

        private void Parent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
