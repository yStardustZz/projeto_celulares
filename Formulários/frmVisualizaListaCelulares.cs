using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Celulares.Formulários
{
    public partial class frmVisualizaListaCelulares : Form
    {
        public frmVisualizaListaCelulares()
        {
            InitializeComponent();
        }

        private void frmVisualizaListaCelulares_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.Celulares'. Você pode movê-la ou removê-la conforme necessário.
            this.celularesTableAdapter.Fill(this.dataSet1.Celulares);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
