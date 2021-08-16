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
    public partial class telaInicial : Form
    {
      private telaLogin login;
      


        public telaInicial(telaLogin login)
        {
            InitializeComponent();
            this.login = login;
          
        }

       

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            telaConsultarUsuario consultarCadastrarUsuário = new telaConsultarUsuario();
            consultarCadastrarUsuário.Show();

        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Close();
            login.Close();
            
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            telaLancarTestes lancarTestes = new telaLancarTestes();
            lancarTestes.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //link para cadastrar/consultar produtos produtos
        {
                               
            
        }

        private void pedidoLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            telaPedido n = new telaPedido();
            n.Show();
            
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//emitir/consultar laudos
        {
            telaEmitirConsultarLaudo ecl = new telaEmitirConsultarLaudo(this);
            ecl.Show();
            this.Visible = false;
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            telaCadastrarTeste cadastrarTeste = new telaCadastrarTeste();  //Instância
            cadastrarTeste.Show();//Abrindo outra tela 
        }

        private void linkproduto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            telaCadastroProduto consultarProduto = new telaCadastroProduto();
            consultarProduto.Show();
        }
    }
}
