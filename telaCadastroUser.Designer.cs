
namespace projetoPI
{
    partial class telaCadastroUser
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
            this.textNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.TextCpf = new System.Windows.Forms.MaskedTextBox();
            this.textRG = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textConfirmacaoSenha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.labelAlterar = new System.Windows.Forms.Label();
            this.textTimeNascimento = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(238, 179);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(339, 20);
            this.textNome.TabIndex = 0;
            this.textNome.TextChanged += new System.EventHandler(this.textNome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome completo:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(731, 452);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CPF:";
            // 
            // TextCpf
            // 
            this.TextCpf.Location = new System.Drawing.Point(238, 277);
            this.TextCpf.Mask = "000.000.000-00";
            this.TextCpf.Name = "TextCpf";
            this.TextCpf.Size = new System.Drawing.Size(89, 20);
            this.TextCpf.TabIndex = 5;
            this.TextCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.TextCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TextCpf_MaskInputRejected);
            // 
            // textRG
            // 
            this.textRG.Location = new System.Drawing.Point(488, 277);
            this.textRG.Mask = "00.000.000-00";
            this.textRG.Name = "textRG";
            this.textRG.Size = new System.Drawing.Size(89, 20);
            this.textRG.TabIndex = 6;
            this.textRG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textRG.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "RG:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Data de Nascimento:";
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(238, 314);
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(108, 20);
            this.textSenha.TabIndex = 12;
            this.textSenha.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Senha:";
            // 
            // textConfirmacaoSenha
            // 
            this.textConfirmacaoSenha.Location = new System.Drawing.Point(469, 314);
            this.textConfirmacaoSenha.Name = "textConfirmacaoSenha";
            this.textConfirmacaoSenha.Size = new System.Drawing.Size(108, 20);
            this.textConfirmacaoSenha.TabIndex = 14;
            this.textConfirmacaoSenha.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(371, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Confirme a senha:";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(238, 251);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(339, 20);
            this.textEmail.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Email:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projetoPI.Properties.Resources.logoamorzinho;
            this.pictureBox1.Location = new System.Drawing.Point(277, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(459, 358);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(108, 68);
            this.buttonCadastrar.TabIndex = 19;
            this.buttonCadastrar.Text = "GRAVAR";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(238, 358);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(108, 68);
            this.buttonVoltar.TabIndex = 20;
            this.buttonVoltar.Text = "VOLTAR";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "RE:";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(41, 140);
            this.textId.Name = "textId";
            this.textId.ReadOnly = true;
            this.textId.Size = new System.Drawing.Size(89, 20);
            this.textId.TabIndex = 8;
            // 
            // labelAlterar
            // 
            this.labelAlterar.AutoSize = true;
            this.labelAlterar.Font = new System.Drawing.Font("Lucida Sans", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlterar.Location = new System.Drawing.Point(350, 162);
            this.labelAlterar.Name = "labelAlterar";
            this.labelAlterar.Size = new System.Drawing.Size(103, 14);
            this.labelAlterar.TabIndex = 1;
            this.labelAlterar.Text = "Alterar Registro";
            // 
            // textTimeNascimento
            // 
            this.textTimeNascimento.Location = new System.Drawing.Point(238, 214);
            this.textTimeNascimento.Name = "textTimeNascimento";
            this.textTimeNascimento.Size = new System.Drawing.Size(339, 20);
            this.textTimeNascimento.TabIndex = 22;
            // 
            // telaCadastroUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textTimeNascimento);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textConfirmacaoSenha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textRG);
            this.Controls.Add(this.TextCpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.labelAlterar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNome);
            this.Name = "telaCadastroUser";
            this.Text = "telaTestes";
            this.Load += new System.EventHandler(this.telaCadastroUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox TextCpf;
        private System.Windows.Forms.MaskedTextBox textRG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textConfirmacaoSenha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label labelAlterar;
        private System.Windows.Forms.DateTimePicker textTimeNascimento;
    }
}