using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiCandi.Vistas
{
    public partial class frmCandidatas : Form
    {
        public frmCandidatas()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarCandidata b = new frmAgregarCandidata();
            b.Show();
        }

        private void frmCandidatas_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificarCandidata a = new frmModificarCandidata();
            a.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminarCandidata c = new frmEliminarCandidata();
            c.Show();
        }
    }
}
