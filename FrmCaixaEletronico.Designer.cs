namespace Banco
{
    partial class FrmCaixaEletronico
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_numeroContaAReceber = new System.Windows.Forms.MaskedTextBox();
            this.txt_numeroConta = new System.Windows.Forms.MaskedTextBox();
            this.txt_titularConta2 = new System.Windows.Forms.TextBox();
            this.txt_dataConta2 = new System.Windows.Forms.TextBox();
            this.txt_idConta2 = new System.Windows.Forms.TextBox();
            this.lbl_saldoT = new System.Windows.Forms.Label();
            this.lbl_contaAReceber = new System.Windows.Forms.Label();
            this.txt_valorTransferencia = new System.Windows.Forms.TextBox();
            this.lbl_valorTransferencia = new System.Windows.Forms.Label();
            this.btn_encerrar = new System.Windows.Forms.Button();
            this.btn_transferencia = new System.Windows.Forms.Button();
            this.txt_valorSaque = new System.Windows.Forms.TextBox();
            this.lbl_valorSaque = new System.Windows.Forms.Label();
            this.btn_saque = new System.Windows.Forms.Button();
            this.txt_dataConta1 = new System.Windows.Forms.TextBox();
            this.txt_idConta1 = new System.Windows.Forms.TextBox();
            this.txt_valorDeposito = new System.Windows.Forms.TextBox();
            this.lbl_valorDeposito = new System.Windows.Forms.Label();
            this.btn_deposito = new System.Windows.Forms.Button();
            this.lbl_saldoAtual = new System.Windows.Forms.Label();
            this.lbl_valorSaldo = new System.Windows.Forms.Label();
            this.btn_saldo = new System.Windows.Forms.Button();
            this.lbl_selecaoOpcao = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_contaNumero = new System.Windows.Forms.Label();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_titular = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_numeroContaAReceber);
            this.groupBox1.Controls.Add(this.txt_numeroConta);
            this.groupBox1.Controls.Add(this.txt_titularConta2);
            this.groupBox1.Controls.Add(this.txt_dataConta2);
            this.groupBox1.Controls.Add(this.txt_idConta2);
            this.groupBox1.Controls.Add(this.lbl_saldoT);
            this.groupBox1.Controls.Add(this.lbl_contaAReceber);
            this.groupBox1.Controls.Add(this.txt_valorTransferencia);
            this.groupBox1.Controls.Add(this.lbl_valorTransferencia);
            this.groupBox1.Controls.Add(this.btn_encerrar);
            this.groupBox1.Controls.Add(this.btn_transferencia);
            this.groupBox1.Controls.Add(this.txt_valorSaque);
            this.groupBox1.Controls.Add(this.lbl_valorSaque);
            this.groupBox1.Controls.Add(this.btn_saque);
            this.groupBox1.Controls.Add(this.txt_dataConta1);
            this.groupBox1.Controls.Add(this.txt_idConta1);
            this.groupBox1.Controls.Add(this.txt_valorDeposito);
            this.groupBox1.Controls.Add(this.lbl_valorDeposito);
            this.groupBox1.Controls.Add(this.btn_deposito);
            this.groupBox1.Controls.Add(this.lbl_saldoAtual);
            this.groupBox1.Controls.Add(this.lbl_valorSaldo);
            this.groupBox1.Controls.Add(this.btn_saldo);
            this.groupBox1.Controls.Add(this.lbl_selecaoOpcao);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbl_contaNumero);
            this.groupBox1.Controls.Add(this.btn_entrar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_titular);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(869, 513);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caixa Eletrônico";
            // 
            // txt_numeroContaAReceber
            // 
            this.txt_numeroContaAReceber.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_numeroContaAReceber.Location = new System.Drawing.Point(671, 262);
            this.txt_numeroContaAReceber.Mask = "000000";
            this.txt_numeroContaAReceber.Name = "txt_numeroContaAReceber";
            this.txt_numeroContaAReceber.Size = new System.Drawing.Size(134, 26);
            this.txt_numeroContaAReceber.TabIndex = 31;
            this.txt_numeroContaAReceber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_numeroContaAReceber.ValidatingType = typeof(int);
            this.txt_numeroContaAReceber.Visible = false;
            // 
            // txt_numeroConta
            // 
            this.txt_numeroConta.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_numeroConta.Location = new System.Drawing.Point(201, 36);
            this.txt_numeroConta.Mask = "000000";
            this.txt_numeroConta.Name = "txt_numeroConta";
            this.txt_numeroConta.Size = new System.Drawing.Size(178, 26);
            this.txt_numeroConta.TabIndex = 0;
            this.txt_numeroConta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_numeroConta.ValidatingType = typeof(int);
            // 
            // txt_titularConta2
            // 
            this.txt_titularConta2.Location = new System.Drawing.Point(705, 80);
            this.txt_titularConta2.Name = "txt_titularConta2";
            this.txt_titularConta2.Size = new System.Drawing.Size(100, 23);
            this.txt_titularConta2.TabIndex = 30;
            this.txt_titularConta2.Visible = false;
            // 
            // txt_dataConta2
            // 
            this.txt_dataConta2.Location = new System.Drawing.Point(705, 51);
            this.txt_dataConta2.Name = "txt_dataConta2";
            this.txt_dataConta2.Size = new System.Drawing.Size(100, 23);
            this.txt_dataConta2.TabIndex = 29;
            this.txt_dataConta2.Visible = false;
            // 
            // txt_idConta2
            // 
            this.txt_idConta2.Location = new System.Drawing.Point(811, 51);
            this.txt_idConta2.Name = "txt_idConta2";
            this.txt_idConta2.Size = new System.Drawing.Size(52, 23);
            this.txt_idConta2.TabIndex = 28;
            this.txt_idConta2.Visible = false;
            // 
            // lbl_saldoT
            // 
            this.lbl_saldoT.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_saldoT.Location = new System.Drawing.Point(618, 302);
            this.lbl_saldoT.Name = "lbl_saldoT";
            this.lbl_saldoT.Size = new System.Drawing.Size(153, 31);
            this.lbl_saldoT.TabIndex = 27;
            this.lbl_saldoT.Text = "saldo";
            this.lbl_saldoT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_saldoT.Visible = false;
            // 
            // lbl_contaAReceber
            // 
            this.lbl_contaAReceber.AutoSize = true;
            this.lbl_contaAReceber.Location = new System.Drawing.Point(453, 267);
            this.lbl_contaAReceber.Name = "lbl_contaAReceber";
            this.lbl_contaAReceber.Size = new System.Drawing.Size(212, 16);
            this.lbl_contaAReceber.TabIndex = 25;
            this.lbl_contaAReceber.Text = "Informe N. º conta a receber";
            this.lbl_contaAReceber.Visible = false;
            // 
            // txt_valorTransferencia
            // 
            this.txt_valorTransferencia.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_valorTransferencia.Location = new System.Drawing.Point(297, 262);
            this.txt_valorTransferencia.Name = "txt_valorTransferencia";
            this.txt_valorTransferencia.Size = new System.Drawing.Size(136, 26);
            this.txt_valorTransferencia.TabIndex = 24;
            this.txt_valorTransferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_valorTransferencia.Visible = false;
            this.txt_valorTransferencia.TextChanged += new System.EventHandler(this.txt_valorTransferencia_TextChanged);
            this.txt_valorTransferencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valorTransferencia_KeyPress);
            // 
            // lbl_valorTransferencia
            // 
            this.lbl_valorTransferencia.AutoSize = true;
            this.lbl_valorTransferencia.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_valorTransferencia.Location = new System.Drawing.Point(93, 267);
            this.lbl_valorTransferencia.Name = "lbl_valorTransferencia";
            this.lbl_valorTransferencia.Size = new System.Drawing.Size(199, 16);
            this.lbl_valorTransferencia.TabIndex = 23;
            this.lbl_valorTransferencia.Text = "VALOR TRANSFERÊNCIA R$";
            this.lbl_valorTransferencia.Visible = false;
            // 
            // btn_encerrar
            // 
            this.btn_encerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_encerrar.Location = new System.Drawing.Point(655, 436);
            this.btn_encerrar.Name = "btn_encerrar";
            this.btn_encerrar.Size = new System.Drawing.Size(150, 60);
            this.btn_encerrar.TabIndex = 22;
            this.btn_encerrar.Text = "ENCERRAR";
            this.btn_encerrar.UseVisualStyleBackColor = true;
            this.btn_encerrar.Click += new System.EventHandler(this.btn_encerrar_Click);
            // 
            // btn_transferencia
            // 
            this.btn_transferencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_transferencia.Enabled = false;
            this.btn_transferencia.Location = new System.Drawing.Point(655, 348);
            this.btn_transferencia.Name = "btn_transferencia";
            this.btn_transferencia.Size = new System.Drawing.Size(150, 60);
            this.btn_transferencia.TabIndex = 21;
            this.btn_transferencia.Text = "TRANSFERÊNCIA";
            this.btn_transferencia.UseVisualStyleBackColor = true;
            this.btn_transferencia.Click += new System.EventHandler(this.btn_transferencia_Click);
            // 
            // txt_valorSaque
            // 
            this.txt_valorSaque.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_valorSaque.Location = new System.Drawing.Point(431, 226);
            this.txt_valorSaque.Name = "txt_valorSaque";
            this.txt_valorSaque.Size = new System.Drawing.Size(136, 26);
            this.txt_valorSaque.TabIndex = 20;
            this.txt_valorSaque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_valorSaque.Visible = false;
            this.txt_valorSaque.TextChanged += new System.EventHandler(this.txt_valorSaque_TextChanged);
            this.txt_valorSaque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valorSaque_KeyPress);
            // 
            // lbl_valorSaque
            // 
            this.lbl_valorSaque.AutoSize = true;
            this.lbl_valorSaque.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_valorSaque.Location = new System.Drawing.Point(271, 229);
            this.lbl_valorSaque.Name = "lbl_valorSaque";
            this.lbl_valorSaque.Size = new System.Drawing.Size(130, 16);
            this.lbl_valorSaque.TabIndex = 19;
            this.lbl_valorSaque.Text = "VALOR SAQUE R$";
            this.lbl_valorSaque.Visible = false;
            // 
            // btn_saque
            // 
            this.btn_saque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_saque.Enabled = false;
            this.btn_saque.Location = new System.Drawing.Point(470, 348);
            this.btn_saque.Name = "btn_saque";
            this.btn_saque.Size = new System.Drawing.Size(150, 60);
            this.btn_saque.TabIndex = 18;
            this.btn_saque.Text = "SAQUE";
            this.btn_saque.UseVisualStyleBackColor = true;
            this.btn_saque.Click += new System.EventHandler(this.btn_saque_Click);
            // 
            // txt_dataConta1
            // 
            this.txt_dataConta1.Location = new System.Drawing.Point(705, 22);
            this.txt_dataConta1.Name = "txt_dataConta1";
            this.txt_dataConta1.Size = new System.Drawing.Size(100, 23);
            this.txt_dataConta1.TabIndex = 17;
            this.txt_dataConta1.Visible = false;
            // 
            // txt_idConta1
            // 
            this.txt_idConta1.Location = new System.Drawing.Point(811, 22);
            this.txt_idConta1.Name = "txt_idConta1";
            this.txt_idConta1.Size = new System.Drawing.Size(52, 23);
            this.txt_idConta1.TabIndex = 16;
            this.txt_idConta1.Visible = false;
            // 
            // txt_valorDeposito
            // 
            this.txt_valorDeposito.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_valorDeposito.Location = new System.Drawing.Point(431, 193);
            this.txt_valorDeposito.Name = "txt_valorDeposito";
            this.txt_valorDeposito.Size = new System.Drawing.Size(136, 26);
            this.txt_valorDeposito.TabIndex = 15;
            this.txt_valorDeposito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_valorDeposito.Visible = false;
            this.txt_valorDeposito.TextChanged += new System.EventHandler(this.txt_valorDeposito_TextChanged);
            this.txt_valorDeposito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valorDeposito_KeyPress);
            // 
            // lbl_valorDeposito
            // 
            this.lbl_valorDeposito.AutoSize = true;
            this.lbl_valorDeposito.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_valorDeposito.Location = new System.Drawing.Point(271, 196);
            this.lbl_valorDeposito.Name = "lbl_valorDeposito";
            this.lbl_valorDeposito.Size = new System.Drawing.Size(154, 16);
            this.lbl_valorDeposito.TabIndex = 14;
            this.lbl_valorDeposito.Text = "VALOR DEPÓSITO R$";
            this.lbl_valorDeposito.Visible = false;
            // 
            // btn_deposito
            // 
            this.btn_deposito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deposito.Enabled = false;
            this.btn_deposito.Location = new System.Drawing.Point(271, 348);
            this.btn_deposito.Name = "btn_deposito";
            this.btn_deposito.Size = new System.Drawing.Size(150, 60);
            this.btn_deposito.TabIndex = 13;
            this.btn_deposito.Text = "DEPÓSITO";
            this.btn_deposito.UseVisualStyleBackColor = true;
            this.btn_deposito.Click += new System.EventHandler(this.btn_deposito_Click);
            // 
            // lbl_saldoAtual
            // 
            this.lbl_saldoAtual.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_saldoAtual.Location = new System.Drawing.Point(399, 152);
            this.lbl_saldoAtual.Name = "lbl_saldoAtual";
            this.lbl_saldoAtual.Size = new System.Drawing.Size(153, 31);
            this.lbl_saldoAtual.TabIndex = 12;
            this.lbl_saldoAtual.Text = "saldo";
            this.lbl_saldoAtual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_saldoAtual.Visible = false;
            // 
            // lbl_valorSaldo
            // 
            this.lbl_valorSaldo.AutoSize = true;
            this.lbl_valorSaldo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_valorSaldo.Location = new System.Drawing.Point(271, 160);
            this.lbl_valorSaldo.Name = "lbl_valorSaldo";
            this.lbl_valorSaldo.Size = new System.Drawing.Size(122, 16);
            this.lbl_valorSaldo.TabIndex = 11;
            this.lbl_valorSaldo.Text = "SEU SALDO É R$";
            this.lbl_valorSaldo.Visible = false;
            // 
            // btn_saldo
            // 
            this.btn_saldo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_saldo.Enabled = false;
            this.btn_saldo.Location = new System.Drawing.Point(67, 348);
            this.btn_saldo.Name = "btn_saldo";
            this.btn_saldo.Size = new System.Drawing.Size(150, 60);
            this.btn_saldo.TabIndex = 10;
            this.btn_saldo.Text = "SALDO";
            this.btn_saldo.UseVisualStyleBackColor = true;
            this.btn_saldo.Click += new System.EventHandler(this.btn_saldo_Click);
            // 
            // lbl_selecaoOpcao
            // 
            this.lbl_selecaoOpcao.AutoSize = true;
            this.lbl_selecaoOpcao.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_selecaoOpcao.Location = new System.Drawing.Point(299, 302);
            this.lbl_selecaoOpcao.Name = "lbl_selecaoOpcao";
            this.lbl_selecaoOpcao.Size = new System.Drawing.Size(235, 16);
            this.lbl_selecaoOpcao.TabIndex = 9;
            this.lbl_selecaoOpcao.Text = "SELECIONE A OPÇÃO DESEJADA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(475, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Conta N.º  ";
            // 
            // lbl_contaNumero
            // 
            this.lbl_contaNumero.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_contaNumero.Location = new System.Drawing.Point(566, 105);
            this.lbl_contaNumero.Name = "lbl_contaNumero";
            this.lbl_contaNumero.Size = new System.Drawing.Size(111, 31);
            this.lbl_contaNumero.TabIndex = 7;
            this.lbl_contaNumero.Text = "numero";
            this.lbl_contaNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_contaNumero.Visible = false;
            // 
            // btn_entrar
            // 
            this.btn_entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_entrar.Location = new System.Drawing.Point(399, 34);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(120, 30);
            this.btn_entrar.TabIndex = 4;
            this.btn_entrar.Text = "ENTRAR";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite o número da conta";
            // 
            // lbl_titular
            // 
            this.lbl_titular.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_titular.Location = new System.Drawing.Point(284, 105);
            this.lbl_titular.Name = "lbl_titular";
            this.lbl_titular.Size = new System.Drawing.Size(137, 31);
            this.lbl_titular.TabIndex = 1;
            this.lbl_titular.Text = "nome";
            this.lbl_titular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_titular.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(168, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "BEM VINDO! - ";
            // 
            // FrmCaixaEletronico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 537);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCaixaEletronico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco - Caixa Eletrônico";
            this.Load += new System.EventHandler(this.FrmCaixaEletronico_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_entrar;
        private Label label2;
        private Label lbl_titular;
        private Label label1;
        private Label label5;
        private Label lbl_contaNumero;
        private Button btn_saldo;
        private Label lbl_selecaoOpcao;
        private Label lbl_saldoAtual;
        private Label lbl_valorSaldo;
        private Button btn_deposito;
        private Label lbl_valorDeposito;
        private TextBox txt_valorDeposito;
        private TextBox txt_idConta1;
        private TextBox txt_dataConta1;
        private Button btn_saque;
        private TextBox txt_valorSaque;
        private Label lbl_valorSaque;
        private Button btn_encerrar;
        private Button btn_transferencia;
        private TextBox txt_valorTransferencia;
        private Label lbl_valorTransferencia;
        private Label lbl_contaAReceber;
        private Label lbl_saldoT;
        private TextBox txt_dataConta2;
        private TextBox txt_idConta2;
        private TextBox txt_titularConta2;
        private MaskedTextBox txt_numeroConta;
        private MaskedTextBox txt_numeroContaAReceber;
    }
}