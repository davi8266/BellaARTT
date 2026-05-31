using BellaART_Negocio.DAO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BellaART
{
    public partial class ImpostoListarForm : Form
    {
        public ImpostoListarForm()
        {
            InitializeComponent();
        }

        private void ImpostoListarForm_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            var impostos = new ImpostoDAO().Listar();

            var filtro = filtroTextBox.Text.Trim().ToUpper();
            if (filtro.Length > 0)
                impostos = impostos.Where(i => i.Nome.ToUpper().Contains(filtro)).ToList();

            impostosDataGridView.DataSource = impostos.Select(i => new
            {
                i.ID,
                i.Nome,
                Percentual = i.Percentual.ToString("0.00") + "%",
                Ativo = i.Ativo ? "Sim" : "Não"
            }).ToList();

            impostosDataGridView.Columns["ID"].Visible = false;
            AtualizarBotoes();
        }

        private void AtualizarBotoes()
        {
            bool temSelecao = impostosDataGridView.SelectedRows.Count > 0;
            editarButton.Enabled = temSelecao;
            excluirButton.Enabled = temSelecao;
        }

        private void filtroTextBox_TextChanged(object sender, EventArgs e)
        {
            Listar();
        }

        private void novoButton_Click(object sender, EventArgs e)
        {
            new ImpostoForm().ShowDialog();
            Listar();
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            var id = (int)impostosDataGridView.SelectedRows[0].Cells["ID"].Value;
            new ImpostoForm(id).ShowDialog();
            Listar();
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            var id = (int)impostosDataGridView.SelectedRows[0].Cells["ID"].Value;
            var nome = impostosDataGridView.SelectedRows[0].Cells["Nome"].Value.ToString();

            var confirmacao = MessageBox.Show(
                $"Deseja realmente excluir o imposto '{nome}'?",
                "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacao == DialogResult.Yes)
            {
                var sucesso = new ImpostoDAO().Excluir(id);
                if (sucesso)
                    MessageBox.Show("Imposto excluído com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Não foi possível excluir o imposto.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Listar();
            }
        }

        private void impostosDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            AtualizarBotoes();
        }
    }
}

