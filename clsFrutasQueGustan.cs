using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace pryLaboratorioTRES
{
    public class clsFrutasQueGustan
    {
        #region Cadena de Conexion
        //Comandos OleDb para la conexión a la base de datos
        private OleDbConnection cnx = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataAdapter adapter = new OleDbDataAdapter();

        //Conectarse a la base de datos mediante la cadena de conexion y declarar la variable
        private string vCadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=COLEGIO.mdb";
        private string vTabla = "LeGustan";

        //Declarar las variables que se utilizaran en la clase
        private Int32 dni;
        private Int32 fruta;

        #endregion

        #region Propiedades
        //Asignar valores y variables globales para usar en todo el proyecto
        public Int32 Fruta
        {
            get { return fruta; }
            set { fruta = value; }
        }
        public Int32 Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        #endregion

        public void Agregar()
        {
            //Agregar una fruta que le gusta a la base de datos
            try
            {
                if (FrutaYaExiste() && ExisteDniEnAlumnos(dni))
                {
                    MessageBox.Show("La fruta ya está agregada para este DNI", "Agregar fruta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                cnx.ConnectionString = vCadenaConexion;
                cmd.Connection = cnx;
                cmd.CommandText = "INSERT INTO " + vTabla + " (dni, fruta) VALUES (@dni, @fruta)";
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@fruta", fruta);
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                MessageBox.Show("Fruta agregada correctamente", "Agregar alumno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la fruta: " + ex.Message, "Agregar fruta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public void Eliminar()
        {
            //Eliminar una fruta que le gusta a la base de datos
            try
            {
                if (!FrutaYaExiste() && ExisteDniEnAlumnos(dni))
                {
                    MessageBox.Show("La fruta no está agregada para este DNI", "Eliminar fruta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                cnx.ConnectionString = vCadenaConexion;
                cmd.Connection = cnx;
                cmd.CommandText = "DELETE FROM " + vTabla + " WHERE dni = @dni AND fruta = @fruta";
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@fruta", fruta);
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                MessageBox.Show("Fruta eliminada correctamente", "Eliminar fruta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la fruta: " + ex.Message, "Eliminar fruta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CargarComboBox(ComboBox cmbDni, ComboBox cmbCodFruta)
        {

            try
            {
                cnx.ConnectionString = vCadenaConexion;
                cmd.Connection = cnx;
                cnx.Open();

                // Cargar combobox con los dni de la tabla 'Alumnos'
                cmd.CommandText = "SELECT dni FROM Alumnos";
                adapter.SelectCommand = cmd;
                DataTable dtDni = new DataTable();
                adapter.Fill(dtDni);
                cmbDni.DataSource = dtDni;
                cmbDni.DisplayMember = "dni";
                cmbDni.ValueMember = "dni";

                // Cargar combobox con los códigos de fruta de la tabla 'Frutas'
                cmd.CommandText = "SELECT fruta FROM Frutas";
                adapter.SelectCommand = cmd;
                DataTable dtCodFruta = new DataTable();
                adapter.Fill(dtCodFruta);
                cmbCodFruta.DataSource = dtCodFruta;
                cmbCodFruta.DisplayMember = "fruta";
                cmbCodFruta.ValueMember = "fruta";

                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el combobox: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }










            ////Cargar combobox con el dni de los alumnos
            //try
            //{

            //    cnx.ConnectionString = vCadenaConexion;
            //    cmd.Connection = cnx;
            //    cmd.CommandText = "SELECT * FROM " + vTabla;
            //    adapter.SelectCommand = cmd;
            //    DataTable dt = new DataTable();
            //    adapter.Fill(dt);
            //    cmbDni.DataSource = dt;
            //    cmbDni.DisplayMember = "dni";
            //    cmbDni.ValueMember = "dni";
            //    cmbCodFruta.DataSource = dt;
            //    cmbCodFruta.DisplayMember = "fruta";
            //    cmbCodFruta.ValueMember = "fruta";
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error al cargar el combobox: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }


        public void CargarListBox(ListBox lstFrutas)
        {
            //Cargar listbox con el codigo de la fruta que le gusta al alumno seleccionado en la combobox
            try
            {
                cnx.ConnectionString = vCadenaConexion;
                cmd.Connection = cnx;
                cmd.CommandText = "SELECT LeGustan.fruta FROM Alumnos INNER JOIN LeGustan ON Alumnos.dni = LeGustan.dni WHERE Alumnos.dni = @dni";
                cmd.Parameters.AddWithValue("@dni", dni);
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                lstFrutas.DataSource = dt;
                lstFrutas.DisplayMember = "fruta";
                lstFrutas.ValueMember = "fruta";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el listbox: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool FrutaYaExiste()
        {
            try
            {
                cnx.ConnectionString = vCadenaConexion;
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT COUNT(*) FROM " + vTabla + " WHERE dni = @dni AND fruta = @fruta";
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@fruta", fruta);

                cnx.Open();
                int count = (int)cmd.ExecuteScalar();
                cnx.Close();

                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar la existencia de la fruta: " + ex.Message, "Agregar fruta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool ExisteDniEnAlumnos(Int32 dni)
        {
            try
            {
                using (OleDbConnection cnx = new OleDbConnection(vCadenaConexion))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        cmd.Connection = cnx;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT COUNT(*) FROM Alumnos WHERE dni = @dni";
                        cmd.Parameters.AddWithValue("@dni", dni);

                        cnx.Open();
                        int count = (int)cmd.ExecuteScalar();

                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar la existencia del DNI en la tabla Alumnos: " + ex.Message, "Agregar fruta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
