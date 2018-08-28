using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho.Modelo
{
    public class FATO
    {
       public int ID { get; set; }
       public List<Regiao> Regiao { get; set; }
       public List<Tempo> Tempo { get; set; }
       public List<Imovel> Imovel { get; set; }
    }
}
