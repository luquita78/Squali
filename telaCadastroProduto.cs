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
    public partial class telaCadastroProduto : Form
    {
       
        public telaCadastroProduto()
        {
            InitializeComponent();
           
            
            
        }

      

        private void TelaCadastroProduto_Load(object sender, EventArgs e)
        {
            Regarregar();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {

            
        }

        private void buttonGerarCod_Click(object sender, EventArgs e)
        {
            try
            {
                classes.Produto produto = new classes.Produto(textDescricao.Text,textTipo.Text);
                if(produto.Incluir() == true)
                {
                    MessageBox.Show("Produto Cadastrado com sucesso!");
                }
                Regarregar();
            }
           
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void Regarregar()
        {
            try
            {
                classes.Produto produto = new classes.Produto();
                dataGridView1.DataSource = produto.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            telaCadastrarTeste cadastrarTeste = new telaCadastrarTeste();
            cadastrarTeste.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja deleatar o(s) testes(s) selecionados?", "REMOVER", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        int ID = int.Parse(dataGridView1.SelectedRows[i].Cells["idProduto"].Value.ToString());
                        classes.Produto produto = new classes.Produto();
                        if (produto.Excluir(ID))
                        {
                            dataGridView1.Rows.Remove(dataGridView1.SelectedRows[i]);
                            dataGridView1.DataSource = produto.Listar();
                        }
                        MessageBox.Show("Produto(s) deletado(s) com sucesso!");
                    }
                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
