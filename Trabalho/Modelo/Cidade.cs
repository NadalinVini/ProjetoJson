using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho.Modelo
{
    public class Cidade
    {
        public int ID {get;set;}
        public string Des_Cidade { get; set; }
        public List<Estado> Estado { get; set; }
    }
}
