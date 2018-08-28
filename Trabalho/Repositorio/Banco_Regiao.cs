using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.Modelo;

namespace Trabalho.Repositorio
{
    public class Banco_Regiao
    {       
        //Buscando por Estado
        #region BuscarEstado
        public int BuscarEstado(string des_estado)
        {
            using (TrabalhoEFEntities context = new TrabalhoEFEntities())
            {

                int qtd = (from p in context.TAB_Estado where p.Des_Estado == des_estado select p).Count();

                return qtd;
            }
        }
        #endregion

        #region BucarEstadoporId

        public int BucarEstadoporId(string des_estado)
        {
            using (TrabalhoEFEntities context = new TrabalhoEFEntities())
            {

                decimal qtd = (from p in context.TAB_Estado where p.Des_Estado == des_estado select p.Idf_Estado).First();
                int x = Convert.ToInt32(qtd);
                return x;
            }
        }

        #endregion

        #region AdicionaEstado
        public void AdicionaEstado(string des_estado)
        {
            TrabalhoEFEntities ef = new TrabalhoEFEntities();
            TAB_Estado estado = new TAB_Estado();
            estado.Des_Estado = des_estado;
            ef.TAB_Estado.Add(estado);

            ef.SaveChanges();
        }
        #endregion

        //Buscando por Cidade
        #region BuscaCidade
        public int BuscaCidade(string des_cidade)
        {
            using (TrabalhoEFEntities context = new TrabalhoEFEntities())
            {

                int qtd = (from p in context.TAB_Cidade where p.Des_Cidade == des_cidade select p).Count();

                return qtd;
            }
        }
        #endregion

        #region AdicionaCidade

        public void AdicionaCidade(string des_cidade, string des_estado)
        {
            TrabalhoEFEntities ef = new TrabalhoEFEntities();
            TAB_Cidade cidade = new TAB_Cidade();
            cidade.Des_Cidade = des_cidade;
            cidade.Idf_Estado = BucarEstadoporId(des_estado);
            ef.TAB_Cidade.Add(cidade);

            ef.SaveChanges();
        }

        #endregion

        #region BuscarCidadeporId
        public int BuscarCidadeporId(string des_cidade)
        {
            using (TrabalhoEFEntities context = new TrabalhoEFEntities())
            {

                decimal qtd = (from p in context.TAB_Cidade where p.Des_Cidade == des_cidade select p.Idf_Cidade).First();
                int x = Convert.ToInt32(qtd);

                return x;
            }
        }
        #endregion

        //Buscando por Bairro
        #region AdicionaBairro
        public void AdicionaBairro(string des_cidade, string des_bairro, long cep)
        {
            TrabalhoEFEntities ef = new TrabalhoEFEntities();
            TAB_Bairro bairro = new TAB_Bairro();
            bairro.Des_Bairro = des_bairro;
            bairro.CEP = cep;
            bairro.Idf_Cidade = BuscarCidadeporId(des_cidade);
            ef.TAB_Bairro.Add(bairro);

            ef.SaveChanges();
        }
        #endregion

        #region BuscarBairro
        public int BuscarBairro(string des_bairro)
        {
            using (TrabalhoEFEntities context = new TrabalhoEFEntities())
            {

                int qtd = (from p in context.TAB_Bairro where p.Des_Bairro == des_bairro select p).Count();

                return qtd;
            }
        }
        #endregion

        #region BuscarBairroporId
        public int BuscarBairroporId(string des_cidade)
        {
            using (TrabalhoEFEntities context = new TrabalhoEFEntities())
            {

                int qtd = Convert.ToInt32((from p in context.TAB_Bairro where p.Des_Bairro == des_cidade select p.Idf_Bairro).First());

                return qtd;
            }
        }
        #endregion
    }
}
