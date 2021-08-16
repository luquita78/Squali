using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoPI.Resources
{
    public partial class telaConsultaCadastroUsuário : Form
    {
        public telaConsultaCadastroUsuário()
        {
            InitializeComponent();
        }

        private void buttonConsutarUser_Click(object sender, EventArgs e)
        {
            telaLoginGestor loginGestor = new telaLoginGestor();
            loginGestor.Show();
            
        }

        private void telaConsultaCadastroUsuário_Load(object sender, EventArgs e)
        {

        }
    }
}
