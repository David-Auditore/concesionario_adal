using Concesionario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            if (instacia == null)
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

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                switch (ctrlBox.Text)
                {
                    case "Guardar":
                        GuardarVehiculo();
                        break;
                    case "Actualizar":
                        ActualizarVehiculo();
                        break;
                    case "Eliminar":
                        EliminarVehiculo();
                        break;
                    case "Consultar":
                        ConsultarVehiculo();
                        break;
                    case "Listar":
                        ListarVehiculos();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private bool GuardarVehiculo()
        {
            try
            {
                Cls_Concesionario objp = new Cls_Concesionario();
                objp.Placa = txtPlaca.Text;
                objp.Modelo = txtColor.Text;
                objp.Color = txtModelo.Text;
                objp.Marca = txtMarca.Text;
                objp.Precio = Convert.ToInt32(txtPrecio.Text);
                if (!objp.GuardarVehiculo())
                {
                    MessageBox.Show(objp.Error);
                    objp = null;
                    return false;
                }
                MessageBox.Show(objp.Error);
                objp = null;
                resetForm();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool ActualizarVehiculo()
        {
            try
            {
                Cls_Concesionario objp = new Cls_Concesionario();
                objp.Placa = txtPlaca.Text;
                objp.Modelo = txtColor.Text;
                objp.Color = txtModelo.Text;
                objp.Marca = txtMarca.Text;
                objp.Precio = Convert.ToInt32(txtPrecio.Text);
                if (!objp.ActualizarVehiculo())
                {
                    MessageBox.Show(objp.Error);
                    objp = null;
                    return false;
                }
                MessageBox.Show(objp.Error);
                objp = null;
                resetForm();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool EliminarVehiculo()
        {
            try
            {
                Cls_Concesionario objp = new Cls_Concesionario();
                objp.Placa = txtPlaca.Text;
                if (!objp.EliminarVehiculo())
                {
                    MessageBox.Show(objp.Error);
                    objp = null;
                    return false;
                }
                MessageBox.Show(objp.Error);
                objp = null;
                resetForm();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool ConsultarVehiculo()
        {
            try
            {
                Cls_Concesionario objp = new Cls_Concesionario();
                objp.Placa = txtPlaca.Text;
                if (!objp.ConsultarVehiculo())
                {
                    MessageBox.Show(objp.Error);
                    objp = null;
                    return false;
                }
                SqlDataReader readerP;
                readerP = objp.Reader;
                readerP.Read();

                txtPlaca.Text = readerP.GetString(0);
                txtModelo.Text = readerP.GetString(1);
                txtColor.Text = readerP.GetString(2);
                txtMarca.Text = readerP.GetString(3);
                txtPrecio.Text = readerP.GetDouble(4).ToString();
                /*objp.Placa = txtPlaca.Text;
                objp.Modelo = txtColor.Text;
                objp.Color = txtModelo.Text;
                objp.Marca = txtMarca.Text;
                objp.Precio = Convert.ToInt32(txtPrecio.Text);*/

                readerP.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool ListarVehiculos()
        {
            try
            {
                Cls_Concesionario objp = new Cls_Concesionario();
                if (!objp.ListarVehiculo(dataGridVehiculos))
                {
                    MessageBox.Show(objp.Error);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void resetForm()
        {
            txtPlaca.Text = "";
            txtModelo.Text = "";
            txtColor.Text = "";
            txtMarca.Text = "";
            txtPrecio.Text = "";
            ctrlBox.SelectedIndex = -1;
        }

        private void Vehiculos_Load(object sender, EventArgs e)
        {
            ListarVehiculos();
        }
    }
}
