using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho.Modelo
{
    public class Imovel
    {
        public int ID { get; set; }
        public string Categoria { get; set; }
        public string Status { get; set; }
        public string Faixa_Area { get; set; }
        public string Faixa_Area_Privada { get; set; }
        public string Faixa_Preco_IPTU { get; set; }
        public string Faixa_Area_Condominio { get; set; }
        public bool Flg_Planta { get; set; }
        public bool Flg_Dependencia { get; set; }
        public bool Flg_Sacada { get; set; }
        public bool Flg_Portaria { get; set; }
        public bool Flg_Elevador { get; set; }
        public string Churrasqueira { get; set; }
        public string Faixa_Dormintorios { get; set; }
        public string Faixa_Suites { get; set; }
        public string Faixa_Vagas { get; set; }
        public string Faixa_Banheiros { get; set; }
        public string Faixa_Valor_Venda { get; set; }
        public string Faixa_Valor_Aluguel { get; set; }
        public bool Flg_Mostra_mapa { get; set; }
    }
}
