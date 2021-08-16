using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoPI.classes
{
    public class Pedido
    {
        private int idPedido;
        private string cliente;
        private double quantidade;
        private string maquina;
        private string ordemProducao;
        private int codigoProduto;

        public int IdPedido { get => idPedido; set => idPedido = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public double Quantidade { get => quantidade; set => quantidade = value; }
        public string Maquina { get => maquina; set => maquina = value; }
        public string OrdemProducao { get => ordemProducao; set => ordemProducao = value; }
        public int CodigoProduto { get => codigoProduto; set => codigoProduto = value; }

        public Pedido() { }

        public Pedido(string cliente, double quantidade, string maquina, string ordemProducao, int codigoProduto)
        {
            Cliente = cliente;
            Quantidade = quantidade;
            Maquina = maquina;
            OrdemProducao = ordemProducao;
            CodigoProduto = codigoProduto;
        }

        public bool Incluir()
        {
            classes.Database db = new classes.Database();

            try
            {
                db.Conectar();

                long Id = db.ExecutarComandoSQL("INSERT INTO tb_pedido VALUES(default,'" + this.Quantidade + "','" + this.Maquina + "','" + this.OrdemProducao + "','" + this.cliente + "','" + this.codigoProduto + "')", true);
                return true;
            }
            catch (Exception er)
            {
                throw new Exception("Erro na realização do pedido! -ERRO:" + er.Message);
            }
            finally
            {
                db = null;
            }

        }

        public void Alterar()
        {

        }
        public void Excluir()
        {

        }
        public void Consultar()
        {

        }
    }
}
