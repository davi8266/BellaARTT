using BellaART_Negocio.DAO;
using BellaART_Negocio.Mapeamento;
using System;
using System.Windows.Forms;

namespace BellaART
{
    public partial class CategoriaForm : Form
    {
        private Categoria _categoria;

        public CategoriaForm()
        {
            InitializeComponent();
            _categoria = new Categoria { Ativo = true };
            this.Text = "Nova Categoria";
        }

        public CategoriaForm(int id)
        {
            InitializeComponent();
            _categoria = new CategoriaDAO().Buscar(id);
            this.Text = $"Editar Categoria — {_categoria.Nome}";
        }

        private void CategoriaForm_Load(object sender, EventArgs e)
        {
            nomeTextBox.Text = _categoria.Nome;
            ativoCheckBox.Checked = _categoria.Ativo;
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            if (nomeTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("O nome da categoria é obrigatório.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _categoria.Nome = nomeTextBox.Text.Trim();
            _categoria.Ativo = ativoCheckBox.Checked;

            var id = new CategoriaDAO().Salvar(_categoria);

            if (id > 0)
            {
                MessageBox.Show("Categoria salva com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao salvar a categoria.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
