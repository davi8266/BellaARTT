namespace BellaART
{
    partial class ClienteListarForm
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
            this.buscarLabel = new System.Windows.Forms.Label();
            this.filtroTextBox = new System.Windows.Forms.TextBox();
            this.clientesDataGridView = new System.Windows.Forms.DataGridView();
            this.novoButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.editarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buscarLabel
            // 
            this.buscarLabel.AutoSize = true;
            this.buscarLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarLabel.Location = new System.Drawing.Point(12, 9);
            this.buscarLabel.Name = "buscarLabel";
            this.buscarLabel.Size = new System.Drawing.Size(71, 23);
            this.buscarLabel.TabIndex = 0;
            this.buscarLabel.Text = "Buscar";
            // 
            // filtroTextBox
            // 
            this.filtroTextBox.Location = new System.Drawing.Point(16, 35);
            this.filtroTextBox.Name = "filtroTextBox";
            this.filtroTextBox.Size = new System.Drawing.Size(245, 20);
            this.filtroTextBox.TabIndex = 1;
            this.filtroTextBox.TextChanged += new System.EventHandler(this.filtroTextBox_TextChanged);
            // 
            // clientesDataGridView
            // 
            this.clientesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientesDataGridView.BackgroundColor = System.Drawing.Color.MistyRose;
            this.clientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientesDataGridView.Location = new System.Drawing.Point(16, 61);
            this.clientesDataGridView.MultiSelect = false;
            this.clientesDataGridView.Name = "clientesDataGridView";
            this.clientesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientesDataGridView.Size = new System.Drawing.Size(772, 348);
            this.clientesDataGridView.TabIndex = 2;
            this.clientesDataGridView.SelectionChanged += new System.EventHandler(this.clientesDataGridView_SelectionChanged);
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
            // ClienteListarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.novoButton);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.editarButton);
            this.Controls.Add(this.clientesDataGridView);
            this.Controls.Add(this.filtroTextBox);
            this.Controls.Add(this.buscarLabel);
            this.Name = "ClienteListarForm";
            this.ShowIcon = false;
            this.Text = "Listar Cliente";
            this.Load += new System.EventHandler(this.ClienteListarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label buscarLabel;
        private System.Windows.Forms.TextBox filtroTextBox;
        private System.Windows.Forms.DataGridView clientesDataGridView;
        private System.Windows.Forms.Button novoButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button editarButton;
    }
}

