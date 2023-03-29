using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LibConexionBD;
using System.CodeDom.Compiler;
using System.Security.Cryptography.X509Certificates;
using LibLlenarGrids;
using System.Windows.Forms;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Concesionario
{
    public class Cls_Concesionario
    {
        #region ATRIBUTOS VEHICULO
        private string placa;
        private string modelo;
        private string color;
        private string marca;
        private double precio;
        private string error;
        private SqlDataReader reader;
        #endregion

        #region PROPIEDADES VEHICULO
        public string Placa { get => placa; set => placa = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Color { get => color; set => color = value; }
        public string Marca { get => marca; set => marca = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Error { get => error; set => error = value; }
        public SqlDataReader Reader { get => Reader; set => Reader = value; }
        #endregion

        #region METODOS PUBLICOS
        public Cls_Concesionario()
        {
            placa = "";
            modelo = "";
            color = "";
            marca = "";
            precio = 0;
            error = "";
        }
        public bool GuardarVehiculo()
        {
            try
            {
                ClsConexion objV = new ClsConexion();
                string query = "execute usp_guardar_vehiculo '" + placa + "','" + modelo + "','" + color + "','" + marca + "'," + precio;
                if (!objV.EjecutarSentencia(query, false))
                {
                    error = objV.Error;
                    objV = null;
                    return false;
                }
                error = "se guardo exitosamente";
                objV = null;
                return false;
            }
            catch (Exception ex)
            {
                this.error = ex.Message;
                return false;
            }
        }
        public bool ActualizarVehiculo()
        {
            try
            {
                ClsConexion objV = new ClsConexion();
                string query = "execute usp_actualizar_vehiculo '" + placa + "','" + modelo + "','" + color + "','" + marca + "'," + precio;
                if (!objV.EjecutarSentencia(query, false))
                {
                    error = objV.Error;
                    objV = null;
                    return false;
                }
                error = "se Actualizo exitosamente";
                objV = null;
                return true;
            }
            catch (Exception ex)
            {
                this.error = ex.Message;
                return false;
            }

        }
        public bool EliminarVehiculo()
        {
            try
            {
                ClsConexion objV = new ClsConexion();
                string query = "execute usp_delete_vehiculo '" + placa;
                if (!objV.EjecutarSentencia(query, false))
                {
                    error = objV.Error;
                    objV = null;
                    return false;
                }
                error = "se elimino correctamente";
                objV = null;
                return true;
            }
            catch (Exception ex)
            {
                this.error = ex.Message;
                return false;
            }
        }
        public bool ConsultarVehiculo()
        {
            string sentencia = "execute usp_consultar_Producto " + placa;
            ClsConexion objV = new ClsConexion();
            if (objV.Consultar(sentencia, false))
            {
                reader = objV.Reader;
                objV = null;
                return true;
            }
            else
            {
                error = objV.Error;
                objV = null;
                return false;
            }
        }
        public bool ListarVehiculo(DataGridView GRWdatos)
        {
            ClsLLenarGrids objG = new ClsLLenarGrids();
            objG.NombreTabla = "vehiculo";
            objG.SQL = "execute usp_listar_vehiculo";
            if (!objG.LlenarGrid(GRWdatos))
            {
                error = objG.ERROR;
                objG = null;
                return false;
            }
            objG = null;
            return true;
        }

        #endregion
    }
    public class ClsPropietario
    {
        #region ATRIBUTO PROPIETARIO
        private string id;
        private string nombre;
        private string apellido;
        private int edad;
        private string telefono;
        private SqlDataReader reader;
        private string error;
        #endregion

        #region PROPIEDADES PROPIETARIO

        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public SqlDataReader Reader { get => reader; set => reader = value; }
        public string Error { get => error; set => error = value; }
        #endregion

        #region METODOS PUBLICOS PROPIETARIO
        public ClsPropietario()
        {
            id = "";
            nombre = "";
            apellido = "";
            edad = 0;
            telefono = "";
            error = "";
        }
        public bool GuardarPropietario()
        {
            try
            {
                ClsConexion objP = new ClsConexion();
                string query = "execute usp_guardar_propietario '" + id + "','" + nombre + "','" + apellido + "'," + edad + ",'" + telefono;
                if (!objP.EjecutarSentencia(query, false))
                {
                    error = objP.Error;
                    objP = null;
                    return false;
                }
                error = "se guardo exitosamente";
                objP = null;
                return true;
            }
            catch (Exception ex)
            {
                this.error = ex.Message;
                return false;

            }
        }
        public bool ActualizarPropietario()
        {
            try
            {
                ClsConexion objP = new ClsConexion();
                string query = "execute usp_actualizar_propietario '" + id + "','" + nombre + "','" + apellido + "'," + edad + "','" + telefono;
                if (!objP.EjecutarSentencia(query, false))
                {
                    error = objP.Error;
                    objP = null;
                    return false;
                }
                error = "se Actualizo exitosamente";
                objP = null;
                return true;
            }
            catch (Exception ex)
            {
                this.error = ex.Message;
                return false;
            }

        }
        public bool EliminarPropietario()
        {
            try
            {
                ClsConexion objP = new ClsConexion();
                string query = "execute usp_delete_propietario " + id;
                if (!objP.EjecutarSentencia(query, false))
                {
                    error = objP.Error;
                    return false;
                    objP = null;
                }
                error = "se Elimino correctamente";
                objP = null;
                return true;
            }
            catch (Exception ex)
            {
                this.error = ex.Message;
                return false;
            }

        }
        public bool ConsultarPropietario()
        {
            string sentencia = "execute usp_consultar_Producto " + id;
            ClsConexion objP = new ClsConexion();
            if (objP.Consultar(sentencia, false))
            {
                reader = objP.Reader;
                objP = null;
                return true;
            }
            else
            {
                error = objP.Error;
                objP = null;
                return false;
            }
        }
        public bool ListarPropietario(DataGridView GRWdatos)
        {
            ClsLLenarGrids objG = new ClsLLenarGrids();
            objG.NombreTabla = "propietario";
            objG.SQL = "execute usp_listar_propietario";
            if (!objG.LlenarGrid(GRWdatos))
            {
                error = objG.ERROR;
                objG = null;
                return false;
            }
            objG = null;
            return true;
        }

        #endregion
    }
}
