using BellaART_Negocio.DAO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BellaART
{
    public partial class VendaListarForm : Form
    {
        public VendaListarForm()
        {
            InitializeComponent();
        }

        private void VendaListarForm_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            var vendas = new VendaDAO().Listar();

            vendasDataGridView.DataSource = vendas.Select(v => new
            {
                v.ID,
                Cliente = v.Cliente?.Nome,
                Imposto = v.Imposto?.Nome,
                DataVenda = v.DataVenda.ToString("dd/MM/yyyy HH:mm"),
                v.ValorTotal,
                Ativo = v.Ativo ? "Sim" : "Não"
            }).ToList();

            vendasDataGridView.Columns["ID"].Visible = false;
            AtualizarBotoes();
        }

        private void AtualizarBotoes()
        {
            bool temSelecao = vendasDataGridView.SelectedRows.Count > 0;
            editarButton.Enabled = temSelecao;
            excluirButton.Enabled = temSelecao;
        }

        private void novoButton_Click(object sender, EventArgs e)
        {
            new VendaForm().ShowDialog();
            Listar();
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            var id = (int)vendasDataGridView.SelectedRows[0].Cells["ID"].Value;
            new VendaForm(id).ShowDialog();
            Listar();
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            var id = (int)vendasDataGridView.SelectedRows[0].Cells["ID"].Value;

            var confirmacao = MessageBox.Show(
                "Deseja realmente excluir esta venda?",
                "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacao == DialogResult.Yes)
            {
                var sucesso = new VendaDAO().Excluir(id);
                if (sucesso)
                    MessageBox.Show("Venda excluída com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Não foi possível excluir a venda.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Listar();
            }
        }

        private void vendasDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            AtualizarBotoes();
        }
    }
}
