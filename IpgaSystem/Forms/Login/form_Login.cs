using System;

namespace IpgaSystem.Forms.Login
{
    public partial class form_Login : DevExpress.XtraEditors.XtraForm
    {
        ipgaContext context = new ipgaContext();

        public form_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //var usuario = txtUsuario.Text;
            //var senha = txtSenha.Text;

            //var user = context.tb_usuarios.FirstOrDefault(u => u.usu_login == usuario && u.usu_senha == senha);

            //if (user == null)
            //{
            //    XtraMessageBox.Show("Usuário ou senha inválidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            //form_MenuPrincipal formPrincipal = new form_MenuPrincipal();
            //formPrincipal.Show();
        }
    }
}
