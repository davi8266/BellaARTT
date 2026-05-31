namespace BellaART
{
    partial class UsuarioListarForm
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
            this.usuariosDataGridView = new System.Windows.Forms.DataGridView();
            this.novoButton = new System.Windows.Forms.Button();
            this.editarButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataGridView)).BeginInit();
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
            this.filtroTextBox.Size = new System.Drawing.Size(180, 20);
            this.filtroTextBox.TabIndex = 1;
            this.filtroTextBox.TextChanged += new System.EventHandler(this.filtroTextBox_TextChanged);
            // 
            // usuariosDataGridView
            // 
            this.usuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuariosDataGridView.Location = new System.Drawing.Point(16, 61);
            this.usuariosDataGridView.MultiSelect = false;
            this.usuariosDataGridView.Name = "usuariosDataGridView";
            this.usuariosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usuariosDataGridView.Size = new System.Drawing.Size(980, 348);
            this.usuariosDataGridView.TabIndex = 2;
            this.usuariosDataGridView.SelectionChanged += new System.EventHandler(this.usuariosDataGridView_SelectionChanged);
            // 
            // novoButton
            // 
            this.novoButton.Location = new System.Drawing.Point(921, 415);
            this.novoButton.Name = "novoButton";
            this.novoButton.Size = new System.Drawing.Size(75, 23);
            this.novoButton.TabIndex = 3;
            this.novoButton.Text = "Novo";
            this.novoButton.UseVisualStyleBackColor = true;
            this.novoButton.Click += new System.EventHandler(this.novoButton_Click);
            // 
            // editarButton
            // 
            this.editarButton.Location = new System.Drawing.Point(840, 415);
            this.editarButton.Name = "editarButton";
            this.editarButton.Size = new System.Drawing.Size(75, 23);
            this.editarButton.TabIndex = 4;
            this.editarButton.Text = "Editar";
            this.editarButton.UseVisualStyleBackColor = true;
            this.editarButton.Click += new System.EventHandler(this.editarButton_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.Location = new System.Drawing.Point(759, 415);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(75, 23);
            this.excluirButton.TabIndex = 5;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // UsuarioListarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 450);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.editarButton);
            this.Controls.Add(this.novoButton);
            this.Controls.Add(this.usuariosDataGridView);
            this.Controls.Add(this.filtroTextBox);
            this.Controls.Add(this.buscarLabel);
            this.Name = "UsuarioListarForm";
            this.ShowIcon = false;
            this.Text = "Listar Usuário";
            this.Load += new System.EventHandler(this.UsuarioListarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label buscarLabel;
        private System.Windows.Forms.TextBox filtroTextBox;
        private System.Windows.Forms.DataGridView usuariosDataGridView;
        private System.Windows.Forms.Button novoButton;
        private System.Windows.Forms.Button editarButton;
        private System.Windows.Forms.Button excluirButton;
    }
}

