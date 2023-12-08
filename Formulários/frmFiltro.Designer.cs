
namespace Projeto_Celulares.Formulários
{
    partial class frmFiltro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet1 = new Projeto_Celulares.Dados.DataSet1();
            this.celularesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.celularesTableAdapter = new Projeto_Celulares.Dados.DataSet1TableAdapters.CelularesTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.dataSet11 = new Projeto_Celulares.Dados.DataSet1();
            this.marcasCelularesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcas_CelularesTableAdapter = new Projeto_Celulares.Dados.DataSet1TableAdapters.Marcas_CelularesTableAdapter();
            this.btn_todos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celularesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasCelularesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1_Celulares";
            reportDataSource1.Value = this.celularesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projeto_Celulares.Relatórios.frmFiltro.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 131);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 319);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // celularesBindingSource
            // 
            this.celularesBindingSource.DataMember = "Celulares";
            this.celularesBindingSource.DataSource = this.dataSet1;
            // 
            // celularesTableAdapter
            // 
            this.celularesTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.marcasCelularesBindingSource;
            this.comboBox1.DisplayMember = "Marca";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(41, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "Marca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escolha a marca:";
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Location = new System.Drawing.Point(193, 16);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(99, 44);
            this.btn_filtrar.TabIndex = 3;
            this.btn_filtrar.Text = "Filtrar";
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marcasCelularesBindingSource
            // 
            this.marcasCelularesBindingSource.DataMember = "Marcas_Celulares";
            this.marcasCelularesBindingSource.DataSource = this.dataSet11;
            // 
            // marcas_CelularesTableAdapter
            // 
            this.marcas_CelularesTableAdapter.ClearBeforeFill = true;
            // 
            // btn_todos
            // 
            this.btn_todos.Location = new System.Drawing.Point(338, 16);
            this.btn_todos.Name = "btn_todos";
            this.btn_todos.Size = new System.Drawing.Size(99, 44);
            this.btn_todos.TabIndex = 4;
            this.btn_todos.Text = "Todos";
            this.btn_todos.UseVisualStyleBackColor = true;
            this.btn_todos.Click += new System.EventHandler(this.btn_todos_Click);
            // 
            // frmFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_todos);
            this.Controls.Add(this.btn_filtrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmFiltro";
            this.Text = "frmFiltro";
            this.Load += new System.EventHandler(this.frmFiltro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celularesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasCelularesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Dados.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource celularesBindingSource;
        private Dados.DataSet1TableAdapters.CelularesTableAdapter celularesTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_filtrar;
        private Dados.DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource marcasCelularesBindingSource;
        private Dados.DataSet1TableAdapters.Marcas_CelularesTableAdapter marcas_CelularesTableAdapter;
        private System.Windows.Forms.Button btn_todos;
    }
}