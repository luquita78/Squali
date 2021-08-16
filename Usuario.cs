using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using projetoPI.classes;

namespace projetoPI
{
    public class Usuario
    {
        private int id;
        private string nome;
        private string nascimento;
        private string email;
        private string cpf;
        private string rg;
        private string senha;
        private string confirmasenha;

       

        public Usuario(string nome, string nascimento, string email, string cpf, string rg, string senha)
        {
            Nome = nome;
            Nascimento = nascimento;
            Email = email;
            Cpf = cpf;
            Rg = rg;
            Senha = senha;
        }

        public Usuario(int id, string nome, string nascimento, string email, string cpf, string rg, string senha, string confirmasenha)
        {
            Id = id;
            Nome = nome;
            Nascimento = nascimento;
            Email = email;
            Cpf = cpf;
            Rg = rg;
            Senha = senha;
            Confirmasenha = confirmasenha;
        }

        public Usuario(string nome, string nascimento, string email, string cpf, string rg, string senha, string confirmasenha)
        {
            Nome = nome;
            Nascimento = nascimento;
            Email = email;
            Cpf = cpf;
            Rg = rg;
            Senha = senha;
            Confirmasenha = confirmasenha;
        }

        public Usuario(string senha, string confirmasenha)
        {
            Senha = senha;
            Confirmasenha = confirmasenha;
        }

        public Usuario() { }

        public Usuario(int id, string nome, string nascimento, string email, string cpf, string rg, string senha)
        {
            Id = id;
            Nome = nome;
            Nascimento = nascimento;
            Email = email;
            Cpf = cpf;
            Rg = rg;
            Senha = senha;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Nascimento { get => nascimento; set => nascimento = value; }
        public string Email { get => email; set => email = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Confirmasenha { get => confirmasenha; set => confirmasenha = value; }

        public bool Incluir()
        {
            classes.Database db = new classes.Database();

            try
            {
                db.Conectar();

                long Id = db.ExecutarComandoSQL("INSERT INTO tb_usuario VALUES(null,'"+this.Nome+"','"+this.Nascimento+"','"+this.Email+"','"+this.Cpf+"','"+this.Rg+"','"+this.Senha+"')", true);
                return true;
            }
            catch (Exception er)
            {
               throw new Exception("Erro no cadastro de usuário! -ERRO:"+er.Message);
            }
            finally
            {
                db = null;
            }

        }
        public bool Alterar()
        {
            Database db = new Database();
            try
            {
                db.Conectar();

                db.ExecutarComandoSQL("UPDATE tb_usuario SET nome = '" + this.nome + "', nascimento = '" + this.nascimento + "', email = '" + this.email + "', cpf = '" + this.cpf + "', rg = '" + this.rg + "', senha = '"+this.senha+"' WHERE idUsuario = '" + this.id + "'");

                

                return true;
            }
            catch (Exception er)
            {
                throw new Exception("Erro ao alterar Registro! - Erro:" + er.Message);
            }
            finally
            {
                db = null;
            }
        }
        public bool Excluir(int ID)
        {
            Database db = new Database();
            try 
            {
                db.Conectar();

                db.ExecutarComandoSQL("DELETE FROM tb_usuario WHERE idUsuario = '"+ID+"'");

                return true;
            }
            catch (Exception er)
            {
                throw new Exception("Erro ao deletar usuario!"+er.Message);
            }
            finally
            {
                db = null;
            }

        }
        public DataTable Listar()
        {
            Database db = new Database();
            try
            {
                db.Conectar();
                return db.RetDataTable("SELECT *FROM tb_usuario ORDER BY idUsuario ASC");

            }


            catch (Exception er)
            {
                throw new Exception("Erro ao listar! - ERRO:" + er.Message);
            }


        }

        public Usuario getUsuarioPeloID(int ID)
        {
            Database db = new Database();
            try
            {
                db.Conectar();
                DataTable dados_usuario = db.RetDataTable("SELECT *FROM tb_usuario WHERE idUsuario = '" + ID + "'");


                DataRow row = dados_usuario.Rows[0];

                return new Usuario(int.Parse(row["idUsuario"].ToString()), row["nome"].ToString(), row["nascimento"].ToString(), row["email"].ToString(), row["cpf"].ToString(), row["rg"].ToString(), row["senha"].ToString());

            }


            catch (Exception er)
            {
                throw new Exception("Erro ao listar! - ERRO:" + er.Message);
            }
        }



    } 
}
