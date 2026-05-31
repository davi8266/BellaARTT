namespace BellaART
{
    partial class ImpostoForm
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
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.percentualNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.percentualLabel = new System.Windows.Forms.Label();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.salvarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.percentualNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(16, 35);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(272, 20);
            this.nomeTextBox.TabIndex = 0;
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeLabel.Location = new System.Drawing.Point(12, 9);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(66, 23);
            this.nomeLabel.TabIndex = 1;
            this.nomeLabel.Text = "Nome";
            // 
            // percentualNumericUpDown
            // 
            this.percentualNumericUpDown.DecimalPlaces = 2;
            this.percentualNumericUpDown.Location = new System.Drawing.Point(16, 102);
            this.percentualNumericUpDown.Name = "percentualNumericUpDown";
            this.percentualNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.percentualNumericUpDown.TabIndex = 2;
            // 
            // percentualLabel
            // 
            this.percentualLabel.AutoSize = true;
            this.percentualLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentualLabel.Location = new System.Drawing.Point(12, 76);
            this.percentualLabel.Name = "percentualLabel";
            this.percentualLabel.Size = new System.Drawing.Size(165, 23);
            this.percentualLabel.TabIndex = 3;
            this.percentualLabel.Text = "Percentual em %";
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ativoCheckBox.AutoSize = true;
            this.ativoCheckBox.Location = new System.Drawing.Point(12, 220);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(50, 17);
            this.ativoCheckBox.TabIndex = 4;
            this.ativoCheckBox.Text = "Ativo";
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // cancelarButton
            // 
            this.cancelarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelarButton.BackColor = System.Drawing.Color.Black;
            this.cancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelarButton.Font = new System.Drawing.Font("Humnst777 Blk BT", 9F);
            this.cancelarButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelarButton.Location = new System.Drawing.Point(144, 216);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 23);
            this.cancelarButton.TabIndex = 18;
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
            this.salvarButton.Location = new System.Drawing.Point(225, 216);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(75, 23);
            this.salvarButton.TabIndex = 17;
            this.salvarButton.Text = "Salvar";
            this.salvarButton.UseVisualStyleBackColor = false;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // ImpostoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 251);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.ativoCheckBox);
            this.Controls.Add(this.percentualLabel);
            this.Controls.Add(this.percentualNumericUpDown);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Name = "ImpostoForm";
            this.ShowIcon = false;
            this.Text = "Editar";
            this.Load += new System.EventHandler(this.ImpostoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.percentualNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.NumericUpDown percentualNumericUpDown;
        private System.Windows.Forms.Label percentualLabel;
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button salvarButton;
    }
}
