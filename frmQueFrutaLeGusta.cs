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
    public partial class frmQueFrutaLeGusta : Form
    {
        public frmQueFrutaLeGusta()
        {
            InitializeComponent();
        }
        clsAlumnos clsAlumnos = new clsAlumnos();
        clsFrutasQueGustan clsFrutasQueGustan = new clsFrutasQueGustan();
        private void frmQueFrutaLeGusta_Load(object sender, EventArgs e)
        {
            clsAlumnos.CargarComboBox(cmbAlumno);
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            clsFrutasQueGustan.Dni = Convert.ToInt32(cmbAlumno.SelectedValue);
            clsFrutasQueGustan.CargarListBox(lstFrutas);
        }

        private void cmbAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
