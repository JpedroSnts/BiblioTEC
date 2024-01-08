namespace prjListaLivros
{
    partial class frmPrincipal
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
            this.msBuscarLivro = new System.Windows.Forms.MenuStrip();
            this.buscarLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolverLívroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msBuscarLivro.SuspendLayout();
            this.SuspendLayout();
            // 
            // msBuscarLivro
            // 
            this.msBuscarLivro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarLivroToolStripMenuItem,
            this.devolverLívroToolStripMenuItem});
            this.msBuscarLivro.Location = new System.Drawing.Point(0, 0);
            this.msBuscarLivro.Name = "msBuscarLivro";
            this.msBuscarLivro.Size = new System.Drawing.Size(1292, 24);
            this.msBuscarLivro.TabIndex = 1;
            this.msBuscarLivro.Text = "menuStrip1";
            // 
            // buscarLivroToolStripMenuItem
            // 
            this.buscarLivroToolStripMenuItem.Name = "buscarLivroToolStripMenuItem";
            this.buscarLivroToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.buscarLivroToolStripMenuItem.Text = "Reservar Lívro";
            this.buscarLivroToolStripMenuItem.Click += new System.EventHandler(this.buscarLivroToolStripMenuItem_Click);
            // 
            // devolverLívroToolStripMenuItem
            // 
            this.devolverLívroToolStripMenuItem.Name = "devolverLívroToolStripMenuItem";
            this.devolverLívroToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.devolverLívroToolStripMenuItem.Text = "Devolver Lívro";
            this.devolverLívroToolStripMenuItem.Click += new System.EventHandler(this.devolverLívroToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 801);
            this.Controls.Add(this.msBuscarLivro);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msBuscarLivro;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BiblioTEC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msBuscarLivro.ResumeLayout(false);
            this.msBuscarLivro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msBuscarLivro;
        private System.Windows.Forms.ToolStripMenuItem buscarLivroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolverLívroToolStripMenuItem;
    }
}