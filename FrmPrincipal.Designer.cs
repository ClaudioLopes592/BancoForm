namespace Banco
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_abrirConta = new System.Windows.Forms.ToolStripMenuItem();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_sair = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_dataAtual = new System.Windows.Forms.Label();
            this.lbl_usuarioLogado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tsm_abrirCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.opçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1143, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_abrirConta,
            this.tsm_abrirCaixa});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // tsm_abrirConta
            // 
            this.tsm_abrirConta.Name = "tsm_abrirConta";
            this.tsm_abrirConta.Size = new System.Drawing.Size(180, 22);
            this.tsm_abrirConta.Text = "Abrir conta";
            this.tsm_abrirConta.Click += new System.EventHandler(this.tsm_abrirConta_Click);
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_sair});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // tsm_sair
            // 
            this.tsm_sair.Name = "tsm_sair";
            this.tsm_sair.Size = new System.Drawing.Size(102, 22);
            this.tsm_sair.Text = "Sair";
            this.tsm_sair.Click += new System.EventHandler(this.tsm_sair_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lbl_dataAtual);
            this.panel1.Controls.Add(this.lbl_usuarioLogado);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 454);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 72);
            this.panel1.TabIndex = 1;
            // 
            // lbl_dataAtual
            // 
            this.lbl_dataAtual.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_dataAtual.Location = new System.Drawing.Point(771, 25);
            this.lbl_dataAtual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dataAtual.Name = "lbl_dataAtual";
            this.lbl_dataAtual.Size = new System.Drawing.Size(157, 28);
            this.lbl_dataAtual.TabIndex = 3;
            this.lbl_dataAtual.Text = "00/00/0000";
            this.lbl_dataAtual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_usuarioLogado
            // 
            this.lbl_usuarioLogado.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_usuarioLogado.Location = new System.Drawing.Point(166, 25);
            this.lbl_usuarioLogado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_usuarioLogado.Name = "lbl_usuarioLogado";
            this.lbl_usuarioLogado.Size = new System.Drawing.Size(255, 28);
            this.lbl_usuarioLogado.TabIndex = 2;
            this.lbl_usuarioLogado.Text = "usuario";
            this.lbl_usuarioLogado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(680, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Atual";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário Logado";
            // 
            // tsm_abrirCaixa
            // 
            this.tsm_abrirCaixa.Name = "tsm_abrirCaixa";
            this.tsm_abrirCaixa.Size = new System.Drawing.Size(180, 22);
            this.tsm_abrirCaixa.Text = "Abrir Caixa";
            this.tsm_abrirCaixa.Click += new System.EventHandler(this.tsm_abrirCaixa_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 540);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.Text = "Banco - Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem tsm_abrirConta;
        private Panel panel1;
        private Label lbl_dataAtual;
        private Label lbl_usuarioLogado;
        private Label label2;
        private Label label1;
        private ToolStripMenuItem opçõesToolStripMenuItem;
        private ToolStripMenuItem tsm_sair;
        private ToolStripMenuItem tsm_abrirCaixa;
    }
}