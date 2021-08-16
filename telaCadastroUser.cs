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
    public partial class telaCadastroUser : Form
    {
        private bool ehEdicao = false;
        public telaCadastroUser(int ID = 0)
        {
            InitializeComponent();
            if(ID != 0)
            {
                try
                {
                    ehEdicao = true;
                    labelAlterar.Text = "Alterar Registro:";

                    Usuario usuario = new Usuario();
                    Usuario dados = usuario.getUsuarioPeloID(ID);

                    textId.Text = dados.Id.ToString();
                    textNome.Text = dados.Nome;
                    textTimeNascimento.Text = dados.Nascimento;
                    textRG.Text = dados.Rg;
                    textEmail.Text = dados.Email;
                    TextCpf.Text = dados.Cpf;

                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }

            }
            else
            {
                ehEdicao = false;
                labelAlterar.Text = "Cadastro de Alunos - Inclusão";
            }


        }

        private void printPreviewControl5_Click(object sender, EventArgs e)
        {

        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)

        {
            if (textNome.Text != string.Empty && textTimeNascimento.Text != string.Empty && textEmail.Text != string.Empty && TextCpf.Text != string.Empty && textRG.Text != string.Empty && textSenha.Text != string.Empty && textConfirmacaoSenha.Text != string.Empty)
            {
                Usuario usuario1 = new Usuario(textSenha.Text, textConfirmacaoSenha.Text);
                usuario1.Senha = textSenha.Text;
                usuario1.Confirmasenha = textConfirmacaoSenha.Text;

                if (usuario1.Senha == usuario1.Confirmasenha)
                {

                    try
                    {
                        Usuario usuario = new Usuario(textNome.Text, textTimeNascimento.Text, textEmail.Text, TextCpf.Text, textRG.Text, textSenha.Text);
                        if (ehEdicao == true) 
                        {
                            usuario.Id = int.Parse(textId.Text.ToString());
                            if(usuario.Alterar() == true)
                            {
                                MessageBox.Show("Usuario Alterado!");
                            }
                        }
                        else
                        {
                            if (usuario.Incluir() == true)
                            {
                                MessageBox.Show("Usuário cadastrado com sucesso");
                                LimparCampos();
                            }
                        }
                        usuario = null;
                        this.DialogResult = DialogResult.OK;
                    }

                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message);

                    }
                }
                else
                {
                    MessageBox.Show("Senhas diferentes!");
                    LimpaSenha();

                }

            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }

            //if (textNome.Text != String.Empty && textEmail.Text != String.Empty && textRG.Text != String.Empty && dateTimeNascimento.Text != String.Empty && textSenha.Text != String.Empty && textConfirmacaoSenha.Text != String.Empty && TextCpf.Text != String.Empty)
            //    {
            //    Usuario p = new Usuario();
            //    p.Nome = textNome.Text;
            //    p.Nascimento = DateTime.Parse(dateTimeNascimento.Text);
            //    p.Rg = textRG.Text;
            //    //p.Id = int.Parse(textId.Text);
            //    p.Senha = textSenha.Text;
            //    p.Cpf = TextCpf.Text;
            //    p.Email = textEmail.Text;
            //    p.Confirmasenha = textConfirmacaoSenha.Text;


            //    if (p.Senha != p.Confirmasenha)
            //    {
            //        MessageBox.Show("Senhas Diferentes");
            //        LimpaSenha();

            //    }
            //    else
            //    {
            //        if (p.Cadastrar() == true)
            //        {
            //            MessageBox.Show("Cadastro realizado com sucesso!");
            //            LimparCampos();
            //           // this.telaInicial.Show();

            //        }
            //        else
            //        {
            //            MessageBox.Show("Preencha todos os campos!");
            //        }
            //    }
            //}

            
        }
        public void LimpaSenha()
        {
            textConfirmacaoSenha.Clear();
            textSenha.Clear();
        }
        public void LimparCampos()
        {
            textNome.Clear();
            textId.Clear();
            textEmail.Clear();
            textRG.Clear();
            textSenha.Clear();
            textConfirmacaoSenha.Clear();
            TextCpf.Clear();
            
        }


        public void TextCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
           /* this.telaInicial.Show();
            this.Close();*/
        }

        private void telaCadastroUser_Load(object sender, EventArgs e)
        {

        }
        
    }
}
