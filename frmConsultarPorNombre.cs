using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLaboratorioTRES
{
    public partial class frmConsultarPorNombre : Form
    {
        public frmConsultarPorNombre()
        {
            InitializeComponent();
        }
        clsAlumnos clsAlumnos = new clsAlumnos();
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Llamar al metodo buscar alumno por dni
            clsAlumnos.BuscarPorNombre(txtNombre.Text);
            txtDNIRO.Text = Convert.ToString(clsAlumnos.Dni);
            txtSexoRO.Text = clsAlumnos.Sexo;
            txtBarrioRO.Text = Convert.ToString(clsAlumnos.Barrio);
        }
    }
}
