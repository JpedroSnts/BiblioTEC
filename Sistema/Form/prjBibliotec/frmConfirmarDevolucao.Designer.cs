namespace prjListaLivros
{
    partial class frmConfirmarDevolucao
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
            this.label1 = new System.Windows.Forms.Label();
            this.rdbSim = new System.Windows.Forms.RadioButton();
            this.rdbNao = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTipoOcorrencia = new System.Windows.Forms.ComboBox();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.grbControles = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.cmbTipoOcorrenciaCd = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.grbControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deseja registrar uma ocorrência: ";
            // 
            // rdbSim
            // 
            this.rdbSim.AutoSize = true;
            this.rdbSim.Location = new System.Drawing.Point(9, 36);
            this.rdbSim.Name = "rdbSim";
            this.rdbSim.Size = new System.Drawing.Size(42, 17);
            this.rdbSim.TabIndex = 4;
            this.rdbSim.Text = "Sim";
            this.rdbSim.UseVisualStyleBackColor = true;
            this.rdbSim.CheckedChanged += new System.EventHandler(this.rdbSim_CheckedChanged);
            // 
            // rdbNao
            // 
            this.rdbNao.AutoSize = true;
            this.rdbNao.Checked = true;
            this.rdbNao.Location = new System.Drawing.Point(57, 36);
            this.rdbNao.Name = "rdbNao";
            this.rdbNao.Size = new System.Drawing.Size(45, 17);
            this.rdbNao.TabIndex = 5;
            this.rdbNao.TabStop = true;
            this.rdbNao.Text = "Não";
            this.rdbNao.UseVisualStyleBackColor = true;
            this.rdbNao.CheckedChanged += new System.EventHandler(this.rdbNao_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 259);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdbSim);
            this.groupBox1.Controls.Add(this.rdbNao);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 64);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // cmbTipoOcorrencia
            // 
            this.cmbTipoOcorrencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoOcorrencia.FormattingEnabled = true;
            this.cmbTipoOcorrencia.ItemHeight = 13;
            this.cmbTipoOcorrencia.Location = new System.Drawing.Point(6, 28);
            this.cmbTipoOcorrencia.Name = "cmbTipoOcorrencia";
            this.cmbTipoOcorrencia.Size = new System.Drawing.Size(192, 21);
            this.cmbTipoOcorrencia.TabIndex = 5;
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(122, 259);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(94, 23);
            this.btnDevolver.TabIndex = 0;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // grbControles
            // 
            this.grbControles.Controls.Add(this.txtDescricao);
            this.grbControles.Controls.Add(this.label3);
            this.grbControles.Controls.Add(this.label2);
            this.grbControles.Controls.Add(this.cmbTipoOcorrencia);
            this.grbControles.Enabled = false;
            this.grbControles.Location = new System.Drawing.Point(12, 75);
            this.grbControles.Name = "grbControles";
            this.grbControles.Size = new System.Drawing.Size(204, 178);
            this.grbControles.TabIndex = 7;
            this.grbControles.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipo da ocorrência";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descrição da ocorrência";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(6, 78);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(192, 93);
            this.txtDescricao.TabIndex = 3;
            // 
            // cmbTipoOcorrenciaCd
            // 
            this.cmbTipoOcorrenciaCd.FormattingEnabled = true;
            this.cmbTipoOcorrenciaCd.Location = new System.Drawing.Point(237, 20);
            this.cmbTipoOcorrenciaCd.Name = "cmbTipoOcorrenciaCd";
            this.cmbTipoOcorrenciaCd.Size = new System.Drawing.Size(192, 21);
            this.cmbTipoOcorrenciaCd.TabIndex = 9;
            this.cmbTipoOcorrenciaCd.Visible = false;
            // 
            // frmConfirmarDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 292);
            this.Controls.Add(this.cmbTipoOcorrenciaCd);
            this.Controls.Add(this.grbControles);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfirmarDevolucao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolver Lívro";
            this.Load += new System.EventHandler(this.frmConfirmarDevolucao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbControles.ResumeLayout(false);
            this.grbControles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbSim;
        private System.Windows.Forms.RadioButton rdbNao;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTipoOcorrencia;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.GroupBox grbControles;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipoOcorrenciaCd;
    }
}