using BellaART_Negocio.DAO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BellaART
{
    public partial class ClienteListarForm : Form
    {
        public ClienteListarForm()
        {
            InitializeComponent();
        }

        private void ClienteListarForm_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            var clientes = new ClienteDAO().Listar();

            var filtro = filtroTextBox.Text.Trim().ToUpper();
            if (filtro.Length > 0)
                clientes = clientes.Where(c =>
                    c.Nome.ToUpper().Contains(filtro) ||
                    (c.CPFCNPJ != null && c.CPFCNPJ.Contains(filtro))
                ).ToList();

            clientesDataGridView.DataSource = clientes.Select(c => new
            {
                c.ID,
                c.Nome,
                c.CPFCNPJ,
                c.Telefone,
                c.Email,
                c.Endereco,
                Ativo = c.Ativo ? "Sim" : "Não"
            }).ToList();

            clientesDataGridView.Columns["ID"].Visible = false;
            AtualizarBotoes();
        }

        private void AtualizarBotoes()
        {
            bool temSelecao = clientesDataGridView.SelectedRows.Count > 0;
            editarButton.Enabled = temSelecao;
            excluirButton.Enabled = temSelecao;
        }

        private void filtroTextBox_TextChanged(object sender, EventArgs e)
        {
            Listar();
        }

        private void novoButton_Click(object sender, EventArgs e)
        {
            new ClienteForm().ShowDialog();
            Listar();
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            var id = (int)clientesDataGridView.SelectedRows[0].Cells["ID"].Value;
            new ClienteForm(id).ShowDialog();
            Listar();
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            var id = (int)clientesDataGridView.SelectedRows[0].Cells["ID"].Value;
            var nome = clientesDataGridView.SelectedRows[0].Cells["Nome"].Value.ToString();

            var confirmacao = MessageBox.Show(
                $"Deseja realmente excluir o cliente '{nome}'?",
                "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacao == DialogResult.Yes)
            {
                var sucesso = new ClienteDAO().Excluir(id);
                if (sucesso)
                    MessageBox.Show("Cliente excluído com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Não foi possível excluir o cliente.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Listar();
            }
        }

        private void clientesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            AtualizarBotoes();
        }
    }
}


