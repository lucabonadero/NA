using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;


namespace pryLaboratorioTRES
{
    public class clsAlumnos
    {
        #region Cadena de Conexion
        //Comandos OleDb para la conexión a la base de datos
        private OleDbConnection cnx = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataAdapter adapter = new OleDbDataAdapter();


        //Conectarse a la base de datos mediante la cadena de conexion y declarar la variable
        private string vCadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=COLEGIO.mdb";
        private string vTabla = "Alumnos";
        //Declarar las variables que se utilizaran en la clase
        private Int32 dni;
        private string nombre;
        private string sexo;
        private Int32 barrio;
        #endregion

        #region Propiedades
        //Asignar valores y variables globales para usar en todo el proyecto
        public Int32 Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public Int32 Barrio
        {
            get { return barrio; }
            set { barrio = value; }
        }
        #endregion




        public void Agregar()
        {
            //Agregar un alumno a la base de datos
            try
            {
                cnx.ConnectionString = vCadenaConexion;
                cmd.Connection = cnx;
                cmd.CommandText = "INSERT INTO " + vTabla + " (dni, nombre, sexo, barrio) VALUES (@dni, @nombre, @sexo, @barrio)";
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@barrio", barrio);
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                MessageBox.Show("Alumno agregado correctamente", "Agregar alumno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)    
            {
                MessageBox.Show("Error al agregar el alumno: " + ex.Message, "Agregar alumno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        public void BuscarPorDNI(Int32 dni)
        {
            try
            {
                cnx.ConnectionString = vCadenaConexion;
                cmd.Connection = cnx;
                cnx.Open();
                cmd.CommandType = CommandType.TableDirect;
                cmd.CommandText = vTabla;
                adapter = new OleDbDataAdapter(cmd);

                OleDbDataReader DR = cmd.ExecuteReader();

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetInt32(0) == dni)
                        {

                            nombre = DR.GetString(1);
                            sexo = DR.GetString(2);
                            barrio = DR.GetInt32(4);


                        }

                    }
                }
                cnx.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show("Error al buscar el alumno: " + e.Message, "Buscar alumno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void BuscarPorNombre(string nom)
        {
            try
            {
                cnx.ConnectionString = vCadenaConexion;
                cmd.Connection = cnx;
                cnx.Open();
                cmd.CommandType = CommandType.TableDirect;
                cmd.CommandText = vTabla;
                adapter = new OleDbDataAdapter(cmd);

                OleDbDataReader DR = cmd.ExecuteReader();

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetString(1) == nom)
                        {

                            dni = DR.GetInt32(0);
                            sexo = DR.GetString(2);
                            barrio = DR.GetInt32(4);


                        }

                    }
                }
                cnx.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show("Error al buscar el alumno: " + e.Message, "Buscar alumno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void MostrarAlumnos(DataGridView dgvAlumnos)
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
                dgvAlumnos.DataSource = dt;
                cnx.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al mostrar los alumnos: " + e.Message, "Mostrar alumnos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void CargarComboBox(ComboBox cmbAlumnos)
        {
            //Cargar los alumnos en el combobox
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
                cmbAlumnos.DataSource = dt;
                cmbAlumnos.DisplayMember = "nombre";
                cmbAlumnos.ValueMember = "dni";
                cnx.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al cargar los alumnos: " + e.Message, "Cargar alumnos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

    }




}

