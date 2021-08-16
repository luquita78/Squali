
namespace projetoPI
{
    partial class telaConsultarTeste
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textCodigoProduto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.Testes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidade_de_medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especificacao_minima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especificacao_maxima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Testes,
            this.Unidade_de_medida,
            this.Especificacao_minima,
            this.Especificacao_maxima});
            this.dataGridView1.Location = new System.Drawing.Point(164, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 260);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textCodigoProduto
            // 
            this.textCodigoProduto.Location = new System.Drawing.Point(205, 124);
            this.textCodigoProduto.Name = "textCodigoProduto";
            this.textCodigoProduto.Size = new System.Drawing.Size(307, 20);
            this.textCodigoProduto.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(521, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código do Produto:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projetoPI.Properties.Resources.logoamorzinho;
            this.pictureBox1.Location = new System.Drawing.Point(283, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(569, 12);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(167, 65);
            this.buttonVoltar.TabIndex = 5;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            // 
            // Testes
            // 
            this.Testes.HeaderText = "Teste";
            this.Testes.Name = "Testes";
            // 
            // Unidade_de_medida
            // 
            this.Unidade_de_medida.HeaderText = "Unidade de medida";
            this.Unidade_de_medida.Name = "Unidade_de_medida";
            // 
            // Especificacao_minima
            // 
            this.Especificacao_minima.HeaderText = "Especificação Mínima";
            this.Especificacao_minima.Name = "Especificacao_minima";
            // 
            // Especificacao_maxima
            // 
            this.Especificacao_maxima.HeaderText = "Especificação Máxima";
            this.Especificacao_maxima.Name = "Especificacao_maxima";
            // 
            // telaConsultarTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textCodigoProduto);
            this.Controls.Add(this.dataGridView1);
            this.Name = "telaConsultarTeste";
            this.Text = "telaConsultarTeste";
            this.Load += new System.EventHandler(this.telaConsultarTeste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textCodigoProduto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Testes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidade_de_medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especificacao_minima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especificacao_maxima;
        private System.Windows.Forms.Button buttonVoltar;
    }
}