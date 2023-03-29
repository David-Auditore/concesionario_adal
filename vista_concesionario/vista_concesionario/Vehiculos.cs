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
    public partial class Vehiculos : Form
    {
        private static Vehiculos instacia = null;

        public static Vehiculos Ventana_unica()
        {
            if(instacia == null)
            {
                instacia = new Vehiculos();
            }
            return instacia;
        }
        public Vehiculos()
        {
            InitializeComponent();
        }

        private void Vehiculos_FormClosing(object sender, FormClosingEventArgs e)
        {
            instacia = null;
        }
    }
}
