using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho.Modelo
{
    public class Regiao
    {
        public int ID { get; set; }
        public string Cep { get; set; }            
        public Decimal Latitude { get; set; }
        public Decimal Longitude { get; set; }        
        public List<Bairro> Bairro { get; set; }
       
    }
}

