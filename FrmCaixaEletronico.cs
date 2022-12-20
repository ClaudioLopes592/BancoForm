using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class FrmCaixaEletronico : Form
    {
        Conta conta = new Conta();
        double saldoAtual = 0;

        public FrmCaixaEletronico()
        {
            InitializeComponent();
        }

        private void IniciarOperacao1()
        {
            if (txt_numeroConta.Text == "")
            {
                MessageBox.Show("Informe o número da conta!");
                txt_numeroConta.Focus();
            }
            else
            {
                int n = int.Parse(txt_numeroConta.Text);
                MySqlDataReader reader = this.conta.BuscarConta(n.ToString());
                if (reader.Read())
                {
                    lbl_titular.Text = ($"{reader["titular"]}");
                    lbl_contaNumero.Text = ($"{reader["numero"]}");
                    txt_idConta1.Text = ($"{reader["id_conta"]}");
                    txt_dataConta1.Text = ($"{reader["data_cadastro"]}");
                    lbl_titular.Visible = true;
                    lbl_contaNumero.Visible = true;
                    txt_numeroConta.Enabled = false;
                    lbl_selecaoOpcao.Visible = true;
                    btn_saldo.Enabled = true;
                    btn_entrar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Conta não localizada!");
                    txt_numeroConta.Text = "";
                    txt_numeroConta.Focus();
                }
                reader.Close();
            }
        }

        private void IniciarOperacao2()
        {
            if (txt_numeroContaAReceber.Text != "")
            {
                int nt = int.Parse(txt_numeroContaAReceber.Text);
                MySqlDataReader reader = this.conta.BuscarConta(nt.ToString());
                if (reader.Read())
                {
                    txt_titularConta2.Text = ($"{reader["titular"]}");
                    //lbl_contaNumero.Text = ($"{reader["numero"]}");
                    txt_idConta2.Text = ($"{reader["id_conta"]}");
                    txt_dataConta2.Text = ($"{reader["data_cadastro"]}");
                    //txt_numeroConta.Enabled = false;
                    //lbl_selecaoOpcao.Visible = true;
                    //btn_saldo.Enabled = true;
                    //btn_entrar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Conta não localizada!");
                    txt_numeroContaAReceber.Text = "";
                    txt_numeroContaAReceber.Focus();
                }
                reader.Close();
            }
        }

        private void SolicitarSaldo()
        {
            lbl_valorSaldo.Visible = true;
            lbl_saldoAtual.Visible = true;
            btn_deposito.Enabled = true;
            btn_transferencia.Enabled = true;
            btn_saque.Enabled = true;
            btn_saldo.Enabled = false;
            int n = int.Parse(txt_numeroConta.Text);

            if (lbl_contaNumero.Text != "")
            {
                MySqlDataReader reader = this.conta.BuscarConta(n.ToString());
                while (reader.Read())
                {
                    lbl_saldoAtual.Text = ($"{reader["saldo"]}");
                }
                reader.Close();
            }
        }

        private void RealizarDeposito()
        {
            lbl_valorDeposito.Visible = true;
            txt_valorDeposito.Visible = true;
            btn_saque.Enabled = false;
            btn_transferencia.Enabled = false;
            btn_saldo.Enabled = false;
            txt_valorDeposito.Focus();
            if (txt_valorDeposito.Text != "")
            {
                double valorSaldo = double.Parse(lbl_saldoAtual.Text);
                double valorDeposito = double.Parse(txt_valorDeposito.Text);
                saldoAtual = valorSaldo + valorDeposito;
                lbl_saldoAtual.Text = saldoAtual.ToString();
                if (btn_deposito.Text == "CONFIRMAR")
                {
                    this.Alterar();
                    this.LimparCampos();
                    lbl_valorDeposito.Visible = false;
                    txt_valorDeposito.Visible = false;
                    lbl_valorSaldo.Visible = false;
                    btn_deposito.Text = "DEPÓSITO";
                    btn_deposito.Enabled = false;
                    txt_numeroConta.Enabled = true;
                    btn_entrar.Enabled = true;
                    txt_numeroConta.Focus();
                    MessageBox.Show("Depósito realizado com sucesso!");
                }
            }
            else
            {
                MessageBox.Show("Digite o valor do depósito!");
                btn_deposito.Text = "CONFIRMAR";
                txt_valorDeposito.Focus();
            }
        }

        private void RealizaSaque()
        {
            lbl_valorSaque.Visible = true;
            txt_valorSaque.Visible = true;
            btn_deposito.Enabled = false;
            btn_transferencia.Enabled = false;
            txt_valorSaque.Focus();
            if (txt_valorSaque.Text != "")
            {
                double valorSaldo = double.Parse(lbl_saldoAtual.Text);
                double valorSaque = double.Parse(txt_valorSaque.Text);
                if (valorSaque <= valorSaldo)
                {
                    saldoAtual = valorSaldo - valorSaque;
                    lbl_saldoAtual.Text = saldoAtual.ToString();
                    if (btn_saque.Text == "CONFIRMAR")
                    {
                        this.Alterar();
                        this.LimparCampos();
                        lbl_valorSaque.Visible = false;
                        txt_valorSaque.Visible = false;
                        lbl_valorSaldo.Visible = false;
                        btn_saque.Text = "SAQUE";
                        btn_saque.Enabled = false;
                        txt_numeroConta.Enabled = true;
                        btn_entrar.Enabled = true;
                        txt_numeroConta.Focus();
                        MessageBox.Show("Saque realizado com sucesso!");
                    }
                }
                else
                {
                    MessageBox.Show("Operação não realizada! Saldo insuficiente.");
                    this.LimparCampos();
                    btn_saque.Text = "SAQUE";
                    lbl_valorSaque.Visible = false;
                    txt_valorSaque.Visible = false;
                    lbl_valorSaldo.Visible = false;
                    btn_deposito.Enabled = false;
                    btn_saque.Enabled = false;
                    txt_numeroConta.Enabled = true;
                    btn_entrar.Enabled = true;
                    txt_numeroConta.Focus();
                }
            }
            else
            {
                MessageBox.Show("Digite o valor do saque!");
                btn_saque.Text = "CONFIRMAR";
                txt_valorSaque.Focus();
            }
        }

        private void SolicitarSaldoTransferencia()
        {
            int nt = int.Parse(txt_numeroContaAReceber.Text);

            if (txt_numeroContaAReceber.Text != "")
            {
                MySqlDataReader reader = this.conta.BuscarConta(nt.ToString());
                while (reader.Read())
                {
                    lbl_saldoT.Text = ($"{reader["saldo"]}");
                }
                reader.Close();
            }
        }

        private void RealizaTransferencia()
        {
            lbl_valorTransferencia.Visible = true;
            txt_valorTransferencia.Visible = true;
            lbl_contaAReceber.Visible = true;
            txt_numeroContaAReceber.Visible = true;
            btn_deposito.Enabled = false;
            btn_saque.Enabled = false;
            txt_valorTransferencia.Focus();
            if (btn_transferencia.Text != "CONFIRMAR")
            {
                if (txt_valorTransferencia.Text == "")
                {
                    MessageBox.Show("Informe o valor da transferência R$");
                }
                else if (txt_numeroContaAReceber.Text == "")
                {
                    MessageBox.Show("Informe o número da conta para transferência R$");
                    txt_numeroContaAReceber.Focus();
                }
                else 
                {
                    btn_transferencia.Text = "CONFIRMAR";
                }
                if (btn_transferencia.Text == "CONFIRMAR")
                {
                    this.IniciarOperacao2();
                    txt_idConta2.Visible = false;
                    txt_titularConta2.Visible = false;
                    txt_dataConta2.Visible = false;
                    lbl_saldoT.Visible = false;
                    this.SolicitarSaldoTransferencia();
                    double valorSaldo = double.Parse(lbl_saldoAtual.Text);
                    double valorSaque = double.Parse(txt_valorTransferencia.Text);
                    double valorSaldoT = double.Parse(lbl_saldoT.Text);
                    if (valorSaque <= valorSaldo)
                    {
                        saldoAtual = valorSaldo - valorSaque;
                        double saldoAtualTransferencia = valorSaldoT + valorSaque;
                        lbl_saldoAtual.Text = saldoAtual.ToString();
                        lbl_saldoT.Text = saldoAtualTransferencia.ToString();
                        this.AlteraContaTransferencia();
                        this.LimparCampos();
                        lbl_valorTransferencia.Visible = false;
                        txt_valorTransferencia.Visible = false;
                        lbl_contaAReceber.Visible = false;
                        txt_numeroContaAReceber.Visible = false;
                        btn_transferencia.Text = "TRANSFERÊNCIA";
                        btn_transferencia.Enabled = false;
                        btn_saque.Enabled = false;
                        txt_numeroConta.Enabled = true;
                        btn_entrar.Enabled = true;
                        lbl_saldoT.Visible = false;
                        txt_numeroConta.Focus();
                        MessageBox.Show("Transferência realizada com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Operação não realizada, saldo insuficiênte!");
                        this.LimparCampos();
                        lbl_valorSaldo.Text = "";
                        lbl_valorTransferencia.Visible = false;
                        txt_valorTransferencia.Visible = false;
                        lbl_contaAReceber.Visible = false;
                        txt_numeroContaAReceber.Visible = false;
                        txt_numeroConta.Enabled = true;
                        btn_entrar.Enabled = true;
                        txt_numeroConta.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Conta não localizada, encerrando o programa...!");
            }

        }

        private void btn_transferencia_Click(object sender, EventArgs e)
        {
            this.RealizaTransferencia();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            this.IniciarOperacao1();
        }

        private void btn_saldo_Click(object sender, EventArgs e)
        {
            this.SolicitarSaldo();
        }

        private void btn_deposito_Click(object sender, EventArgs e)
        {
            this.RealizarDeposito();
        }
        
        private void Alterar()
        {
            this.conta.numero = Convert.ToInt32(lbl_contaNumero.Text);
            this.conta.dataCadastro = txt_dataConta1.Text;
            this.conta.titular = lbl_titular.Text;
            this.conta.saldo = Convert.ToDouble(lbl_saldoAtual.Text);
            this.conta.id_conta = Convert.ToInt32(txt_idConta1.Text);
            this.conta.AlterarConta();
        }

        private void AlteraContaTransferencia()
        {
            this.conta.numero = Convert.ToInt32(txt_numeroContaAReceber.Text);
            this.conta.dataCadastro = txt_dataConta2.Text;
            this.conta.titular = txt_titularConta2.Text;
            this.conta.saldo = Convert.ToDouble(lbl_saldoT.Text);
            this.conta.id_conta = Convert.ToInt32(txt_idConta2.Text);
            this.conta.AlterarConta();
            this.Alterar();
        }

        private void LimparCampos()
        {
            txt_numeroConta.Text = "";
            lbl_contaNumero.Text = "";
            txt_dataConta1.Text = "";
            lbl_titular.Text = "";
            lbl_saldoAtual.Text = "";
            txt_idConta1.Text = "";
            txt_idConta2.Text = "";
            txt_titularConta2.Text = "";
            txt_dataConta2.Text = "";
            txt_valorDeposito.Text = "";
            txt_valorSaque.Text = "";
            txt_valorTransferencia.Text = "";
            txt_numeroContaAReceber.Text = "";
            txt_numeroConta.Focus();
        }

        private void btn_saque_Click(object sender, EventArgs e)
        {
            this.RealizaSaque();
        }

        private void FrmCaixaEletronico_Load(object sender, EventArgs e)
        {
            if (txt_numeroConta.Text != "")
            {
                btn_saldo.Enabled = true;
                btn_deposito.Enabled = true;
                btn_saque.Enabled = true;
                btn_transferencia.Enabled = true;
            }
            else
            {
                btn_saldo.Enabled = false;
                btn_deposito.Enabled = false;
                btn_saque.Enabled = false;
                btn_transferencia.Enabled = false;
            }
        }

        private void btn_encerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        


        private void CONFIRMAR(object sender, EventArgs e)
        {

        }
    }
}
