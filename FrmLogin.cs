namespace Banco
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if (txt_email.Text == "claudioglopes1@gmail.com" && txt_senha.Text == "123456")
            {
                FrmPrincipal frmPrincipal = new FrmPrincipal();
                frmPrincipal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Email ou senha informado não é válido!");
            }
        }
    }
}