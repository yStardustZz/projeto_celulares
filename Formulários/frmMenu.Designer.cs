
namespace Projeto_Celulares
{
    partial class frmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.celularesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.celularesfiltroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioCelularesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioComFiltroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.celularesToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastro";
            // 
            // celularesToolStripMenuItem
            // 
            this.celularesToolStripMenuItem.Name = "celularesToolStripMenuItem";
            this.celularesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.celularesToolStripMenuItem.Text = "Celulares";
            this.celularesToolStripMenuItem.Click += new System.EventHandler(this.CelularesToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "&Sair";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.celularesfiltroToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // celularesfiltroToolStripMenuItem
            // 
            this.celularesfiltroToolStripMenuItem.Name = "celularesfiltroToolStripMenuItem";
            this.celularesfiltroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.celularesfiltroToolStripMenuItem.Text = "Celulares";
            this.celularesfiltroToolStripMenuItem.Click += new System.EventHandler(this.celularesfiltroToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatórioCelularesToolStripMenuItem,
            this.relatórioComFiltroToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // relatórioCelularesToolStripMenuItem
            // 
            this.relatórioCelularesToolStripMenuItem.Name = "relatórioCelularesToolStripMenuItem";
            this.relatórioCelularesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.relatórioCelularesToolStripMenuItem.Text = "Relatório Simples";
            this.relatórioCelularesToolStripMenuItem.Click += new System.EventHandler(this.relatórioCelularesToolStripMenuItem_Click);
            // 
            // relatórioComFiltroToolStripMenuItem
            // 
            this.relatórioComFiltroToolStripMenuItem.Name = "relatórioComFiltroToolStripMenuItem";
            this.relatórioComFiltroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.relatórioComFiltroToolStripMenuItem.Text = "Relatório com Filtro";
            this.relatórioComFiltroToolStripMenuItem.Click += new System.EventHandler(this.relatórioComFiltroToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem celularesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem celularesfiltroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioCelularesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioComFiltroToolStripMenuItem;
    }
}

