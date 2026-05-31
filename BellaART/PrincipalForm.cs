using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BellaART_Negocio;

namespace BellaART
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            toolStrip1.AutoSize = false;
            toolStrip1.Height = 64;
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ProdutoListarForm() { MdiParent = this, WindowState = FormWindowState.Maximized }.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CategoriaListarForm() { MdiParent = this, WindowState = FormWindowState.Maximized }.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UsuarioListarForm() { MdiParent = this, WindowState = FormWindowState.Maximized }.Show();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Sobre().ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja realmente sair do programa?", "Sair",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
                Close();
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            AbrirLogin();
        }

        private void impostosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ImpostoListarForm() { MdiParent = this, WindowState = FormWindowState.Maximized }.Show();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ClienteListarForm() { MdiParent = this, WindowState = FormWindowState.Maximized }.Show();
        }

        private void AbrirLogin()
        {
            new LoginForm().ShowDialog();

            if (AreaCompartilhada.UsuarioLogado == null)
            {
                Close();
                return;
            }
        }



        private void horarioTimer_Tick(object sender, EventArgs e)
        {
            horarioToolStripStatusLabel.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dashboardToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dashboard em desenvolvimento.", "Em breve", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void produtosToolStripButton_Click(object sender, EventArgs e)
        {
            new ProdutoListarForm() { MdiParent = this, WindowState = FormWindowState.Maximized }.Show();
        }

        private void vendasToolStripButton_Click(object sender, EventArgs e)
        {
            new VendaListarForm() { MdiParent = this, WindowState = FormWindowState.Maximized }.Show();
        }

        private void sairToolStripButton_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja realmente sair do programa?", "Sair",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
                Close();
        }
        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new VendaListarForm() { MdiParent = this, WindowState = FormWindowState.Maximized }.Show();
        }
    }
}


