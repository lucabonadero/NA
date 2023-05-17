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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarAlumno frmAgregarAlumno = new frmAgregarAlumno();
            frmAgregarAlumno.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultar frmConsultar = new frmConsultar();
            frmConsultar.ShowDialog();
        }

        private void consultarPorNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarPorNombre frmConsultarPorNombre = new frmConsultarPorNombre();
            frmConsultarPorNombre.ShowDialog();
        }

        private void verListaDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerAlumnos frmVerAlumnos = new frmVerAlumnos();
            frmVerAlumnos.ShowDialog();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAgregarFruta frmAgregarFruta = new frmAgregarFruta();
            frmAgregarFruta.ShowDialog();
        }

        private void verListaDeFrutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerFrutas frmVerFrutas = new frmVerFrutas();
            frmVerFrutas.ShowDialog();
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAgregarFrutasQueGustan frmAgregarFrutasQueGustan = new frmAgregarFrutasQueGustan();
            frmAgregarFrutasQueGustan.ShowDialog();
        }

        private void queFrutaLeGustaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQueFrutaLeGusta frmQueFrutaLeGusta = new frmQueFrutaLeGusta();
            frmQueFrutaLeGusta.ShowDialog();
        }
    }
}
