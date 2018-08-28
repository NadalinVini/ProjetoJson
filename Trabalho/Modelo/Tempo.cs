using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho.Modelo
{
    public class Tempo
    {
        public int ID { get; set; }
        public string Analise_Mensal { get; set; }
        public string Clima { get; set; }
        public int Semana_Mes { get; set; }
        public bool Flg_Feriado { get; set; }
        public bool Flg_Final_Semana { get; set; }
        public int Mes_Ano {get;set;}
        public DateTime dia { get; set; }
        public string Estacao_Ano { get; set; }
    }
}
