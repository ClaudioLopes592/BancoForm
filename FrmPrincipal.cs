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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void tsm_abrirConta_Click(object sender, EventArgs e)
        {
            FrmCriarContas frmCriarContas = new FrmCriarContas();
            frmCriarContas.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            this.lbl_usuarioLogado.Text = frmLogin.txt_nome.Text;
            this.lbl_dataAtual.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void tsm_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsm_abrirCaixa_Click(object sender, EventArgs e)
        {
            FrmCaixaEletronico frmCaixaEletronico = new FrmCaixaEletronico();
            frmCaixaEletronico.ShowDialog();
        }
    }
}
