using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaDaMochilaFracionaria
{
    internal class ResultadoMochila
    {
        public double ValorTotal { get; set; }
        public double PesoTotal { get; set; }

        public List<ResultadoCarga> CargasSelecionadas { get; set; }
            = new List<ResultadoCarga>();
    }
}
