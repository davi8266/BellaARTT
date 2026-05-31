using BellaART_Negocio.DAO;
using BellaART_Negocio.Mapeamento;
using System;
using System.Windows.Forms;

namespace BellaART
{
    public partial class ProdutoForm : Form
    {
        private Produto _produto;

        public ProdutoForm()
        {
            InitializeComponent();
            _produto = new Produto { Ativo = true };
            this.Text = "Novo Produto";
        }

        public ProdutoForm(int id)
        {
            InitializeComponent();
            _produto = new ProdutoDAO().Buscar(id);
            this.Text = $"Editar Produto — {_produto.Nome}";
        }

        private void ProdutoForm_Load(object sender, EventArgs e)
        {
            CarregarCategorias();
            PreencherCampos();
        }

        private void CarregarCategorias()
        {
            var categorias = new CategoriaDAO().Listar();
            categoriaComboBox.DataSource = categorias;
            categoriaComboBox.DisplayMember = "Nome";
            categoriaComboBox.ValueMember = "ID";
        }

        private void PreencherCampos()
        {
            nomeTextBox.Text = _produto.Nome;
            skuTextBox.Text = _produto.SKU;
            descricaoTextBox.Text = _produto.Descricao;
            quantidadeNumericUpDown.Value = _produto.Quantidade;
            valorUnitarioNumericUpDown.Value = _produto.ValorUnitario;
            custoUnitarioNumericUpDown.Value = _produto.CustoUnitario;
            ativoCheckBox.Checked = _produto.Ativo;

            if (_produto.IDCategoria > 0)
                categoriaComboBox.SelectedValue = _produto.IDCategoria;
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            if (nomeTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("O nome do produto é obrigatório.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (skuTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("O SKU é obrigatório.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _produto.Nome = nomeTextBox.Text.Trim();
            _produto.SKU = skuTextBox.Text.Trim();
            _produto.Descricao = descricaoTextBox.Text.Trim();
            _produto.IDCategoria = (int)categoriaComboBox.SelectedValue;
            _produto.Quantidade = (int)quantidadeNumericUpDown.Value;
            _produto.ValorUnitario = valorUnitarioNumericUpDown.Value;
            _produto.CustoUnitario = custoUnitarioNumericUpDown.Value;
            _produto.Ativo = ativoCheckBox.Checked;

            var id = new ProdutoDAO().Salvar(_produto);

            if (id > 0)
            {
                MessageBox.Show("Produto salvo com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao salvar o produto.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void quantidadeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ativoCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
