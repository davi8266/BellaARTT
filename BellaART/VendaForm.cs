using BellaART_Negocio.DAO;
using BellaART_Negocio.Mapeamento;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BellaART
{
    public partial class VendaForm : Form
    {
        private Venda _venda;

        public VendaForm()
        {
            InitializeComponent();
            _venda = new Venda { DataVenda = DateTime.Now, Ativo = true };
            this.Text = "Nova Venda";
        }

        public VendaForm(int id)
        {
            InitializeComponent();
            _venda = new VendaDAO().Buscar(id);
            this.Text = $"Editar Venda #{_venda.ID}";
        }

        private void VendaForm_Load(object sender, EventArgs e)
        {
            CarregarClientes();
            CarregarImpostos();
            CarregarProdutos();

            if (_venda.IDCliente > 0)
                clienteComboBox.SelectedValue = _venda.IDCliente;

            if (_venda.IDImposto > 0)
                impostoComboBox.SelectedValue = _venda.IDImposto;

            AtualizarItens();
        }

        private void CarregarClientes()
        {
            clienteComboBox.DataSource = new ClienteDAO().Listar();
            clienteComboBox.DisplayMember = "Nome";
            clienteComboBox.ValueMember = "ID";
        }

        private void CarregarImpostos()
        {
            impostoComboBox.DataSource = new ImpostoDAO().Listar();
            impostoComboBox.DisplayMember = "Nome";
            impostoComboBox.ValueMember = "ID";
        }

        private void CarregarProdutos()
        {
            produtoComboBox.DataSource = new ProdutoDAO().Listar();
            produtoComboBox.DisplayMember = "Nome";
            produtoComboBox.ValueMember = "ID";
        }

        private void adicionarButton_Click(object sender, EventArgs e)
        {
            if (produtoComboBox.SelectedValue == null) return;

            var produto = new ProdutoDAO().Buscar((int)produtoComboBox.SelectedValue);
            var quantidade = (int)quantidadeNumericUpDown.Value;

            if (quantidade <= 0)
            {
                MessageBox.Show("Quantidade deve ser maior que zero.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var itemExistente = _venda.Itens.FirstOrDefault(i => i.IDProduto == produto.ID);
            if (itemExistente != null)
                itemExistente.Quantidade += quantidade;
            else
                _venda.Itens.Add(new VendaItem
                {
                    IDProduto = produto.ID,
                    Produto = produto,
                    Quantidade = quantidade,
                    ValorUnitario = produto.ValorUnitario,
                    Subtotal = produto.ValorUnitario * quantidade
                });

            AtualizarItens();
        }

        private void removerButton_Click(object sender, EventArgs e)
        {
            if (itensDataGridView.SelectedRows.Count == 0) return;

            var idx = itensDataGridView.SelectedRows[0].Index;
            _venda.Itens.RemoveAt(idx);
            AtualizarItens();
        }

        private void AtualizarItens()
        {
            itensDataGridView.DataSource = null;
            itensDataGridView.DataSource = _venda.Itens.Select(i => new
            {
                Produto = i.Produto?.Nome,
                i.Quantidade,
                i.ValorUnitario,
                i.Subtotal
            }).ToList();

            var subtotal = _venda.Itens.Sum(i => i.Subtotal);
            var imposto = impostoComboBox.SelectedItem as Imposto;
            var percentual = imposto?.Percentual ?? 0;
            var total = subtotal + (subtotal * percentual / 100);

            subtotalLabel.Text = $"Subtotal: R$ {subtotal:F2}";
            impostoValorLabel.Text = $"Imposto ({percentual}%): R$ {subtotal * percentual / 100:F2}";
            totalLabel.Text = $"Total: R$ {total:F2}";

            _venda.ValorTotal = total;
        }

        private void impostoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarItens();
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            if (clienteComboBox.SelectedValue == null)
            {
                MessageBox.Show("Selecione um cliente.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_venda.Itens.Count == 0)
            {
                MessageBox.Show("Adicione pelo menos um produto.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _venda.IDCliente = (int)clienteComboBox.SelectedValue;
            _venda.IDImposto = (int)impostoComboBox.SelectedValue;

            var id = new VendaDAO().Salvar(_venda);

            if (id > 0)
            {
                MessageBox.Show("Venda salva com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao salvar a venda.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


