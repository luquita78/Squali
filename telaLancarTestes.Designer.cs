
namespace projetoPI
{
    partial class telaLancarTestes
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
            this.textCaq = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textOrdemProdução = new System.Windows.Forms.TextBox();
            this.textMaquina = new System.Windows.Forms.TextBox();
            this.textCodProduto = new System.Windows.Forms.TextBox();
            this.textData = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnConluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textCaq
            // 
            this.textCaq.Location = new System.Drawing.Point(60, 139);
            this.textCaq.Name = "textCaq";
            this.textCaq.Size = new System.Drawing.Size(100, 20);
            this.textCaq.TabIndex = 0;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(166, 139);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 20);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CAQ:";
            // 
            // textOrdemProdução
            // 
            this.textOrdemProdução.Location = new System.Drawing.Point(395, 18);
            this.textOrdemProdução.Name = "textOrdemProdução";
            this.textOrdemProdução.ReadOnly = true;
            this.textOrdemProdução.Size = new System.Drawing.Size(130, 20);
            this.textOrdemProdução.TabIndex = 3;
            // 
            // textMaquina
            // 
            this.textMaquina.Location = new System.Drawing.Point(658, 65);
            this.textMaquina.Name = "textMaquina";
            this.textMaquina.ReadOnly = true;
            this.textMaquina.Size = new System.Drawing.Size(130, 20);
            this.textMaquina.TabIndex = 4;
            // 
            // textCodProduto
            // 
            this.textCodProduto.Location = new System.Drawing.Point(395, 65);
            this.textCodProduto.Name = "textCodProduto";
            this.textCodProduto.ReadOnly = true;
            this.textCodProduto.Size = new System.Drawing.Size(130, 20);
            this.textCodProduto.TabIndex = 4;
            // 
            // textData
            // 
            this.textData.Location = new System.Drawing.Point(658, 16);
            this.textData.Name = "textData";
            this.textData.ReadOnly = true;
            this.textData.Size = new System.Drawing.Size(130, 20);
            this.textData.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projetoPI.Properties.Resources.logoamorzinho;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(765, 223);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ordem de Produção:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Código do Produto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(604, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Máquina: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(617, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Data:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(504, 394);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(97, 44);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar:";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnConluir
            // 
            this.btnConluir.Location = new System.Drawing.Point(658, 394);
            this.btnConluir.Name = "btnConluir";
            this.btnConluir.Size = new System.Drawing.Size(97, 44);
            this.btnConluir.TabIndex = 8;
            this.btnConluir.Text = "Concluir:";
            this.btnConluir.UseVisualStyleBackColor = true;
            // 
            // telaLancarTestes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConluir);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textCodProduto);
            this.Controls.Add(this.textMaquina);
            this.Controls.Add(this.textData);
            this.Controls.Add(this.textOrdemProdução);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.textCaq);
            this.Name = "telaLancarTestes";
            this.Text = "telaLancarTestes";
            this.Load += new System.EventHandler(this.telaLancarTestes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCaq;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textOrdemProdução;
        private System.Windows.Forms.TextBox textMaquina;
        private System.Windows.Forms.TextBox textCodProduto;
        private System.Windows.Forms.TextBox textData;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnConluir;
    }
}