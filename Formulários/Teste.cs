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
    public partial class Teste : Form
    {
        public Teste()
        {
            InitializeComponent();
        }

        private void celularesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.celularesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Teste_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.Celulares'. Você pode movê-la ou removê-la conforme necessário.
            this.celularesTableAdapter.Fill(this.dataSet1.Celulares);

        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            string Coluna, Procurar, Texto, Filtro;

            Coluna = comboBox1.Text;
            Procurar = comboBox2.Text;
            Texto = textBox1.Text;

            Filtro = Coluna;


            if (Procurar == "Que começa com")
            {
                Filtro += " like '" + Texto + "%'";
            }

            else if (Procurar == "Que contém")
            {
                Filtro += " like '%" + Texto + "%'";
            }

            else if (Procurar == "Que termina com")
            {
                Filtro += " like '%" + Texto + "'";
            }

            else if (Procurar == "Igual a")
            {
                Filtro += "='" + Texto + "'";
            }

            else
            {
                Filtro = "";
            }

            celularesBindingSource.Filter = Filtro;
        }
    }

    
    
}
