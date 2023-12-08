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
    public partial class frmCadCelulares : Form
    {
        public frmCadCelulares()
        {
            InitializeComponent();
        }

        private void celularesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.celularesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void CadCelulares_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.Celulares'. Você pode movê-la ou removê-la conforme necessário.
            this.celularesTableAdapter.Fill(this.dataSet1.Celulares);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que quer excluir?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                celularesBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
        }
    }
}
