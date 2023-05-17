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
    public partial class frmVerAlumnos : Form
    {
        public frmVerAlumnos()
        {
            InitializeComponent();
        }
        clsAlumnos clsAlumnos = new clsAlumnos();

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsAlumnos.MostrarAlumnos(dgvAlumnos);
        }
    }
}
