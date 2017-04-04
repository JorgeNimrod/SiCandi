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
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRePorConvocatoria b = new frmRePorConvocatoria();
            b.Show();
        }

        private void btnRePorMunicipio_Click(object sender, EventArgs e)
        {
            frmRePorMunicipio a = new frmRePorMunicipio();
            a.Show();
        }

        private void btnRePuntuacionMunicipio_Click(object sender, EventArgs e)
        {
            frmRePuntuacionMunicipio c = new frmRePuntuacionMunicipio();
            c.Show();
        }

        private void btnReGanadorasMunicipio_Click(object sender, EventArgs e)
        {
            frmReGanadorasMunicipio d = new frmReGanadorasMunicipio();
            d.Show();
        }

        private void btnCanPorCapturista_Click(object sender, EventArgs e)
        {
            frmCanPorCapturista f = new frmCanPorCapturista();
            f.Show();
        }
    }
}
