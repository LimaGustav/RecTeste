using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecTestBack
{
    public class Filtro
    {
        public int FiltrarNome(List<string> Nomes)
        {
            return Nomes.Where(x => x.StartsWith("g")).Count();
        }
    }
}