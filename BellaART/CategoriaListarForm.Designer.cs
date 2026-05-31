namespace BellaART
{
    partial class CategoriaListarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriaListarForm));
            this.buscarLabel = new System.Windows.Forms.Label();
            this.filtroTextBox = new System.Windows.Forms.TextBox();
            this.categoriasDataGridView = new System.Windows.Forms.DataGridView();
            this.novoButton = new System.Windows.Forms.Button();
            this.editarButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buscarLabel
            // 
            this.buscarLabel.AutoSize = true;
            this.buscarLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarLabel.Location = new System.Drawing.Point(12, 9);
            this.buscarLabel.Name = "buscarLabel";
            this.buscarLabel.Size = new System.Drawing.Size(76, 23);
            this.buscarLabel.TabIndex = 0;
            this.buscarLabel.Text = "Buscar:";
            // 
            // filtroTextBox
            // 
            this.filtroTextBox.Location = new System.Drawing.Point(16, 35);
            this.filtroTextBox.Name = "filtroTextBox";
            this.filtroTextBox.Size = new System.Drawing.Size(261, 20);
            this.filtroTextBox.TabIndex = 1;
            this.filtroTextBox.TextChanged += new System.EventHandler(this.filtroTextBox_TextChanged);
            // 
            // categoriasDataGridView
            // 
            this.categoriasDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoriasDataGridView.BackgroundColor = System.Drawing.Color.MistyRose;
            this.categoriasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriasDataGridView.Location = new System.Drawing.Point(16, 66);
            this.categoriasDataGridView.MultiSelect = false;
            this.categoriasDataGridView.Name = "categoriasDataGridView";
            this.categoriasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categoriasDataGridView.Size = new System.Drawing.Size(980, 308);
            this.categoriasDataGridView.TabIndex = 2;
            this.categoriasDataGridView.SelectionChanged += new System.EventHandler(this.categoriasDataGridView_SelectionChanged);
            // 
            // novoButton
            // 
            this.novoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.novoButton.BackColor = System.Drawing.Color.Red;
            this.novoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.novoButton.Font = new System.Drawing.Font("Humnst777 Blk BT", 9F);
            this.novoButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.novoButton.Location = new System.Drawing.Point(717, 380);
            this.novoButton.Name = "novoButton";
            this.novoButton.Size = new System.Drawing.Size(89, 23);
            this.novoButton.TabIndex = 3;
            this.novoButton.Text = "Novo";
            this.novoButton.UseVisualStyleBackColor = false;
            this.novoButton.Click += new System.EventHandler(this.novoButton_Click);
            // 
            // editarButton
            // 
            this.editarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editarButton.BackColor = System.Drawing.Color.Goldenrod;
            this.editarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editarButton.Font = new System.Drawing.Font("Humnst777 Blk BT", 9F);
            this.editarButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.editarButton.Location = new System.Drawing.Point(812, 380);
            this.editarButton.Name = "editarButton";
            this.editarButton.Size = new System.Drawing.Size(89, 23);
            this.editarButton.TabIndex = 4;
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
            this.excluirButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.excluirButton.Location = new System.Drawing.Point(907, 380);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(89, 23);
            this.excluirButton.TabIndex = 5;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = false;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // CategoriaListarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 415);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.editarButton);
            this.Controls.Add(this.novoButton);
            this.Controls.Add(this.categoriasDataGridView);
            this.Controls.Add(this.filtroTextBox);
            this.Controls.Add(this.buscarLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CategoriaListarForm";
            this.ShowIcon = false;
            this.Text = "Listar Categoria";
            this.Load += new System.EventHandler(this.CategoriaListarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label buscarLabel;
        private System.Windows.Forms.TextBox filtroTextBox;
        private System.Windows.Forms.DataGridView categoriasDataGridView;
        private System.Windows.Forms.Button novoButton;
        private System.Windows.Forms.Button editarButton;
        private System.Windows.Forms.Button excluirButton;
    }
}

