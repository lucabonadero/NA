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
    public partial class frmAgregarFrutasQueGustan : Form
    {
        public frmAgregarFrutasQueGustan()
        {
            InitializeComponent();
        }
        clsFrutasQueGustan clsFrutasQueGustan = new clsFrutasQueGustan();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsFrutasQueGustan.Fruta = Convert.ToInt32(cmbCodFruta.Text);
            clsFrutasQueGustan.Dni = Convert.ToInt32(cmbDNI.SelectedValue);

            clsFrutasQueGustan.Agregar();

            // Limpiar los ComboBox después de agregar la fruta
            cmbCodFruta.SelectedIndex = -1;
            cmbDNI.SelectedIndex = -1;




        }

        private void frmAgregarFrutasQueGustan_Load(object sender, EventArgs e)
        {
            clsFrutasQueGustan.CargarComboBox(cmbDNI, cmbCodFruta);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clsFrutasQueGustan.Fruta = Convert.ToInt32(cmbCodFruta.Text);
            clsFrutasQueGustan.Dni = Convert.ToInt32(cmbDNI.SelectedValue);

            clsFrutasQueGustan.Eliminar();

            // Limpiar los ComboBox después de agregar la fruta
            cmbCodFruta.SelectedIndex = -1;
            cmbDNI.SelectedIndex = -1;
            frmAgregarFrutasQueGustan_Load(sender, e);
        }
    }
}
