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
    public partial class telaConsultarUsuario : Form
    {
        public telaConsultarUsuario()
        {
            InitializeComponent();
        }

        private void telaConsultarUsuario_Load(object sender, EventArgs e)
        {
            Regarregar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            telaCadastroUser user = new telaCadastroUser();
            if(user.ShowDialog() == DialogResult.OK)
            {
                Regarregar();
            }
            
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Deseja deleatar o(s) usuario(s) selecionados?","REMOVER",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++) 
                    {
                        int ID = int.Parse(dataGridView1.SelectedRows[i].Cells["idUsuario"].Value.ToString());
                        Usuario usuario = new Usuario();
                        if (usuario.Excluir(ID))
                        {
                            dataGridView1.Rows.Remove(dataGridView1.SelectedRows[i]);
                            dataGridView1.DataSource = usuario.Listar();
                        }
                        MessageBox.Show("Usuario(s) deletado(s) com sucesso!");
                    }
                }

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

                Usuario usuario = new Usuario();
                dataGridView1.DataSource = usuario.Listar();


            }


            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int ID = int.Parse(dataGridView1.SelectedRows[0].Cells["idUsuario"].Value.ToString());
                
                telaCadastroUser telaCadastroUser = new telaCadastroUser(ID);
                if (telaCadastroUser.ShowDialog() == DialogResult.OK)
                {
                    Regarregar();

                }
            }
            else
            {
                MessageBox.Show("Selecione apenas um registro!");
            }
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
          
        }
    }
}
