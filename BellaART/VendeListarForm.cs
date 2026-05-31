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

        private void filtroTextBox_TextChanged(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            var vendas = new VendaDAO().Listar();

            var filtro = filtroTextBox.Text.Trim().ToUpper();
            if (filtro.Length > 0)
                vendas = vendas.Where(v => v.Cliente != null && v.Cliente.Nome.ToUpper().Contains(filtro)).ToList();

            vendasDataGridView.DataSource = vendas.Select(v =>
            {
                var custoTotal = v.Itens.Sum(i => (i.Produto?.CustoUnitario ?? 0) * i.Quantidade);
                var subtotal = v.Itens.Sum(i => i.Subtotal);
                var percentual = v.Imposto?.Percentual ?? 0;
                var impostoValor = subtotal * percentual / 100;
                var lucro = v.ValorTotal - impostoValor - custoTotal;

                return new
                {
                    v.ID,
                    Cliente = v.Cliente?.Nome,
                    Imposto = v.Imposto?.Nome,
                    DataVenda = v.DataVenda.ToString("dd/MM/yyyy HH:mm"),
                    v.ValorTotal,
                    Lucro = lucro,
                    Ativo = v.Ativo ? "Sim" : "Não"
                };
            }).ToList();

            vendasDataGridView.Columns["ID"].Visible = false;

            var vendasHoje = vendas.Where(v => v.DataVenda.Date == DateTime.Today).ToList();
            var lucroDia = vendasHoje.Sum(v =>
            {
                var custoTotal = v.Itens.Sum(i => (i.Produto?.CustoUnitario ?? 0) * i.Quantidade);
                var subtotal = v.Itens.Sum(i => i.Subtotal);
                var percentual = v.Imposto?.Percentual ?? 0;
                var impostoValor = subtotal * percentual / 100;
                return v.ValorTotal - impostoValor - custoTotal;
            });
            lucroDiaLabel.Text = $"R$ {lucroDia:F2}";
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





