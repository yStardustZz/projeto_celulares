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
    public partial class frmFiltro : Form
    {
        public frmFiltro()
        {
            InitializeComponent();
        }

        private void frmFiltro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet11.Marcas_Celulares'. Você pode movê-la ou removê-la conforme necessário.
            this.marcas_CelularesTableAdapter.Fill(this.dataSet11.Marcas_Celulares);
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.Celulares'. Você pode movê-la ou removê-la conforme necessário.
            this.celularesTableAdapter.Fill(this.dataSet1.Celulares);

            this.reportViewer1.RefreshReport();
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Marca", comboBox1.Text));
            this.reportViewer1.RefreshReport();
        }

        private void btn_todos_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Marca", (string)null));
            this.reportViewer1.RefreshReport();
        }
    }
}
