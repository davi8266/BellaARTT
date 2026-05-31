namespace BellaART
{
    partial class VendaForm
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
            this.clienteLabel = new System.Windows.Forms.Label();
            this.clienteComboBox = new System.Windows.Forms.ComboBox();
            this.impostoComboBox = new System.Windows.Forms.ComboBox();
            this.impostoLabel = new System.Windows.Forms.Label();
            this.produtoComboBox = new System.Windows.Forms.ComboBox();
            this.produtoLabel = new System.Windows.Forms.Label();
            this.quantidadeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.quantidadeLabel = new System.Windows.Forms.Label();
            this.adicionarButton = new System.Windows.Forms.Button();
            this.itensDataGridView = new System.Windows.Forms.DataGridView();
            this.removerButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.impostoValorLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.salvarButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.quantidadeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clienteLabel
            // 
            this.clienteLabel.AutoSize = true;
            this.clienteLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.clienteLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clienteLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteLabel.Location = new System.Drawing.Point(3, 0);
            this.clienteLabel.Name = "clienteLabel";
            this.clienteLabel.Size = new System.Drawing.Size(76, 23);
            this.clienteLabel.TabIndex = 1;
            this.clienteLabel.Text = "Cliente";
            // 
            // clienteComboBox
            // 
            this.clienteComboBox.FormattingEnabled = true;
            this.clienteComboBox.Location = new System.Drawing.Point(7, 26);
            this.clienteComboBox.Name = "clienteComboBox";
            this.clienteComboBox.Size = new System.Drawing.Size(205, 21);
            this.clienteComboBox.TabIndex = 2;
            // 
            // impostoComboBox
            // 
            this.impostoComboBox.FormattingEnabled = true;
            this.impostoComboBox.Location = new System.Drawing.Point(252, 26);
            this.impostoComboBox.Name = "impostoComboBox";
            this.impostoComboBox.Size = new System.Drawing.Size(205, 21);
            this.impostoComboBox.TabIndex = 4;
            // 
            // impostoLabel
            // 
            this.impostoLabel.AutoSize = true;
            this.impostoLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.impostoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.impostoLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impostoLabel.Location = new System.Drawing.Point(248, 0);
            this.impostoLabel.Name = "impostoLabel";
            this.impostoLabel.Size = new System.Drawing.Size(84, 23);
            this.impostoLabel.TabIndex = 3;
            this.impostoLabel.Text = "Imposto";
            // 
            // produtoComboBox
            // 
            this.produtoComboBox.FormattingEnabled = true;
            this.produtoComboBox.Location = new System.Drawing.Point(480, 26);
            this.produtoComboBox.Name = "produtoComboBox";
            this.produtoComboBox.Size = new System.Drawing.Size(205, 21);
            this.produtoComboBox.TabIndex = 6;
            // 
            // produtoLabel
            // 
            this.produtoLabel.AutoSize = true;
            this.produtoLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.produtoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.produtoLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produtoLabel.Location = new System.Drawing.Point(476, 0);
            this.produtoLabel.Name = "produtoLabel";
            this.produtoLabel.Size = new System.Drawing.Size(81, 23);
            this.produtoLabel.TabIndex = 5;
            this.produtoLabel.Text = "Produto";
            // 
            // quantidadeNumericUpDown
            // 
            this.quantidadeNumericUpDown.Location = new System.Drawing.Point(16, 116);
            this.quantidadeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantidadeNumericUpDown.Name = "quantidadeNumericUpDown";
            this.quantidadeNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.quantidadeNumericUpDown.TabIndex = 7;
            this.quantidadeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // quantidadeLabel
            // 
            this.quantidadeLabel.AutoSize = true;
            this.quantidadeLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.quantidadeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.quantidadeLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidadeLabel.Location = new System.Drawing.Point(12, 90);
            this.quantidadeLabel.Name = "quantidadeLabel";
            this.quantidadeLabel.Size = new System.Drawing.Size(123, 23);
            this.quantidadeLabel.TabIndex = 8;
            this.quantidadeLabel.Text = "Quantidade";
            // 
            // adicionarButton
            // 
            this.adicionarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.adicionarButton.BackColor = System.Drawing.Color.Red;
            this.adicionarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adicionarButton.Font = new System.Drawing.Font("Humnst777 Blk BT", 9F);
            this.adicionarButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.adicionarButton.Location = new System.Drawing.Point(617, 153);
            this.adicionarButton.Name = "adicionarButton";
            this.adicionarButton.Size = new System.Drawing.Size(75, 23);
            this.adicionarButton.TabIndex = 12;
            this.adicionarButton.Text = "Adicionar";
            this.adicionarButton.UseVisualStyleBackColor = false;
            this.adicionarButton.Click += new System.EventHandler(this.adicionarButton_Click);
            // 
            // itensDataGridView
            // 
            this.itensDataGridView.BackgroundColor = System.Drawing.Color.MistyRose;
            this.itensDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itensDataGridView.Location = new System.Drawing.Point(12, 213);
            this.itensDataGridView.Name = "itensDataGridView";
            this.itensDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itensDataGridView.Size = new System.Drawing.Size(776, 267);
            this.itensDataGridView.TabIndex = 13;
            // 
            // removerButton
            // 
            this.removerButton.BackColor = System.Drawing.Color.Red;
            this.removerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removerButton.Font = new System.Drawing.Font("Humnst777 Blk BT", 9F);
            this.removerButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.removerButton.Location = new System.Drawing.Point(661, 486);
            this.removerButton.Name = "removerButton";
            this.removerButton.Size = new System.Drawing.Size(127, 23);
            this.removerButton.TabIndex = 14;
            this.removerButton.Text = "Remover item";
            this.removerButton.UseVisualStyleBackColor = false;
            this.removerButton.Click += new System.EventHandler(this.removerButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.Location = new System.Drawing.Point(12, 486);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(161, 23);
            this.subtotalLabel.TabIndex = 15;
            this.subtotalLabel.Text = "Subtotal: R$ 0,00";
            // 
            // impostoValorLabel
            // 
            this.impostoValorLabel.AutoSize = true;
            this.impostoValorLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impostoValorLabel.Location = new System.Drawing.Point(182, 486);
            this.impostoValorLabel.Name = "impostoValorLabel";
            this.impostoValorLabel.Size = new System.Drawing.Size(159, 23);
            this.impostoValorLabel.TabIndex = 16;
            this.impostoValorLabel.Text = "Imposto: R$ 0,00";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(356, 486);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(129, 23);
            this.totalLabel.TabIndex = 17;
            this.totalLabel.Text = "Total: R$ 0,00";
            // 
            // cancelarButton
            // 
            this.cancelarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelarButton.BackColor = System.Drawing.Color.Black;
            this.cancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelarButton.Font = new System.Drawing.Font("Humnst777 Blk BT", 9F);
            this.cancelarButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelarButton.Location = new System.Drawing.Point(632, 568);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 23);
            this.cancelarButton.TabIndex = 19;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = false;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // salvarButton
            // 
            this.salvarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.salvarButton.BackColor = System.Drawing.Color.Red;
            this.salvarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.salvarButton.Font = new System.Drawing.Font("Humnst777 Blk BT", 9F);
            this.salvarButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.salvarButton.Location = new System.Drawing.Point(713, 568);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(75, 23);
            this.salvarButton.TabIndex = 18;
            this.salvarButton.Text = "Salvar";
            this.salvarButton.UseVisualStyleBackColor = false;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.quantidadeLabel);
            this.panel1.Controls.Add(this.adicionarButton);
            this.panel1.Controls.Add(this.quantidadeNumericUpDown);
            this.panel1.Controls.Add(this.clienteLabel);
            this.panel1.Controls.Add(this.clienteComboBox);
            this.panel1.Controls.Add(this.impostoLabel);
            this.panel1.Controls.Add(this.impostoComboBox);
            this.panel1.Controls.Add(this.produtoLabel);
            this.panel1.Controls.Add(this.produtoComboBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 179);
            this.panel1.TabIndex = 20;
            // 
            // VendaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 603);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.impostoValorLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.removerButton);
            this.Controls.Add(this.itensDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "VendaForm";
            this.ShowIcon = false;
            this.Text = "Editar";
            this.Load += new System.EventHandler(this.VendaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantidadeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clienteLabel;
        private System.Windows.Forms.ComboBox clienteComboBox;
        private System.Windows.Forms.ComboBox impostoComboBox;
        private System.Windows.Forms.Label impostoLabel;
        private System.Windows.Forms.ComboBox produtoComboBox;
        private System.Windows.Forms.Label produtoLabel;
        private System.Windows.Forms.NumericUpDown quantidadeNumericUpDown;
        private System.Windows.Forms.Label quantidadeLabel;
        private System.Windows.Forms.Button adicionarButton;
        private System.Windows.Forms.DataGridView itensDataGridView;
        private System.Windows.Forms.Button removerButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label impostoValorLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.Panel panel1;
    }
}
