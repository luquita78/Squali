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
    public partial class telaLogin : Form
    {
        
        public telaLogin()
        {
            InitializeComponent();
            
            
        }

        private void telaLogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {

            telaInicial telaInicial = new telaInicial(this);
            telaInicial.Show();
            this.Visible = false;
        }

        private void textUserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonGetOut_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool Logar()
        {
            if (textUserID.Text != String.Empty && textPassword.Text != String.Empty)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Usuário não encontrado!");
                return false;
            }
             
        }
    }
}
