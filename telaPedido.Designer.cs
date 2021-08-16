
namespace projetoPI
{
    partial class telaPedido
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textOrdem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textMaquina = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textQuant = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonPedido = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.databaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projetoPI.Properties.Resources.logoamorzinho;
            this.pictureBox1.Location = new System.Drawing.Point(262, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(206, 211);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(68, 20);
            this.textCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código do produto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textOrdem
            // 
            this.textOrdem.Location = new System.Drawing.Point(206, 159);
            this.textOrdem.Name = "textOrdem";
            this.textOrdem.Size = new System.Drawing.Size(367, 20);
            this.textOrdem.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ordem de Produção:";
            // 
            // textCliente
            // 
            this.textCliente.Location = new System.Drawing.Point(206, 185);
            this.textCliente.Name = "textCliente";
            this.textCliente.Size = new System.Drawing.Size(367, 20);
            this.textCliente.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cliente: ";
            // 
            // textMaquina
            // 
            this.textMaquina.FormattingEnabled = true;
            this.textMaquina.Items.AddRange(new object[] {
            "Maquina01",
            "Maquina02",
            "Maquina03",
            "Maquina04"});
            this.textMaquina.Location = new System.Drawing.Point(301, 237);
            this.textMaquina.Name = "textMaquina";
            this.textMaquina.Size = new System.Drawing.Size(144, 21);
            this.textMaquina.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Máquina:";
            // 
            // textQuant
            // 
            this.textQuant.Location = new System.Drawing.Point(423, 211);
            this.textQuant.Name = "textQuant";
            this.textQuant.Size = new System.Drawing.Size(149, 20);
            this.textQuant.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantidade(Kg):";
            // 
            // buttonPedido
            // 
            this.buttonPedido.Location = new System.Drawing.Point(428, 363);
            this.buttonPedido.Name = "buttonPedido";
            this.buttonPedido.Size = new System.Drawing.Size(145, 75);
            this.buttonPedido.TabIndex = 11;
            this.buttonPedido.Text = "Gerar Pedido";
            this.buttonPedido.UseVisualStyleBackColor = true;
            this.buttonPedido.Click += new System.EventHandler(this.buttonPedido_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(205, 363);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(145, 75);
            this.buttonVoltar.TabIndex = 11;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // databaseBindingSource
            // 
            this.databaseBindingSource.DataSource = typeof(projetoPI.classes.Database);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(205, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(368, 62);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // telaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonPedido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textQuant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textMaquina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textOrdem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "telaPedido";
            this.Text = "telaPedido";
            this.Load += new System.EventHandler(this.telaPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textOrdem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox textMaquina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textQuant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonPedido;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.BindingSource databaseBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}