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
    public partial class telaCadastrarTeste : Form
    {
        public telaCadastrarTeste()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void telaCadastrarTeste_Load(object sender, EventArgs e)
        {
            try
            {
                classes.Procedimentos procedimentos = new classes.Procedimentos();
                dataGridView1.DataSource = procedimentos.Listar();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                classes.Procedimentos procedimentos = new classes.Procedimentos(textNameTeste.Text, textUnidadeMedida.Text, textEspecMin.Text, textEspecMax.Text) ;
                if(procedimentos.Incluir()==true)               
                {
                    MessageBox.Show("Teste inserido com sucesso!");
                }
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Regarregar();
        }

        private void Regarregar()
        {
            try
            {
                classes.Procedimentos procedimentos = new classes.Procedimentos();
                dataGridView1.DataSource = procedimentos.Listar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void LimparCampos()
        {
            textNameTeste.Clear();
            textUnidadeMedida.Clear();
            textEspecMin.Clear();
            textEspecMax.Clear();
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja deleatar o(s) testes(s) selecionados?", "REMOVER", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        int ID = int.Parse(dataGridView1.SelectedRows[i].Cells["idTeste"].Value.ToString());
                        classes.Procedimentos procedimentos = new classes.Procedimentos();
                        if (procedimentos.Excluir(ID))
                        {
                            dataGridView1.Rows.Remove(dataGridView1.SelectedRows[i]);
                            dataGridView1.DataSource = procedimentos.Listar();
                        }
                        MessageBox.Show("Teste(s) deletado(s) com sucesso!");
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
