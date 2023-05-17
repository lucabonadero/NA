using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Net;
using System.Threading;

namespace pryLaboratorioTRES
{
    public class clsFrutas
    {
        #region Cadena de Conexion
        //Comandos OleDb para la conexión a la base de datos
        private OleDbConnection cnx = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataAdapter adapter = new OleDbDataAdapter();

        //Conectarse a la base de datos mediante la cadena de conexion y declarar la variable
        private string vCadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=COLEGIO.mdb";
        private string vTabla = "Frutas";

        //Declarar las variables que se utilizaran en la clase
        private Int32 fruta;
        private string nombre;

        #endregion

        #region Propiedades
        //Asignar valores y variables globales para usar en todo el proyecto
        public Int32 Fruta
        {
            get { return fruta; }
            set { fruta = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        #endregion

        public void Agregar()
        {
            //Agregar un alumno a la base de datos
            try
            {
                cnx.ConnectionString = vCadenaConexion;
                cmd.Connection = cnx;
                cmd.CommandText = "INSERT INTO " + vTabla + " (fruta, nombre) VALUES (@fruta, @nombre)";
                cmd.Parameters.AddWithValue("@fruta", fruta);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                MessageBox.Show("Fruta agregada correctamente", "Agregar alumno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la fruta: " + ex.Message, "Agregar alumno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void MostrarFrutas(DataGridView dgvFrutas)
        {
            //Mostrar alumnos y sus datos en el datagridview
            try
            {
                cnx.ConnectionString = vCadenaConexion;
                cmd.Connection = cnx;
                cnx.Open();
                cmd.CommandType = CommandType.TableDirect;
                cmd.CommandText = vTabla;
                adapter = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvFrutas.DataSource = dt;
                cnx.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al mostrar los alumnos: " + e.Message, "Mostrar alumnos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
