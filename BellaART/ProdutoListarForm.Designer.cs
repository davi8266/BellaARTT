namespace BellaART
{
    partial class ProdutoListarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdutoListarForm));
            this.filtroTextBox = new System.Windows.Forms.TextBox();
            this.buscarLabel = new System.Windows.Forms.Label();
            this.produtosDataGridView = new System.Windows.Forms.DataGridView();
            this.editarButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.novoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.produtosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // filtroTextBox
            // 
            this.filtroTextBox.Location = new System.Drawing.Point(16, 31);
            this.filtroTextBox.Name = "filtroTextBox";
            this.filtroTextBox.Size = new System.Drawing.Size(221, 20);
            this.filtroTextBox.TabIndex = 0;
            this.filtroTextBox.Tag = "";
            this.filtroTextBox.WordWrap = false;
            this.filtroTextBox.TextChanged += new System.EventHandler(this.filtroTextBox_TextChanged);
            // 
            // buscarLabel
            // 
            this.buscarLabel.AutoSize = true;
            this.buscarLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarLabel.Location = new System.Drawing.Point(12, 9);
            this.buscarLabel.Name = "buscarLabel";
            this.buscarLabel.Size = new System.Drawing.Size(129, 19);
            this.buscarLabel.TabIndex = 1;
            this.buscarLabel.Text = "Buscar Produtos";
            // 
            // produtosDataGridView
            // 
            this.produtosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.produtosDataGridView.BackgroundColor = System.Drawing.Color.MistyRose;
            this.produtosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtosDataGridView.Location = new System.Drawing.Point(16, 57);
            this.produtosDataGridView.MultiSelect = false;
            this.produtosDataGridView.Name = "produtosDataGridView";
            this.produtosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.produtosDataGridView.Size = new System.Drawing.Size(969, 352);
            this.produtosDataGridView.TabIndex = 2;
            this.produtosDataGridView.SelectionChanged += new System.EventHandler(this.produtosDataGridView_SelectionChanged);
            // 
            // editarButton
            // 
            this.editarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editarButton.BackColor = System.Drawing.Color.Goldenrod;
            this.editarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editarButton.Font = new System.Drawing.Font("Humnst777 Blk BT", 9F);
            this.editarButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.editarButton.Location = new System.Drawing.Point(829, 415);
            this.editarButton.Name = "editarButton";
            this.editarButton.Size = new System.Drawing.Size(75, 23);
            this.editarButton.TabIndex = 3;
            this.editarButton.Text = "Editar";
            this.editarButton.UseVisualStyleBackColor = false;
            this.editarButton.Click += new System.EventHandler(this.editarButton_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.excluirButton.BackColor = System.Drawing.Color.Black;
            this.excluirButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.excluirButton.Font = new System.Drawing.Font("Humnst777 Blk BT", 9F);
            this.excluirButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.excluirButton.Location = new System.Drawing.Point(910, 415);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(75, 23);
            this.excluirButton.TabIndex = 4;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = false;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // novoButton
            // 
            this.novoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.novoButton.BackColor = System.Drawing.Color.Red;
            this.novoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.novoButton.Font = new System.Drawing.Font("Humnst777 Blk BT", 9F);
            this.novoButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.novoButton.Location = new System.Drawing.Point(748, 415);
            this.novoButton.Name = "novoButton";
            this.novoButton.Size = new System.Drawing.Size(75, 23);
            this.novoButton.TabIndex = 5;
            this.novoButton.Text = "Novo";
            this.novoButton.UseVisualStyleBackColor = false;
            this.novoButton.Click += new System.EventHandler(this.novoButton_Click);
            // 
            // ProdutoListarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 449);
            this.Controls.Add(this.novoButton);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.editarButton);
            this.Controls.Add(this.produtosDataGridView);
            this.Controls.Add(this.buscarLabel);
            this.Controls.Add(this.filtroTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProdutoListarForm";
            this.ShowIcon = false;
            this.Text = "Listar Produto";
            this.Load += new System.EventHandler(this.ProdutoListarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filtroTextBox;
        private System.Windows.Forms.Label buscarLabel;
        private System.Windows.Forms.DataGridView produtosDataGridView;
        private System.Windows.Forms.Button editarButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button novoButton;
    }
}