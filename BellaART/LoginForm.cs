using BellaART_Negocio;
using BellaART_Negocio.DAO;
using System;
using System.Windows.Forms;

namespace BellaART
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void entrarButton_Click(object sender, EventArgs e)
        {
            var usuario = new UsuarioDAO().Login(usuarioTextBox.Text, senhaTextBox.Text);

            if (usuario == null)
            {
                MessageBox.Show("Usuário ou senha inválido!", "Acesso inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (usuario.Ativo == false)
            {
                MessageBox.Show("Usuário desativado!", "Acesso inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AreaCompartilhada.UsuarioLogado = usuario;
            Close();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void artLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
