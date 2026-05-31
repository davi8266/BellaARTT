using BellaART_Negocio.DAO;
using BellaART_Negocio.Mapeamento;
using System;
using System.Windows.Forms;

namespace BellaART
{
    public partial class UsuarioForm : Form
    {
        private Usuario _usuario;

        public UsuarioForm()
        {
            InitializeComponent();
            _usuario = new Usuario { Ativo = true };
            this.Text = "Novo Usuário";
        }

        public UsuarioForm(int id)
        {
            InitializeComponent();
            _usuario = new UsuarioDAO().Buscar(id);
            this.Text = $"Editar Usuário — {_usuario.Nome}";
        }

        private void UsuarioForm_Load(object sender, EventArgs e)
        {
            nomeTextBox.Text = _usuario.Nome;
            cargoTextBox.Text = _usuario.Cargo;
            loginTextBox.Text = _usuario.Login;
            senhaTextBox.Text = _usuario.Senha;
            adminCheckBox.Checked = _usuario.Admin;
            ativoCheckBox.Checked = _usuario.Ativo;
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            if (nomeTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("O nome é obrigatório.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (loginTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("O login é obrigatório.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (senhaTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("A senha é obrigatória.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _usuario.Nome = nomeTextBox.Text.Trim();
            _usuario.Cargo = cargoTextBox.Text.Trim();
            _usuario.Login = loginTextBox.Text.Trim();
            _usuario.Senha = senhaTextBox.Text.Trim();
            _usuario.Admin = adminCheckBox.Checked;
            _usuario.Ativo = ativoCheckBox.Checked;

            var id = new UsuarioDAO().Salvar(_usuario);

            if (id > 0)
            {
                MessageBox.Show("Usuário salvo com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao salvar o usuário.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

