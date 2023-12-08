using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Celulares.Formulários;

namespace Projeto_Celulares
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void CelularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadCelulares objCadCelulares = new frmCadCelulares();
            objCadCelulares.MdiParent = this;
            objCadCelulares.Show();
        }

        private void celularesfiltroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teste objTeste = new Teste();
            objTeste.MdiParent = this;
            objTeste.Show();
        }

        private void relatórioCelularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualizaListaCelulares objVisualiza = new frmVisualizaListaCelulares();
            objVisualiza.MdiParent = this;
            objVisualiza.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void relatórioComFiltroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltro objFiltro = new frmFiltro();
            objFiltro.MdiParent = this;
            objFiltro.Show();

        }
    }
}
