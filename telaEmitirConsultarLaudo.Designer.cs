
namespace projetoPI
{
    partial class telaEmitirConsultarLaudo
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
            this.buttonConsultarLaudo = new System.Windows.Forms.Button();
            this.buttonEmitirLaudo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonVoltarMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConsultarLaudo
            // 
            this.buttonConsultarLaudo.Location = new System.Drawing.Point(88, 239);
            this.buttonConsultarLaudo.Name = "buttonConsultarLaudo";
            this.buttonConsultarLaudo.Size = new System.Drawing.Size(233, 153);
            this.buttonConsultarLaudo.TabIndex = 1;
            this.buttonConsultarLaudo.Text = "Consultar Laudo";
            this.buttonConsultarLaudo.UseVisualStyleBackColor = true;
            // 
            // buttonEmitirLaudo
            // 
            this.buttonEmitirLaudo.Location = new System.Drawing.Point(482, 239);
            this.buttonEmitirLaudo.Name = "buttonEmitirLaudo";
            this.buttonEmitirLaudo.Size = new System.Drawing.Size(233, 153);
            this.buttonEmitirLaudo.TabIndex = 1;
            this.buttonEmitirLaudo.Text = "Emitir Laudo";
            this.buttonEmitirLaudo.UseVisualStyleBackColor = true;
            this.buttonEmitirLaudo.Click += new System.EventHandler(this.buttonEmitirLaudo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projetoPI.Properties.Resources.logoamorzinho;
            this.pictureBox1.Location = new System.Drawing.Point(230, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonVoltarMenu
            // 
            this.buttonVoltarMenu.Location = new System.Drawing.Point(580, 12);
            this.buttonVoltarMenu.Name = "buttonVoltarMenu";
            this.buttonVoltarMenu.Size = new System.Drawing.Size(135, 63);
            this.buttonVoltarMenu.TabIndex = 2;
            this.buttonVoltarMenu.Text = "Voltar";
            this.buttonVoltarMenu.UseVisualStyleBackColor = true;
            this.buttonVoltarMenu.Click += new System.EventHandler(this.buttonVoltarMenu_Click);
            // 
            // telaEmitirConsultarLaudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVoltarMenu);
            this.Controls.Add(this.buttonEmitirLaudo);
            this.Controls.Add(this.buttonConsultarLaudo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "telaEmitirConsultarLaudo";
            this.Text = "Consultar ou Emitir Laudo de Qualidade";
            this.Load += new System.EventHandler(this.telaEmitirConsultarLaudo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonConsultarLaudo;
        private System.Windows.Forms.Button buttonEmitirLaudo;
        private System.Windows.Forms.Button buttonVoltarMenu;
    }
}