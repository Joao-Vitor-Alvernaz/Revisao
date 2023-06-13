namespace Simulado_01_POO_2Bimestre_50Min
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_CPF = new System.Windows.Forms.Label();
            this.label_Senha = new System.Windows.Forms.Label();
            this.label_Confirm = new System.Windows.Forms.Label();
            this.CadastroDeUsuario = new System.Windows.Forms.Label();
            this.mascara_CPF = new System.Windows.Forms.MaskedTextBox();
            this.mascara_Senha = new System.Windows.Forms.MaskedTextBox();
            this.mascara_Confirmar = new System.Windows.Forms.MaskedTextBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(380, 104);
            this.textBox_Name.Multiline = true;
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(195, 20);
            this.textBox_Name.TabIndex = 0;
            this.textBox_Name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(319, 102);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(55, 20);
            this.label_Name.TabIndex = 4;
            this.label_Name.Text = "Nome:";
            this.label_Name.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_CPF
            // 
            this.label_CPF.AutoSize = true;
            this.label_CPF.BackColor = System.Drawing.Color.Transparent;
            this.label_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CPF.Location = new System.Drawing.Point(330, 141);
            this.label_CPF.Name = "label_CPF";
            this.label_CPF.Size = new System.Drawing.Size(44, 20);
            this.label_CPF.TabIndex = 5;
            this.label_CPF.Text = "CPF:";
            // 
            // label_Senha
            // 
            this.label_Senha.AutoSize = true;
            this.label_Senha.BackColor = System.Drawing.Color.Transparent;
            this.label_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Senha.Location = new System.Drawing.Point(314, 179);
            this.label_Senha.Name = "label_Senha";
            this.label_Senha.Size = new System.Drawing.Size(60, 20);
            this.label_Senha.TabIndex = 6;
            this.label_Senha.Text = "Senha:";
            // 
            // label_Confirm
            // 
            this.label_Confirm.AutoSize = true;
            this.label_Confirm.BackColor = System.Drawing.Color.Transparent;
            this.label_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Confirm.Location = new System.Drawing.Point(241, 214);
            this.label_Confirm.Name = "label_Confirm";
            this.label_Confirm.Size = new System.Drawing.Size(133, 20);
            this.label_Confirm.TabIndex = 7;
            this.label_Confirm.Text = "Confirmar Senha:";
            // 
            // CadastroDeUsuario
            // 
            this.CadastroDeUsuario.AutoSize = true;
            this.CadastroDeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.CadastroDeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastroDeUsuario.Location = new System.Drawing.Point(312, 29);
            this.CadastroDeUsuario.Name = "CadastroDeUsuario";
            this.CadastroDeUsuario.Size = new System.Drawing.Size(263, 31);
            this.CadastroDeUsuario.TabIndex = 8;
            this.CadastroDeUsuario.Text = "Cadastro de Usuario";
            // 
            // mascara_CPF
            // 
            this.mascara_CPF.Location = new System.Drawing.Point(380, 141);
            this.mascara_CPF.Mask = "000-000-000,00";
            this.mascara_CPF.Name = "mascara_CPF";
            this.mascara_CPF.Size = new System.Drawing.Size(195, 20);
            this.mascara_CPF.TabIndex = 9;
            // 
            // mascara_Senha
            // 
            this.mascara_Senha.Location = new System.Drawing.Point(380, 181);
            this.mascara_Senha.Name = "mascara_Senha";
            this.mascara_Senha.PasswordChar = '*';
            this.mascara_Senha.Size = new System.Drawing.Size(195, 20);
            this.mascara_Senha.TabIndex = 10;
            // 
            // mascara_Confirmar
            // 
            this.mascara_Confirmar.Location = new System.Drawing.Point(380, 214);
            this.mascara_Confirmar.Name = "mascara_Confirmar";
            this.mascara_Confirmar.PasswordChar = '*';
            this.mascara_Confirmar.Size = new System.Drawing.Size(195, 20);
            this.mascara_Confirmar.TabIndex = 11;
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.Red;
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_Cancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Cancel.Location = new System.Drawing.Point(461, 322);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(102, 38);
            this.button_Cancel.TabIndex = 13;
            this.button_Cancel.Text = "Cancelar";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.Lime;
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.Location = new System.Drawing.Point(358, 322);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(97, 38);
            this.button_Save.TabIndex = 14;
            this.button_Save.Text = "Salvar";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(853, 450);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.mascara_Confirmar);
            this.Controls.Add(this.mascara_Senha);
            this.Controls.Add(this.mascara_CPF);
            this.Controls.Add(this.CadastroDeUsuario);
            this.Controls.Add(this.label_Confirm);
            this.Controls.Add(this.label_Senha);
            this.Controls.Add(this.label_CPF);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.textBox_Name);
            this.Name = "Form1";
            this.Text = "Cadastro_Calculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_CPF;
        private System.Windows.Forms.Label label_Senha;
        private System.Windows.Forms.Label label_Confirm;
        private System.Windows.Forms.Label CadastroDeUsuario;
        private System.Windows.Forms.MaskedTextBox mascara_CPF;
        private System.Windows.Forms.MaskedTextBox mascara_Senha;
        private System.Windows.Forms.MaskedTextBox mascara_Confirmar;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Save;
    }
}

