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
    public partial class frmVerFrutas : Form
    {
        public frmVerFrutas()
        {
            InitializeComponent();
        }
        clsFrutas clsFrutas = new clsFrutas();
        private void btnListar_Click(object sender, EventArgs e)
        {
            clsFrutas.MostrarFrutas(dgvFrutas);
        }
    }
}
