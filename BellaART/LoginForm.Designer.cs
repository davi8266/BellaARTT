namespace BellaART
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.senhaLabel = new System.Windows.Forms.Label();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.entrarButton = new System.Windows.Forms.Button();
            this.bellaLabel = new System.Windows.Forms.Label();
            this.artLabel = new System.Windows.Forms.Label();
            this.informacoesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.BackColor = System.Drawing.Color.MistyRose;
            this.usuarioLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioLabel.Location = new System.Drawing.Point(106, 137);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(65, 19);
            this.usuarioLabel.TabIndex = 0;
            this.usuarioLabel.Text = "Usuário";
            // 
            // senhaLabel
            // 
            this.senhaLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.senhaLabel.AutoSize = true;
            this.senhaLabel.BackColor = System.Drawing.Color.MistyRose;
            this.senhaLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaLabel.Location = new System.Drawing.Point(106, 207);
            this.senhaLabel.Name = "senhaLabel";
            this.senhaLabel.Size = new System.Drawing.Size(58, 19);
            this.senhaLabel.TabIndex = 1;
            this.senhaLabel.Text = "Senha";
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usuarioTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.usuarioTextBox.Location = new System.Drawing.Point(110, 159);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(193, 20);
            this.usuarioTextBox.TabIndex = 2;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.senhaTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.senhaTextBox.Location = new System.Drawing.Point(110, 229);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.PasswordChar = '*';
            this.senhaTextBox.Size = new System.Drawing.Size(193, 20);
            this.senhaTextBox.TabIndex = 3;
            // 
            // cancelarButton
            // 
            this.cancelarButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelarButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.cancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelarButton.Font = new System.Drawing.Font("Humnst777 Blk BT", 9F);
            this.cancelarButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cancelarButton.Location = new System.Drawing.Point(191, 269);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 23);
            this.cancelarButton.TabIndex = 4;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = false;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // entrarButton
            // 
            this.entrarButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.entrarButton.BackColor = System.Drawing.Color.Red;
            this.entrarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.entrarButton.Font = new System.Drawing.Font("Humnst777 Blk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrarButton.ForeColor = System.Drawing.Color.White;
            this.entrarButton.Location = new System.Drawing.Point(110, 269);
            this.entrarButton.Name = "entrarButton";
            this.entrarButton.Size = new System.Drawing.Size(75, 23);
            this.entrarButton.TabIndex = 5;
            this.entrarButton.Text = "Entrar";
            this.entrarButton.UseVisualStyleBackColor = false;
            this.entrarButton.Click += new System.EventHandler(this.entrarButton_Click);
            // 
            // bellaLabel
            // 
            this.bellaLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bellaLabel.AutoSize = true;
            this.bellaLabel.BackColor = System.Drawing.Color.MistyRose;
            this.bellaLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bellaLabel.ForeColor = System.Drawing.Color.Red;
            this.bellaLabel.Location = new System.Drawing.Point(152, 23);
            this.bellaLabel.Name = "bellaLabel";
            this.bellaLabel.Size = new System.Drawing.Size(84, 36);
            this.bellaLabel.TabIndex = 7;
            this.bellaLabel.Text = "Bella";
            // 
            // artLabel
            // 
            this.artLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.artLabel.AutoSize = true;
            this.artLabel.BackColor = System.Drawing.Color.MistyRose;
            this.artLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artLabel.ForeColor = System.Drawing.Color.Black;
            this.artLabel.Location = new System.Drawing.Point(225, 23);
            this.artLabel.Name = "artLabel";
            this.artLabel.Size = new System.Drawing.Size(65, 36);
            this.artLabel.TabIndex = 8;
            this.artLabel.Text = "ART";
            this.artLabel.Click += new System.EventHandler(this.artLabel_Click);
            // 
            // informacoesLabel
            // 
            this.informacoesLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.informacoesLabel.AutoSize = true;
            this.informacoesLabel.BackColor = System.Drawing.Color.MistyRose;
            this.informacoesLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informacoesLabel.Location = new System.Drawing.Point(106, 74);
            this.informacoesLabel.Name = "informacoesLabel";
            this.informacoesLabel.Size = new System.Drawing.Size(130, 19);
            this.informacoesLabel.TabIndex = 9;
            this.informacoesLabel.Text = "Entrar no painel";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 34);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bem-vindo de volta. Insira suas credenciais para \r\nacessar sua conta.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 324);
            this.panel1.TabIndex = 11;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoPictureBox.BackColor = System.Drawing.Color.MistyRose;
            this.logoPictureBox.Image = global::BellaART.Properties.Resources.logobella1;
            this.logoPictureBox.Location = new System.Drawing.Point(106, 23);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(40, 37);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 6;
            this.logoPictureBox.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 324);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.informacoesLabel);
            this.Controls.Add(this.artLabel);
            this.Controls.Add(this.bellaLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.entrarButton);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(this.senhaLabel);
            this.Controls.Add(this.usuarioLabel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrar";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.Label senhaLabel;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label bellaLabel;
        private System.Windows.Forms.Label artLabel;
        private System.Windows.Forms.Button entrarButton;
        private System.Windows.Forms.Label informacoesLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}