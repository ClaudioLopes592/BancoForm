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
    public partial class FrmDeposito : Form
    {
        Conta conta = new Conta();

        public FrmDeposito()
        {
            InitializeComponent();
        }

        private void btn_depositar_Click(object sender, EventArgs e)
        {
            //double totalDeposito = double.Parse(txt_valorDeposito.Text);

            if (txt_valorDeposito.Text != "")
            {
                //FrmCaixaEletronico frmCaixaEletronico = new FrmCaixaEletronico();
                //frmCaixaEletronico.lbl_deposito.Text = txt_valorDeposito.Text;
                //this.Close();
                /*
                 * this.conta.numero = Convert.ToInt32(txt_numero.Text);
            this.conta.dataCadastro = lbl_dataAbertura.Text;
            this.conta.titular = txt_titular.Text;
            this.conta.saldo = Convert.ToDouble(txt_saldo.Text);
            this.conta.CadastrarConta();
            MessageBox.Show("Conta cadastrada no banco com sucesso!");
                 */
            }
        }
    }
}
