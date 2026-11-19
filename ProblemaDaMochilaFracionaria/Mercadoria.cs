using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaDaMochilaFracionaria
{
    internal class Mercadoria
    {
        public string Nome { get; set; }
        public double Peso { get; set; }
        public double Valor { get; set; }

        public double Razao
        {
            get { return Valor / Peso; }
        }
    }
}
