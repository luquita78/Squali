using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoPI.classes
{
    public class Produto
    {
        private int codigo_produto;
        private string descricao;
        private string tipo;
        private Procedimentos teste;



      

        public Produto(int codigo_produto, string descricao)
        {
            Codigo_produto = codigo_produto;
            Descricao = descricao;
            
        }


        public Produto(string descricao)
        {
            this.descricao = descricao;
        }
        public Produto() { }

        public Produto(int codigo_produto, string descricao, Procedimentos teste)
        {
            Codigo_produto = codigo_produto;
            Descricao = descricao;
            Teste = teste;
        }

        public Produto(string descricao, Procedimentos teste)
        {
            Descricao = descricao;
            Teste = teste;
        }

        public Produto( string descricao, string tipo)
        {
           
            Descricao = descricao;
            Tipo = tipo;
        }

        public int Codigo_produto { get => codigo_produto; set => codigo_produto = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public Procedimentos Teste { get => teste; set => teste = value; }
       

        public bool Incluir()
        {
            
                classes.Database db = new classes.Database();

                try
                {
                    db.Conectar();

                    long Id = db.ExecutarComandoSQL("INSERT INTO tb_produto VALUES(DEFAULT,'" + this.descricao + "','"+this.tipo+"',DEFAULT)", true);
                   
                    
                    return true;
                }
                catch (Exception er)
                {
                    throw new Exception("Erro ao cadastrar produto -ERRO:" + er.Message);
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
                return db.RetDataTable("SELECT idProduto, descricao, tipoProduto FROM tb_produto ORDER BY idProduto ASC");

            }


            catch (Exception er)
            {
                throw new Exception("Erro ao listar! - ERRO:" + er.Message);
            }


        }
        public void Alterar()
        {

        }
        public bool Excluir(int ID)
        {
            Database db = new Database();
            try
            {
                db.Conectar();

                db.ExecutarComandoSQL("DELETE FROM tb_produto WHERE idProduto = '" + ID + "'");

                return true;
            }
            catch (Exception er)
            {
                throw new Exception("Erro ao deletar produto!" + er.Message);
            }
            finally
            {
                db = null;
            }

        }
        public void Consultar()
        {

        }
        public int GerarCod() 
        {
            
            return Codigo_produto;
        }
    }
}
