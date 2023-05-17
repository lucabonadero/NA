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
    public partial class frmAgregarFruta : Form
    {
        public frmAgregarFruta()
        {
            InitializeComponent();
        }
        clsFrutas clsFrutas = new clsFrutas();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsFrutas.Fruta = Convert.ToInt32(txtCodigo.Text);
            clsFrutas.Nombre = txtNombre.Text;


            clsFrutas.Agregar();


            txtCodigo.Text = "";
            txtNombre.Text = "";


        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDNI_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }
    }
}
