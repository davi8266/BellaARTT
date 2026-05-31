using BellaART_Negocio.DAO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BellaART
{
    public partial class ProdutoListarForm : Form
    {
        public ProdutoListarForm()
        {
            InitializeComponent();
        }

        private void ProdutoListarForm_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            var produtos = new ProdutoDAO().Listar();

            var filtro = filtroTextBox.Text.Trim().ToUpper();
            if (filtro.Length > 0)
            {
                produtos = produtos.Where(p =>
                    p.Nome.ToUpper().Contains(filtro) ||
                    p.SKU.ToUpper().Contains(filtro)
                ).ToList();
            }

            produtosDataGridView.DataSource = produtos.Select(p => new
            {
                p.ID,
                p.Nome,
                p.SKU,
                Categoria = p.Categoria?.Nome,
                p.Descricao,
                p.Quantidade,
                p.ValorUnitario,
                p.CustoUnitario,
                Ativo = p.Ativo ? "Sim" : "Não"
            }).ToList();

            produtosDataGridView.Columns["ID"].Visible = false;
            AtualizarBotoes();
        }

        private void AtualizarBotoes()
        {
            bool temSelecao = produtosDataGridView.SelectedRows.Count > 0;
            editarButton.Enabled = temSelecao;
            excluirButton.Enabled = temSelecao;
        }

        private void filtroTextBox_TextChanged(object sender, EventArgs e)
        {
            Listar();
        }

        private void novoButton_Click(object sender, EventArgs e)
        {
            new ProdutoForm().ShowDialog();
            Listar();
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            var id = (int)produtosDataGridView.SelectedRows[0].Cells["ID"].Value;
            new ProdutoForm(id).ShowDialog();
            Listar();
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            var id = (int)produtosDataGridView.SelectedRows[0].Cells["ID"].Value;
            var nome = produtosDataGridView.SelectedRows[0].Cells["Nome"].Value.ToString();

            var confirmacao = MessageBox.Show(
                $"Deseja realmente excluir o produto '{nome}'?",
                "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacao == DialogResult.Yes)
            {
                var sucesso = new ProdutoDAO().Excluir(id);
                if (sucesso)
                    MessageBox.Show("Produto excluído com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Não foi possível excluir o produto.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Listar();
            }
        }

        private void produtosDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            AtualizarBotoes();
        }
    }
}
