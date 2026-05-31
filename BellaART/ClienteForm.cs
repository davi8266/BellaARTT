using BellaART_Negocio.DAO;
using BellaART_Negocio.Mapeamento;
using System;
using System.Windows.Forms;

namespace BellaART
{
    public partial class ClienteForm : Form
    {
        private Cliente _cliente;

        public ClienteForm()
        {
            InitializeComponent();
            _cliente = new Cliente { Ativo = true };
            this.Text = "Novo Cliente";
        }

        public ClienteForm(int id)
        {
            InitializeComponent();
            _cliente = new ClienteDAO().Buscar(id);
            this.Text = $"Editar Cliente — {_cliente.Nome}";
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {
            nomeTextBox.Text = _cliente.Nome;
            cpfcnpjTextBox.Text = _cliente.CPFCNPJ;
            telefoneTextBox.Text = _cliente.Telefone;
            emailTextBox.Text = _cliente.Email;
            enderecoTextBox.Text = _cliente.Endereco;
            ativoCheckBox.Checked = _cliente.Ativo;
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            if (nomeTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("O nome do cliente é obrigatório.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _cliente.Nome = nomeTextBox.Text.Trim();
            _cliente.CPFCNPJ = cpfcnpjTextBox.Text.Trim();
            _cliente.Telefone = telefoneTextBox.Text.Trim();
            _cliente.Email = emailTextBox.Text.Trim();
            _cliente.Endereco = enderecoTextBox.Text.Trim();
            _cliente.Ativo = ativoCheckBox.Checked;

            var id = new ClienteDAO().Salvar(_cliente);

            if (id > 0)
            {
                MessageBox.Show("Cliente salvo com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao salvar o cliente.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


