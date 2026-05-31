using BellaART_Negocio.DAO;
using BellaART_Negocio.Mapeamento;
using System;
using System.Windows.Forms;

namespace BellaART
{
    public partial class ImpostoForm : Form
    {
        private Imposto _imposto;

        public ImpostoForm()
        {
            InitializeComponent();
            _imposto = new Imposto { Ativo = true };
            this.Text = "Novo Imposto";
        }

        public ImpostoForm(int id)
        {
            InitializeComponent();
            _imposto = new ImpostoDAO().Buscar(id);
            this.Text = $"Editar Imposto — {_imposto.Nome}";
        }

        private void ImpostoForm_Load(object sender, EventArgs e)
        {
            nomeTextBox.Text = _imposto.Nome;
            percentualNumericUpDown.Value = _imposto.Percentual;
            ativoCheckBox.Checked = _imposto.Ativo;
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            if (nomeTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("O nome do imposto é obrigatório.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _imposto.Nome = nomeTextBox.Text.Trim();
            _imposto.Percentual = percentualNumericUpDown.Value;
            _imposto.Ativo = ativoCheckBox.Checked;

            var id = new ImpostoDAO().Salvar(_imposto);

            if (id > 0)
            {
                MessageBox.Show("Imposto salvo com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao salvar o imposto.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

