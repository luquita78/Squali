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
    public partial class telaEmitirLaudo : Form
    {
        private telaEmitirConsultarLaudo consultarLaudo;
        public telaEmitirLaudo()
        {
            InitializeComponent();
            
        }

        private void telaEmitirLaudo_Load(object sender, EventArgs e)
        {

        }

        private void buttonVoltarMenu_Click(object sender, EventArgs e)
        {
            this.consultarLaudo.Show();
            this.Close();
        }
    }
}
