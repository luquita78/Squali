using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoPI.classes
{
    public class Procedimentos
    {
        private int idTeste;
        private string nome_teste;
        private string unidade_medida;
        private string especificado_min;
        private string especificado_max;
        private int roteiro;
      



        public Procedimentos() { }

        public Procedimentos(string nome_teste, string unidade_medida, string especificado_max, string especificado_min)
        {
            Nome_teste = nome_teste;
            Unidade_medida = unidade_medida;
            Especificado_max = especificado_max;
            Especificado_min = especificado_min;

        }

        public Procedimentos(int idTeste, string nome_teste, string unidade_medida, string especificado_max, string especificado_min)
        {
            IdTeste = idTeste;
            Nome_teste = nome_teste;
            Unidade_medida = unidade_medida;
            Especificado_max = especificado_max;
            Especificado_min = especificado_min;
        }

        public int IdTeste { get => idTeste; set => idTeste = value; }
        
        public string Nome_teste { get => nome_teste; set => nome_teste = value; }
        public string Unidade_medida { get => unidade_medida; set => unidade_medida = value; }
        public string Especificado_max { get => especificado_max; set => especificado_max = value; }
        public string Especificado_min { get => especificado_min; set => especificado_min = value; }
        public int Roteiro { get => roteiro; set => roteiro = value; }

        public bool Incluir()
        {
            Database db = new Database();
            try
            {
                db.Conectar();

                long id = db.ExecutarComandoSQL("INSERT INTO tb_teste VALUES(DEFAULT,'" + this.nome_teste + "','" + this.unidade_medida + "','" + this.especificado_min + "','" + this.especificado_max + "')", true);

                
                

                return true;
            }
            catch (Exception er)
            {
                throw new Exception("Erro ao cadastrar Teste! - Erro:" + er.Message);
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
                return db.RetDataTable("SELECT idTeste, nomeTeste, unidadeMedida, especMin, especMax FROM tb_teste ORDER BY idTeste");

            }


            catch (Exception er)
            {
                throw new Exception("Erro ao listar! - ERRO:" + er.Message);
            }


        }

        public bool Excluir(int ID)
        {
            Database db = new Database();
            try
            {
                db.Conectar();

                db.ExecutarComandoSQL("DELETE FROM tb_teste WHERE idTeste = '" + ID + "'");

                return true;
            }
            catch (Exception er)
            {
                throw new Exception("Erro ao deletar teste!" + er.Message);
            }
            finally
            {
                db = null;
            }

        }

        public Procedimentos getTestePeloID(int ID)
        {
            Database db = new Database();
            try
            {
                db.Conectar();
                DataTable dados_teste = db.RetDataTable("SELECT *FROM tb_teste WHERE idTeste = '" + ID + "'");


                DataRow row = dados_teste.Rows[0];

                return new Procedimentos (int.Parse(row["idTeste"].ToString()), row["nomeTeste"].ToString(), row["unidadeMedida"].ToString(), row["especMin"].ToString(), row["especMax"].ToString());

            }


            catch (Exception er)
            {
                throw new Exception("Erro ao listar! - ERRO:" + er.Message);
            }
        }
    }


}
