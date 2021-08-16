
namespace projetoPI.Resources
{
    partial class telaConsultaCadastroUsuário
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonConsutarUser = new System.Windows.Forms.Button();
            this.buttonCadastraUser = new System.Windows.Forms.Button();
            this.buttonVoltarMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projetoPI.Properties.Resources.logoamorzinho;
            this.pictureBox1.Location = new System.Drawing.Point(217, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonConsutarUser
            // 
            this.buttonConsutarUser.Location = new System.Drawing.Point(47, 259);
            this.buttonConsutarUser.Name = "buttonConsutarUser";
            this.buttonConsutarUser.Size = new System.Drawing.Size(310, 158);
            this.buttonConsutarUser.TabIndex = 1;
            this.buttonConsutarUser.Text = "Consultar Usuários";
            this.buttonConsutarUser.UseVisualStyleBackColor = true;
            this.buttonConsutarUser.Click += new System.EventHandler(this.buttonConsutarUser_Click);
            // 
            // buttonCadastraUser
            // 
            this.buttonCadastraUser.Location = new System.Drawing.Point(450, 259);
            this.buttonCadastraUser.Name = "buttonCadastraUser";
            this.buttonCadastraUser.Size = new System.Drawing.Size(310, 158);
            this.buttonCadastraUser.TabIndex = 1;
            this.buttonCadastraUser.Text = "Cadastrar Usuário";
            this.buttonCadastraUser.UseVisualStyleBackColor = true;
            // 
            // buttonVoltarMenu
            // 
            this.buttonVoltarMenu.Location = new System.Drawing.Point(643, 12);
            this.buttonVoltarMenu.Name = "buttonVoltarMenu";
            this.buttonVoltarMenu.Size = new System.Drawing.Size(117, 55);
            this.buttonVoltarMenu.TabIndex = 2;
            this.buttonVoltarMenu.Text = "Voltar";
            this.buttonVoltarMenu.UseVisualStyleBackColor = true;
            // 
            // telaConsultaCadastroUsuário
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVoltarMenu);
            this.Controls.Add(this.buttonCadastraUser);
            this.Controls.Add(this.buttonConsutarUser);
            this.Controls.Add(this.pictureBox1);
            this.Name = "telaConsultaCadastroUsuário";
            this.Text = "telaConsultaCadastroUsuário";
            this.Load += new System.EventHandler(this.telaConsultaCadastroUsuário_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonConsutarUser;
        private System.Windows.Forms.Button buttonCadastraUser;
        private System.Windows.Forms.Button buttonVoltarMenu;
    }
}