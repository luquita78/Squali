
namespace projetoPI
{
    partial class telaConsultarCadastrarUsuário
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
            this.buttonConsultarUser = new System.Windows.Forms.Button();
            this.buttonCadastrarUser = new System.Windows.Forms.Button();
            this.buttonVoltarMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projetoPI.Properties.Resources.logoamorzinho;
            this.pictureBox1.Location = new System.Drawing.Point(253, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonConsultarUser
            // 
            this.buttonConsultarUser.Location = new System.Drawing.Point(52, 236);
            this.buttonConsultarUser.Name = "buttonConsultarUser";
            this.buttonConsultarUser.Size = new System.Drawing.Size(270, 177);
            this.buttonConsultarUser.TabIndex = 1;
            this.buttonConsultarUser.Text = "Consultar Usuários";
            this.buttonConsultarUser.UseVisualStyleBackColor = true;
            this.buttonConsultarUser.Click += new System.EventHandler(this.buttonConsultarUser_Click);
            // 
            // buttonCadastrarUser
            // 
            this.buttonCadastrarUser.Location = new System.Drawing.Point(489, 236);
            this.buttonCadastrarUser.Name = "buttonCadastrarUser";
            this.buttonCadastrarUser.Size = new System.Drawing.Size(270, 177);
            this.buttonCadastrarUser.TabIndex = 1;
            this.buttonCadastrarUser.Text = "Cadastrar Usuário";
            this.buttonCadastrarUser.UseVisualStyleBackColor = true;
            this.buttonCadastrarUser.Click += new System.EventHandler(this.buttonCadastrarUser_Click);
            // 
            // buttonVoltarMenu
            // 
            this.buttonVoltarMenu.Location = new System.Drawing.Point(620, 12);
            this.buttonVoltarMenu.Name = "buttonVoltarMenu";
            this.buttonVoltarMenu.Size = new System.Drawing.Size(139, 70);
            this.buttonVoltarMenu.TabIndex = 2;
            this.buttonVoltarMenu.Text = "Voltar";
            this.buttonVoltarMenu.UseVisualStyleBackColor = true;
            this.buttonVoltarMenu.Click += new System.EventHandler(this.buttonVoltarMenu_Click);
            // 
            // telaConsultarCadastrarUsuário
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVoltarMenu);
            this.Controls.Add(this.buttonCadastrarUser);
            this.Controls.Add(this.buttonConsultarUser);
            this.Controls.Add(this.pictureBox1);
            this.Name = "telaConsultarCadastrarUsuário";
            this.Text = "telaConsultarCadastrarUsuário";
            this.Load += new System.EventHandler(this.telaConsultarCadastrarUsuário_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonConsultarUser;
        private System.Windows.Forms.Button buttonCadastrarUser;
        private System.Windows.Forms.Button buttonVoltarMenu;
    }
}