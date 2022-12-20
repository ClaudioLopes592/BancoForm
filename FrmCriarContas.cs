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
    public partial class FrmCriarContas : Form
    {
        private Conta conta;

        public FrmCriarContas()
        {
            InitializeComponent();
        }

        private void FrmCriarContas_Load(object sender, EventArgs e)
        {
            this.lbl_dataAbertura.Text = DateTime.Now.ToString("dd/MM/yyyy");
            conta = new Conta();
            this.AtualizarTabela();
        }

        private void LimparCampos()
        {
            this.txt_numero.Text = "";
            this.lbl_dataAbertura.Text = "";
            this.txt_titular.Text = "";
            this.txt_saldo.Text = "";
            this.txt_numero.Focus();
        }

        private void btn_encerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_nova_Click(object sender, EventArgs e)

        {
            this.LimparCampos();
            this.lbl_dataAbertura.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void dgv_contas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow linha = dgv_contas.Rows[e.RowIndex];
            txt_idConta.Text = linha.Cells[0].Value.ToString();
            txt_numero.Text = linha.Cells[1].Value.ToString();
            lbl_dataAbertura.Text = linha.Cells[2].Value.ToString();
            txt_titular.Text = linha.Cells[3].Value.ToString();
            txt_saldo.Text = linha.Cells[4].Value.ToString();
        }

        private void AtualizarTabela()
        {
            MySqlDataReader temp = this.conta.ListarContas();
            DataTable dt = new DataTable();
            dt.Load(temp);
            dgv_contas.DataSource = dt;
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            this.conta.numero = Convert.ToInt32(txt_numero.Text);
            this.conta.dataCadastro = lbl_dataAbertura.Text;
            this.conta.titular = txt_titular.Text;
            this.conta.saldo = Convert.ToDouble(txt_saldo.Text);
            this.conta.CadastrarConta();
            MessageBox.Show("Conta cadastrada no banco com sucesso!");
            this.AtualizarTabela();
            this.LimparCampos();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            this.conta.numero = Convert.ToInt32(txt_numero.Text);
            this.conta.dataCadastro = lbl_dataAbertura.Text;
            this.conta.titular = txt_titular.Text;
            this.conta.saldo = Convert.ToDouble(txt_saldo.Text);
            this.conta.id_conta = Convert.ToInt32(txt_idConta.Text);
            this.conta.AlterarConta();
            MessageBox.Show("Conta editada no banco com sucesso!");
            this.AtualizarTabela();
            this.LimparCampos();
        }
    }
}
