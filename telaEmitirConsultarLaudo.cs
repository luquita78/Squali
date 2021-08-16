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
    public partial class telaEmitirConsultarLaudo : Form
    {
        private telaInicial ini;
        public telaEmitirConsultarLaudo(telaInicial ini)
        {
            InitializeComponent();
            this.ini = ini;
        }

        private void buttonEmitirLaudo_Click(object sender, EventArgs e)
        {
            telaEmitirLaudo n = new telaEmitirLaudo();
            n.Show();
            this.Visible = false;
        }

        private void buttonVoltarMenu_Click(object sender, EventArgs e)
        {
            ini.Show();
            this.Close();
        }

        private void telaEmitirConsultarLaudo_Load(object sender, EventArgs e)
        {

        }
    }
}
