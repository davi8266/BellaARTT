using BellaART_Negocio.DAO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BellaART
{
    public partial class UsuarioListarForm : Form
    {
        public UsuarioListarForm()
        {
            InitializeComponent();
        }

        private void UsuarioListarForm_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            var usuarios = new UsuarioDAO().Listar();

            var filtro = filtroTextBox.Text.Trim().ToUpper();
            if (filtro.Length > 0)
                usuarios = usuarios.Where(u => u.Nome.ToUpper().Contains(filtro) || u.Login.ToUpper().Contains(filtro)).ToList();

            usuariosDataGridView.DataSource = usuarios.Select(u => new
            {
                u.ID,
                u.Nome,
                u.Cargo,
                u.Login,
                Admin = u.Admin ? "Sim" : "Não",
                Ativo = u.Ativo ? "Sim" : "Não"
            }).ToList();

            usuariosDataGridView.Columns["ID"].Visible = false;
            AtualizarBotoes();
        }

        private void AtualizarBotoes()
        {
            bool temSelecao = usuariosDataGridView.SelectedRows.Count > 0;
            editarButton.Enabled = temSelecao;
            excluirButton.Enabled = temSelecao;
        }

        private void filtroTextBox_TextChanged(object sender, EventArgs e)
        {
            Listar();
        }

        private void novoButton_Click(object sender, EventArgs e)
        {
            new UsuarioForm().ShowDialog();
            Listar();
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            var id = (int)usuariosDataGridView.SelectedRows[0].Cells["ID"].Value;
            new UsuarioForm(id).ShowDialog();
            Listar();
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            var id = (int)usuariosDataGridView.SelectedRows[0].Cells["ID"].Value;
            var nome = usuariosDataGridView.SelectedRows[0].Cells["Nome"].Value.ToString();

            var confirmacao = MessageBox.Show(
                $"Deseja realmente excluir o usuário '{nome}'?",
                "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacao == DialogResult.Yes)
            {
                var sucesso = new UsuarioDAO().Excluir(id);
                if (sucesso)
                    MessageBox.Show("Usuário excluído com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Não foi possível excluir o usuário.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Listar();
            }
        }

        private void usuariosDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            AtualizarBotoes();
        }
    }
}

