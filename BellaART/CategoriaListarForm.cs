using BellaART_Negocio.DAO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BellaART
{
    public partial class CategoriaListarForm : Form
    {
        public CategoriaListarForm()
        {
            InitializeComponent();
        }

        private void CategoriaListarForm_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            var categorias = new CategoriaDAO().Listar();

            var filtro = filtroTextBox.Text.Trim().ToUpper();
            if (filtro.Length > 0)
                categorias = categorias.Where(c => c.Nome.ToUpper().Contains(filtro)).ToList();

            categoriasDataGridView.DataSource = categorias.Select(c => new
            {
                c.ID,
                c.Nome,
                Ativo = c.Ativo ? "Sim" : "NÃ£o"
            }).ToList();

            categoriasDataGridView.Columns["ID"].Visible = false;
            AtualizarBotoes();
        }

        private void AtualizarBotoes()
        {
            bool temSelecao = categoriasDataGridView.SelectedRows.Count > 0;
            editarButton.Enabled = temSelecao;
            excluirButton.Enabled = temSelecao;
        }

        private void filtroTextBox_TextChanged(object sender, EventArgs e)
        {
            Listar();
        }

        private void novoButton_Click(object sender, EventArgs e)
        {
            new CategoriaForm().ShowDialog();
            Listar();
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            var id = (int)categoriasDataGridView.SelectedRows[0].Cells["ID"].Value;
            new CategoriaForm(id).ShowDialog();
            Listar();
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            var id = (int)categoriasDataGridView.SelectedRows[0].Cells["ID"].Value;
            var nome = categoriasDataGridView.SelectedRows[0].Cells["Nome"].Value.ToString();

            var confirmacao = MessageBox.Show(
                $"Deseja realmente excluir a categoria '{nome}'?",
                "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacao == DialogResult.Yes)
            {
                var sucesso = new CategoriaDAO().Excluir(id);
                if (sucesso)
                    MessageBox.Show("Categoria excluÃ­da com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("NÃ£o foi possÃ­vel excluir. Verifique se hÃ¡ produtos vinculados.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Listar();
            }
        }

        private void categoriasDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            AtualizarBotoes();
        }
    }
}

