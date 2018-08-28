using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho.Modelo
{
    public class Bairro
    {
        public int ID { get; set; }
        public string Des_Bairro { get; set; }
        public List<Cidade> Cidade { get; set; }
    }
}
