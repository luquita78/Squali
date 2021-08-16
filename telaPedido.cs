using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoPI
{
    public partial class telaPedido : Form
    {
       
        public telaPedido()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void telaPedido_Load(object sender, EventArgs e)
        {
            classes.Produto produto = new classes.Produto();
            dataGridView1.DataSource = produto.Listar();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonPedido_Click(object sender, EventArgs e)
        {        
            try
            {
                classes.Pedido pedido = new classes.Pedido(textCliente.Text,double.Parse(textQuant.Text.ToString()),textMaquina.Text,textOrdem.Text,int.Parse(textCodigo.Text.ToString()));
                if (pedido.Incluir() == true)
                {
                    MessageBox.Show("Pedido realizado com sucesso!");
                }
                LimparCampos();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

       private void LimparCampos()
        {
            textCodigo.Clear();
            textCliente.Clear();
            textOrdem.Clear();
            textQuant.Clear();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
