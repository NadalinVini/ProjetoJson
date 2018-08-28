using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho.Repositorio
{
    public class Banco_Regiao
    {
        public void AdicionarRegiao(Decimal latitude, Decimal longitude, string desBairro, string desCidade,
                                    string desEstado)
        {
            Regiao regiao = new Regiao();
            Bairro bairro = new Bairro();
            Estado estado = new Estado();
            Cidade cidade = new Cidade();

            if(latitude != null)
            regiao.Latitude = latitude;

            if(longitude != null)
            regiao.Longitude = longitude;

            if (desBairro != null)
                bairro.Des_Bairro = desBairro;

            if (desCidade != null)
                cidade.Des_Cidade = desCidade;

            if (desEstado != null)
                estado.Des_Estado = desEstado;
               

            TrabalhoEFEntities ef = new TrabalhoEFEntities();
            ef.Regiao.Add(regiao);
            ef.Estado.Add(estado);
            ef.Cidade.Add(cidade);
            ef.Bairro.Add(bairro);

            ef.SaveChanges();

        }

        public int BuscarEstado(string des_estado)
        {
            using (TrabalhoEFEntities context = new TrabalhoEFEntities())
            {

                int qtd = (from p in context.Estado where p.Des_Estado == des_estado select p).Count();

                return qtd;
            }
        }
    }
}
