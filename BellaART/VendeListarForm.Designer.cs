namespace BellaART
{
    partial class VendaListarForm
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
            this.vendasDataGridView = new System.Windows.Forms.DataGridView();
            this.novoButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.editarButton = new System.Windows.Forms.Button();
            this.clienteLabel = new System.Windows.Forms.Label();
            this.filtroTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lucroDiaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vendasDataGridView
            // 
            this.vendasDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vendasDataGridView.BackgroundColor = System.Drawing.Color.MistyRose;
            this.vendasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendasDataGridView.Location = new System.Drawing.Point(12, 61);
            this.vendasDataGridView.MultiSelect = false;
            this.vendasDataGridView.Name = "vendasDataGridView";
            this.vendasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vendasDataGridView.Size = new System.Drawing.Size(776, 348);
            this.vendasDataGridView.TabIndex = 0;
            this.vendasDataGridView.SelectionChanged += new System.EventHandler(this.vendasDataGridView_SelectionChanged);
            // 
            // novoButton
            // 
            this.novoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.novoButton.BackColor = System.Drawing.Color.Red;
            this.novoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.novoButton.Font = new System.Drawing.Font("Humnst777 Blk BT", 9F);
            this.novoButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.novoButton.Location = new System.Drawing.Point(551, 415);
            this.novoButton.Name = "novoButton";
            this.novoButton.Size = new System.Drawing.Size(75, 23);
            this.novoButton.TabIndex = 11;
            this.novoButton.Text = "Novo";
            this.novoButton.UseVisualStyleBackColor = false;
            this.novoButton.Click += new System.EventHandler(this.novoButton_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.excluirButton.BackColor = System.Drawing.Color.Black;
            this.excluirButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.excluirButton.Font = new System.Drawing.Font("Humnst777 Blk BT", 9F);
            this.excluirButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.excluirButton.Location = new System.Drawing.Point(713, 415);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(75, 23);
            this.excluirButton.TabIndex = 10;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = false;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // editarButton
            // 
            this.editarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editarButton.BackColor = System.Drawing.Color.Goldenrod;
            this.editarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editarButton.Font = new System.Drawing.Font("Humnst777 Blk BT", 9F);
            this.editarButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.editarButton.Location = new System.Drawing.Point(632, 415);
            this.editarButton.Name = "editarButton";
            this.editarButton.Size = new System.Drawing.Size(75, 23);
            this.editarButton.TabIndex = 9;
            this.editarButton.Text = "Editar";
            this.editarButton.UseVisualStyleBackColor = false;
            this.editarButton.Click += new System.EventHandler(this.editarButton_Click);
            // 
            // clienteLabel
            // 
            this.clienteLabel.AutoSize = true;
            this.clienteLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteLabel.Location = new System.Drawing.Point(12, 9);
            this.clienteLabel.Name = "clienteLabel";
            this.clienteLabel.Size = new System.Drawing.Size(76, 23);
            this.clienteLabel.TabIndex = 12;
            this.clienteLabel.Text = "Cliente";
            // 
            // filtroTextBox
            // 
            this.filtroTextBox.Location = new System.Drawing.Point(16, 35);
            this.filtroTextBox.Name = "filtroTextBox";
            this.filtroTextBox.Size = new System.Drawing.Size(192, 20);
            this.filtroTextBox.TabIndex = 13;
            this.filtroTextBox.TextChanged += new System.EventHandler(this.filtroTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Lucro do Dia:";
            // 
            // lucroDiaLabel
            // 
            this.lucroDiaLabel.AutoSize = true;
            this.lucroDiaLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lucroDiaLabel.ForeColor = System.Drawing.Color.Lime;
            this.lucroDiaLabel.Location = new System.Drawing.Point(384, 30);
            this.lucroDiaLabel.Name = "lucroDiaLabel";
            this.lucroDiaLabel.Size = new System.Drawing.Size(75, 23);
            this.lucroDiaLabel.TabIndex = 15;
            this.lucroDiaLabel.Text = "R$ 0,00";
            // 
            // VendaListarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lucroDiaLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filtroTextBox);
            this.Controls.Add(this.clienteLabel);
            this.Controls.Add(this.novoButton);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.editarButton);
            this.Controls.Add(this.vendasDataGridView);
            this.Name = "VendaListarForm";
            this.ShowIcon = false;
            this.Text = "Listar Vendas";
            this.Load += new System.EventHandler(this.VendaListarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView vendasDataGridView;
        private System.Windows.Forms.Button novoButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button editarButton;
        private System.Windows.Forms.Label clienteLabel;
        private System.Windows.Forms.TextBox filtroTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lucroDiaLabel;
    }
}

