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
using System.Xml.Linq;

namespace vista_concesionario
{
    public partial class Propietario : Form
    {
        private static Propietario instacia = null;
        public static Propietario Ventana_unica()
        {
            if (instacia == null)
            {
                instacia = new Propietario();
            }
            return instacia;
        }

        public Propietario()
        {
            InitializeComponent();
        }

        private void Propietarios_FormClosing(object sender, FormClosingEventArgs e)
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
                        GuardarPropietario();
                        break;
                    case "Actualizar":
                        ActualizarPropietario();
                        break;
                    case "Eliminar":
                        EliminarPropietario();
                        break;
                    case "Consultar":
                        ConsultarPropietario();
                        break;
                    case "Listar":
                        ListarPropietario();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool GuardarPropietario()
        {
            try
            {
                ClsPropietario objp = new ClsPropietario();
                objp.Id = txtID.Text;
                objp.Nombre = txtNombre.Text;
                objp.Apellido = txtApellido.Text;
                objp.Edad = Convert.ToInt32(txtEdad.Text);
                objp.Telefono = txtTelefono.Text;
                if (!objp.GuardarPropietario())
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

        private bool ActualizarPropietario()
        {
            try
            {
                ClsPropietario objp = new ClsPropietario();
                objp.Id = txtID.Text;
                objp.Nombre = txtNombre.Text;
                objp.Apellido = txtApellido.Text;
                objp.Edad = Convert.ToInt32(txtEdad.Text);
                objp.Telefono = txtTelefono.Text;
                if (!objp.ActualizarPropietario())
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

        private bool EliminarPropietario()
        {
            try
            {
                ClsPropietario objp = new ClsPropietario();
                objp.Id = txtID.Text;
                if (!objp.EliminarPropietario())
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

        private bool ConsultarPropietario()
        {
            try
            {
                ClsPropietario objP = new ClsPropietario();
                objP.Id = txtID.Text;
                if (!objP.ConsultarPropietario())
                {
                    MessageBox.Show(objP.Error);
                    objP = null;
                    return false;
                }
                SqlDataReader readerP;
                readerP = objP.Reader;
                readerP.Read();
                txtNombre.Text = readerP.GetString(1);
                txtApellido.Text = readerP.GetString(2);
                txtEdad.Text = readerP.GetInt32(3).ToString();
                txtTelefono.Text = readerP.GetString(4);
                readerP.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool ListarPropietario()
        {
            try
            {
                ClsPropietario objp = new ClsPropietario();
                if (!objp.ListarPropietario(dataGridProp))
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
            txtID.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
            txtTelefono.Text = "";
            ctrlBox.SelectedIndex = -1;
        }
    }
}
